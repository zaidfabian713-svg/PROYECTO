using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Ventana para guardar jugadores en la Base de Datos y ver sus estadisticas
	public partial class FormGestionBD : Form
	{
		public GestorEstructuras Gestor;
		public ConexionBD BaseDatos;
		public List<RegistroJugadorBD> ListaMostrada;

		public FormGestionBD(GestorEstructuras gestor, ConexionBD bd)
		{
			InitializeComponent();
			Gestor = gestor;
			BaseDatos = bd;
			ListaMostrada = new List<RegistroJugadorBD>();

			MostrarMazoActual();
			CargarTablaJugadores();
		}

		private void MostrarMazoActual()
		{
			lstMazoGuardar.Items.Clear();
			for (int i = 0; i < Gestor.MazoGuardadoJ1.Count; i++)
			{
				lstMazoGuardar.Items.Add((i + 1) + ". " + Gestor.MazoGuardadoJ1[i].Nombre);
			}
		}

		private void CargarTablaJugadores()
		{
			BaseDatos.CadenaConexion = txtCadena.Text;
			ListaMostrada = BaseDatos.ConsultarTodos();

			lstRegistros.Items.Clear();
			for (int i = 0; i < ListaMostrada.Count; i++)
			{
				RegistroJugadorBD r = ListaMostrada[i];
				int partidas = r.Victorias + r.Derrotas;
				lstRegistros.Items.Add(
					"PK:" + r.IdJugador + " | " + r.Nombre +
					" (Partidas:" + partidas + " | V:" + r.Victorias + " | D:" + r.Derrotas + ")");
			}

			if (lstRegistros.Items.Count > 0)
				lstRegistros.SelectedIndex = 0;
		}

		private void BtnGuardarBDClick(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text.Trim();
			if (nombre == "")
			{
				MessageBox.Show("Escribe el nombre del jugador.");
				return;
			}

			BaseDatos.CadenaConexion = txtCadena.Text;
			string respuesta = BaseDatos.GuardarJugadorYMazo(nombre, Gestor.MazoGuardadoJ1);

			txtNombre.Text = "";
			CargarTablaJugadores();
			MessageBox.Show(respuesta);
		}

		// Calcula Partidas Jugadas y el Porcentaje de Exito (%) del jugador seleccionado
		private void LstRegistrosSelectedIndexChanged(object sender, EventArgs e)
		{
			int i = lstRegistros.SelectedIndex;
			if (i < 0 || i >= ListaMostrada.Count) return;

			RegistroJugadorBD r = ListaMostrada[i];
			int partidasJugadas = r.Victorias + r.Derrotas;
			double porcentajeExito = 0;
			if (partidasJugadas > 0)
			{
				porcentajeExito = ((double)r.Victorias / (double)partidasJugadas) * 100.0;
			}

			lblDetalleRegistro.Text =
				"Jugador (PK " + r.IdJugador + "): " + r.Nombre + "\r\n" +
				"Partidas: " + partidasJugadas + " | Victorias: " + r.Victorias + " | Derrotas: " + r.Derrotas +
				" | Éxito: " + Math.Round(porcentajeExito, 1) + "%\r\n" +
				"Mazo (FK): " + r.ResumenMazo;
		}

		private void BtnSumarVictoriaClick(object sender, EventArgs e)
		{
			int i = lstRegistros.SelectedIndex;
			if (i < 0 || i >= ListaMostrada.Count) return;

			BaseDatos.SumarResultado(ListaMostrada[i].IdJugador, true);
			CargarTablaJugadores();
		}

		private void BtnSumarDerrotaClick(object sender, EventArgs e)
		{
			int i = lstRegistros.SelectedIndex;
			if (i < 0 || i >= ListaMostrada.Count) return;

			BaseDatos.SumarResultado(ListaMostrada[i].IdJugador, false);
			CargarTablaJugadores();
		}

		private void BtnVolverClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
