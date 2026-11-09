using System;
using System.Collections.Generic;
using System.IO;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Clase donde guardamos el arreglo de 12 personajes, las listas, las colas, la pila y los archivos .txt
	public class GestorEstructuras
	{
		// Arreglo de 12 personajes (3 de Agua, 3 de Tierra, 3 de Viento, 3 de Fuego)
		public static Personaje[] Catalogo12Personajes = new Personaje[12];

		// Listas para manejar el catalogo y los mazos de 5 cartas
		public List<Personaje> ListaPersonajes;
		public List<CartaEscenario> ListaEscenarios;
		public List<Personaje> MazoGuardadoJ1;
		public List<Personaje> MazoGuardadoJ2;

		// Instanciamos la Cola (Queue) solo para los relevos en combate
		public Queue<Personaje> ColaJugador1;
		public Queue<Personaje> ColaJugador2;

		// Instanciamos la Pila (Stack) solo para el historial de ataques
		public Stack<string> PilaHistorial;

		public GestorEstructuras()
		{
			ListaPersonajes = new List<Personaje>();
			ListaEscenarios = new List<CartaEscenario>();
			MazoGuardadoJ1 = new List<Personaje>();
			MazoGuardadoJ2 = new List<Personaje>();
			ColaJugador1 = new Queue<Personaje>();
			ColaJugador2 = new Queue<Personaje>();
			PilaHistorial = new Stack<string>();

			CargarCatalogo16Cartas();
			CargarMazosIniciales();
		}

		// Instanciamos los 12 personajes (todos suman HP + DEF + ATK = 100) y los 4 escenarios
		public void CargarCatalogo16Cartas()
		{
			ListaPersonajes.Clear();
			ListaEscenarios.Clear();

			// 5 Protagonistas con su pequena historia (contexto y motivo)
			Catalogo12Personajes[0] = new Protagonista(1, "Fabián - El Titán de Hierro",  "Tierra", 45, 30, 25, 65, "Guerrero");
			Catalogo12Personajes[0].Historia = "Contexto: Antiguo herrero de las montañas del norte cuya aldea fue destruida por un gran terremoto.\r\nMotivo: Entró a la Arena Elemental con su armadura de hierro para proteger a su pueblo y demostrar que la defensa de la Tierra es inquebrantable.";

			Catalogo12Personajes[1] = new Protagonista(2, "Deibislin - La Maga de Fuego", "Fuego",  42, 20, 38, 80, "Maga");
			Catalogo12Personajes[1].Historia = "Contexto: Joven aprendiz de la Academia Real que descubrió el poder de las llamas antiguas en un libro olvidado.\r\nMotivo: Lucha en la Arena para dominar su fuego interior y recuperar el honor de su familia.";

			Catalogo12Personajes[2] = new Protagonista(3, "Jesús - El Curandero Blanco",  "Viento", 44, 32, 24, 75, "Sanador");
			Catalogo12Personajes[2].Historia = "Contexto: Monje viajero del Templo del Viento que juró usar su energía para sanar a los heridos.\r\nMotivo: Participa en el torneo buscando detener el conflicto y restaurar la paz entre las cuatro facciones.";

			Catalogo12Personajes[3] = new Protagonista(4, "Yeferson - El Alquimista",     "Agua",   46, 26, 28, 70, "Alquimista");
			Catalogo12Personajes[3].Historia = "Contexto: Estudiante e investigador de los pantanos del sur que prepara pociones de agua y ácidos.\r\nMotivo: Su razón para combatir es reunir los ingredientes necesarios para crear una medicina capaz de curar cualquier enfermedad.";

			Catalogo12Personajes[4] = new Protagonista(5, "Ereu - El Brujo de Sombras",   "Fuego",  40, 22, 38, 35, "Brujo");
			Catalogo12Personajes[4].Historia = "Contexto: Hechicero solitario que entrenó en las ruinas volcánicas dominando el fuego oscuro.\r\nMotivo: Entró a la Arena Elemental para absorber la energía de los guerreros más fuertes y probar su poder.";

			// 7 Duendes (Niveles 1 al 7) con su pequena historia (contexto y motivo)
			Catalogo12Personajes[5]  = new Duende(6,  "Duende Explorador Nv. 1", "Tierra", 52, 28, 20, 30, 1);
			Catalogo12Personajes[5].Historia = "Contexto: Pequeño vigía de las cuevas subterráneas encargado de vigilar los caminos de piedra.\r\nMotivo: Pelea por órdenes directas del Rey Duende para defender la entrada de su territorio.";

			Catalogo12Personajes[6]  = new Duende(7,  "Duende Saqueador Nv. 2",  "Viento", 50, 26, 24, 35, 2);
			Catalogo12Personajes[6].Historia = "Contexto: Habitante veloz de los cañones ventosos que sobrevive buscando objetos perdidos.\r\nMotivo: Entra al combate motivado por la promesa de quedarse con las monedas y armaduras de los rivales vencidos.";

			Catalogo12Personajes[7]  = new Duende(8,  "Duende Chamán Nv. 3",     "Agua",   48, 26, 26, 55, 3);
			Catalogo12Personajes[7].Historia = "Contexto: Aprendiz de magia de la tribu del río que aprendió a controlar la lluvia.\r\nMotivo: Su motivo es proteger los manantiales de agua limpia donde vive su clan.";

			Catalogo12Personajes[8]  = new Duende(9,  "Duende Cazador Nv. 4",    "Agua",   46, 24, 30, 45, 4);
			Catalogo12Personajes[8].Historia = "Contexto: Rastreador experto de las cascadas que entrena todos los días con su lanza.\r\nMotivo: Lucha en la Arena para llevar alimento a su aldea y subir de rango en el ejército duende.";

			Catalogo12Personajes[9]  = new Duende(10, "Duende Berserker Nv. 5",  "Tierra", 42, 26, 32, 25, 5);
			Catalogo12Personajes[9].Historia = "Contexto: Guerrero criado en las minas profundas que destaca por su resistencia física.\r\nMotivo: Su único objetivo es enfrentarse a guerreros grandes como Fabián para medir su fuerza.";

			Catalogo12Personajes[10] = new Duende(11, "Duende Capitán Nv. 6",    "Viento", 44, 22, 34, 40, 6);
			Catalogo12Personajes[10].Historia = "Contexto: Comandante veterano de la guardia real que dirige a las tropas desde las alturas.\r\nMotivo: Combate por lealtad a su rey y para mantener unidas a las tribus del viento.";

			Catalogo12Personajes[11] = new Duende(12, "Rey Duende Nv. 7",        "Fuego",  45, 20, 35, 60, 7);
			Catalogo12Personajes[11].Historia = "Contexto: Monarca del Volcán de Fuego que logró unir a los siete clanes duendes bajo una sola bandera.\r\nMotivo: Lucha en la Arena Elemental para defender su reino y exigir que los humanos respeten a su pueblo.";

			// Pasamos del arreglo a la lista usando un ciclo for y .Add()
			for (int i = 0; i < Catalogo12Personajes.Length; i++)
			{
				ListaPersonajes.Add(Catalogo12Personajes[i].Copiar());
			}

			// 4 Cartas de Escenario
			CartaEscenario esc1 = new CartaEscenario(13, "Santuario de Agua",   "Agua",   50);
			esc1.Historia = "Contexto: Antiguo templo rodeado de cascadas cristalinas.\r\nEfecto en combate: Fortalece a los personajes de Agua (+4 ATK) y debilita la defensa de los demás (-2 DEF).";
			ListaEscenarios.Add(esc1);

			CartaEscenario esc2 = new CartaEscenario(14, "Fortaleza de Tierra", "Tierra", 50);
			esc2.Historia = "Contexto: Muralla de piedra construida en las montañas del norte.\r\nEfecto en combate: Fortalece a los personajes de Tierra (+4 ATK) y debilita la defensa de los demás (-2 DEF).";
			ListaEscenarios.Add(esc2);

			CartaEscenario esc3 = new CartaEscenario(15, "Templo del Viento",   "Viento", 50);
			esc3.Historia = "Contexto: Ruinas elevadas en las cumbres donde soplan fuertes corrientes de aire.\r\nEfecto en combate: Fortalece a los personajes de Viento (+4 ATK) y debilita la defensa de los demás (-2 DEF).";
			ListaEscenarios.Add(esc3);

			CartaEscenario esc4 = new CartaEscenario(16, "Volcán de Fuego",     "Fuego",  50);
			esc4.Historia = "Contexto: Cráter ardiente gobernado por el Rey Duende.\r\nEfecto en combate: Fortalece a los personajes de Fuego (+4 ATK) y debilita la defensa de los demás (-2 DEF).";
			ListaEscenarios.Add(esc4);
		}

		public void CargarMazosIniciales()
		{
			MazoGuardadoJ1.Clear();
			MazoGuardadoJ2.Clear();

			for (int i = 0; i < 5; i++)
			{
				MazoGuardadoJ1.Add(Catalogo12Personajes[i].Copiar());
				MazoGuardadoJ2.Add(Catalogo12Personajes[i].Copiar());
			}
		}

		// Usa .Remove() para quitar un personaje de la lista del mazo
		public bool QuitarPersonajeDeMazo(List<Personaje> mazo, int indice)
		{
			if (indice >= 0 && indice < mazo.Count)
			{
				Personaje elegido = mazo[indice];
				return mazo.Remove(elegido);
			}
			return false;
		}

		// Pasa las 5 cartas de las listas a las Colas (Queue) usando foreach y Enqueue()
		public void PrepararColasCombate(bool contraDuendes)
		{
			ColaJugador1.Clear();
			ColaJugador2.Clear();

			foreach (Personaje p in MazoGuardadoJ1)
			{
				ColaJugador1.Enqueue(p.Copiar());
			}

			if (contraDuendes)
			{
				ColaJugador2.Enqueue(Catalogo12Personajes[5].Copiar());
				ColaJugador2.Enqueue(Catalogo12Personajes[6].Copiar());
				ColaJugador2.Enqueue(Catalogo12Personajes[8].Copiar());
				ColaJugador2.Enqueue(Catalogo12Personajes[10].Copiar());
				ColaJugador2.Enqueue(Catalogo12Personajes[11].Copiar());
			}
			else
			{
				foreach (Personaje p2 in MazoGuardadoJ2)
				{
					ColaJugador2.Enqueue(p2.Copiar());
				}
			}
		}

		// Guarda el historial de la Pila (Stack) en HistorialBatalla.txt
		public void GuardarTxt(string nombreArchivo)
		{
			try
			{
				string[] lineas = PilaHistorial.ToArray();
				StreamWriter escritor = new StreamWriter(nombreArchivo, false);
				escritor.WriteLine("=== HISTORIAL DE BATALLA - SANGRE Y DOGMA ===");
				escritor.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
				escritor.WriteLine("---------------------------------------------");

				for (int i = lineas.Length - 1; i >= 0; i--)
				{
					escritor.WriteLine(lineas[i]);
				}
				escritor.Close();
			}
			catch
			{
			}
		}

		// Escribe el ganador en PuntajesMaximos.txt
		public void RegistrarPuntajeMaximoTxt(string ganador, int puntaje)
		{
			try
			{
				StreamWriter escritor = new StreamWriter("PuntajesMaximos.txt", true);
				escritor.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " | " + ganador + " | Puntaje: " + puntaje + " pts");
				escritor.Close();
			}
			catch
			{
			}
		}

		// Lee el archivo PuntajesMaximos.txt con StreamReader
		public string LeerPuntajesMaximosTxt()
		{
			if (!File.Exists("PuntajesMaximos.txt"))
			{
				return "Aún no hay puntajes guardados en PuntajesMaximos.txt.";
			}

			StreamReader lector = new StreamReader("PuntajesMaximos.txt");
			string texto = lector.ReadToEnd();
			lector.Close();
			return texto;
		}
	}
}
