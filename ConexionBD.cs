using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	/*
	 * Script SQL de las 3 tablas con PK y FK:
	 * 
	 * CREATE DATABASE SangreYDogmaDB;
	 * USE SangreYDogmaDB;
	 * 
	 * CREATE TABLE Jugadores (
	 *     IdJugador INT PRIMARY KEY IDENTITY(1,1),
	 *     Nombre VARCHAR(50) NOT NULL
	 * );
	 * 
	 * CREATE TABLE Personajes (
	 *     IdPersonaje INT PRIMARY KEY IDENTITY(1,1),
	 *     IdJugador INT NOT NULL,
	 *     NombresMazo VARCHAR(250) NOT NULL,
	 *     FOREIGN KEY (IdJugador) REFERENCES Jugadores(IdJugador)
	 * );
	 * 
	 * CREATE TABLE Estadisticas (
	 *     IdEstadistica INT PRIMARY KEY IDENTITY(1,1),
	 *     IdJugador INT NOT NULL,
	 *     Victorias INT DEFAULT 0,
	 *     Derrotas INT DEFAULT 0,
	 *     FOREIGN KEY (IdJugador) REFERENCES Jugadores(IdJugador)
	 * );
	 */

	public class RegistroJugadorBD
	{
		public int IdJugador;
		public string Nombre;
		public int Victorias;
		public int Derrotas;
		public string ResumenMazo;
	}

	// Clase para conectar a SQL Server usando parametros (SqlParameter)
	public class ConexionBD
	{
		public string CadenaConexion = "Server=localhost;Database=SangreYDogmaDB;Trusted_Connection=True;";
		public List<RegistroJugadorBD> ListaLocal = new List<RegistroJugadorBD>();
		public string ArchivoRespaldo = "RespaldoBD.txt";

		public ConexionBD()
		{
			CargarRespaldoLocal();
		}

		// Guarda el jugador y su mazo de 5 cartas usando SqlParameter para evitar errores o inyeccion SQL
		public string GuardarJugadorYMazo(string nombreJugador, List<Personaje> mazo5Cartas)
		{
			string resumen = mazo5Cartas[0].Nombre + ", " + mazo5Cartas[1].Nombre + ", " +
			                 mazo5Cartas[2].Nombre + ", " + mazo5Cartas[3].Nombre + ", " +
			                 mazo5Cartas[4].Nombre;

			try
			{
				SqlConnection conexion = new SqlConnection(CadenaConexion);
				conexion.Open();

				// 1. Insertamos en Jugadores y obtenemos su clave primaria (PK)
				string sqlJugador = "INSERT INTO Jugadores (Nombre) OUTPUT INSERTED.IdJugador VALUES (@Nombre)";
				SqlCommand cmd1 = new SqlCommand(sqlJugador, conexion);
				cmd1.Parameters.Add(new SqlParameter("@Nombre", nombreJugador));
				int idGeneradoPK = Convert.ToInt32(cmd1.ExecuteScalar());

				// 2. Insertamos el mazo en Personajes con la clave foranea (FK)
				string sqlPersonajes = "INSERT INTO Personajes (IdJugador, NombresMazo) VALUES (@IdJugador, @NombresMazo)";
				SqlCommand cmd2 = new SqlCommand(sqlPersonajes, conexion);
				cmd2.Parameters.Add(new SqlParameter("@IdJugador", idGeneradoPK));
				cmd2.Parameters.Add(new SqlParameter("@NombresMazo", resumen));
				cmd2.ExecuteNonQuery();

				// 3. Insertamos las estadisticas iniciales en Estadisticas con la clave foranea (FK)
				string sqlEstadisticas = "INSERT INTO Estadisticas (IdJugador, Victorias, Derrotas) VALUES (@IdJugador, @Vic, @Der)";
				SqlCommand cmd3 = new SqlCommand(sqlEstadisticas, conexion);
				cmd3.Parameters.Add(new SqlParameter("@IdJugador", idGeneradoPK));
				cmd3.Parameters.Add(new SqlParameter("@Vic", 0));
				cmd3.Parameters.Add(new SqlParameter("@Der", 0));
				cmd3.ExecuteNonQuery();

				conexion.Close();
				return "Guardado en SQL Server (ID = " + idGeneradoPK + ").";
			}
			catch
			{
				// Si no hay SQL Server instalado en la PC, lo guarda en el archivo de respaldo
				RegistroJugadorBD reg = new RegistroJugadorBD();
				reg.IdJugador = ListaLocal.Count + 1;
				reg.Nombre = nombreJugador;
				reg.Victorias = 0;
				reg.Derrotas = 0;
				reg.ResumenMazo = resumen;
				ListaLocal.Add(reg);
				GuardarRespaldoLocal();

				return "Guardado en respaldo local (ID = " + reg.IdJugador + ").";
			}
		}

		// Suma +1 victoria o +1 derrota usando SqlParameter
		public void SumarResultado(int idJugadorFK, bool esVictoria)
		{
			try
			{
				SqlConnection conexion = new SqlConnection(CadenaConexion);
				conexion.Open();

				string sql = "UPDATE Estadisticas SET Derrotas = Derrotas + 1 WHERE IdJugador = @IdJugador";
				if (esVictoria)
				{
					sql = "UPDATE Estadisticas SET Victorias = Victorias + 1 WHERE IdJugador = @IdJugador";
				}

				SqlCommand cmd = new SqlCommand(sql, conexion);
				cmd.Parameters.Add(new SqlParameter("@IdJugador", idJugadorFK));
				cmd.ExecuteNonQuery();

				conexion.Close();
			}
			catch
			{
				for (int i = 0; i < ListaLocal.Count; i++)
				{
					if (ListaLocal[i].IdJugador == idJugadorFK)
					{
						if (esVictoria)
							ListaLocal[i].Victorias = ListaLocal[i].Victorias + 1;
						else
							ListaLocal[i].Derrotas = ListaLocal[i].Derrotas + 1;
					}
				}
				GuardarRespaldoLocal();
			}
		}

		// Lee los jugadores y sus estadisticas con SqlDataReader
		public List<RegistroJugadorBD> ConsultarTodos()
		{
			List<RegistroJugadorBD> resultado = new List<RegistroJugadorBD>();
			try
			{
				SqlConnection conexion = new SqlConnection(CadenaConexion);
				conexion.Open();

				string sql =
					"SELECT J.IdJugador, J.Nombre, E.Victorias, E.Derrotas, P.NombresMazo " +
					"FROM Jugadores J " +
					"INNER JOIN Estadisticas E ON J.IdJugador = E.IdJugador " +
					"INNER JOIN Personajes P ON J.IdJugador = P.IdJugador";

				SqlCommand cmd = new SqlCommand(sql, conexion);
				SqlDataReader lector = cmd.ExecuteReader();

				while (lector.Read())
				{
					RegistroJugadorBD r = new RegistroJugadorBD();
					r.IdJugador = Convert.ToInt32(lector["IdJugador"]);
					r.Nombre = lector["Nombre"].ToString();
					r.Victorias = Convert.ToInt32(lector["Victorias"]);
					r.Derrotas = Convert.ToInt32(lector["Derrotas"]);
					r.ResumenMazo = lector["NombresMazo"].ToString();
					resultado.Add(r);
				}

				lector.Close();
				conexion.Close();
				return resultado;
			}
			catch
			{
				return ListaLocal;
			}
		}

		private void GuardarRespaldoLocal()
		{
			try
			{
				StreamWriter sw = new StreamWriter(ArchivoRespaldo, false);
				for (int i = 0; i < ListaLocal.Count; i++)
				{
					RegistroJugadorBD r = ListaLocal[i];
					sw.WriteLine(r.IdJugador + ";" + r.Nombre + ";" + r.Victorias + ";" + r.Derrotas + ";" + r.ResumenMazo);
				}
				sw.Close();
			}
			catch
			{
			}
		}

		private void CargarRespaldoLocal()
		{
			ListaLocal.Clear();
			if (!File.Exists(ArchivoRespaldo))
			{
				RegistroJugadorBD demo = new RegistroJugadorBD();
				demo.IdJugador = 1;
				demo.Nombre = "Jugador 1";
				demo.Victorias = 2;
				demo.Derrotas = 0;
				demo.ResumenMazo = "Fabián, Deibislin, Jesús, Yeferson, Ereu";
				ListaLocal.Add(demo);
				GuardarRespaldoLocal();
				return;
			}

			try
			{
				string[] lineas = File.ReadAllLines(ArchivoRespaldo);
				for (int i = 0; i < lineas.Length; i++)
				{
					string[] partes = lineas[i].Split(';');
					if (partes.Length >= 5)
					{
						RegistroJugadorBD r = new RegistroJugadorBD();
						r.IdJugador = Convert.ToInt32(partes[0]);
						r.Nombre = partes[1];
						r.Victorias = Convert.ToInt32(partes[2]);
						r.Derrotas = Convert.ToInt32(partes[3]);
						r.ResumenMazo = partes[4];
						ListaLocal.Add(r);
					}
				}
			}
			catch
			{
			}
		}
	}
}
