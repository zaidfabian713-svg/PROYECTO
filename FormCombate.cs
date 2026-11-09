using System;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Ventana de combate local: usa las Colas (Queue) para los relevos y la Pila (Stack) para la bitacora
	public partial class FormCombate : Form
	{
		public GestorEstructuras Gestor;
		public ConexionBD BaseDatos;
		public bool EsModoHistoria;
		public Personaje CartaJ1;
		public Personaje CartaJ2;

		public int Ronda = 1;
		public int Turno = 1;
		public int Segundos = 15;
		public bool FinJuego = false;

		public FormCombate(GestorEstructuras gestor, ConexionBD bd, bool esModoHistoria)
		{
			InitializeComponent();
			Gestor = gestor;
			BaseDatos = bd;
			EsModoHistoria = esModoHistoria;

			// 1. Limpiamos la Pila (Stack) del historial de la partida anterior
			Gestor.PilaHistorial.Clear();

			// 2. Preparamos las Colas (Queue) con los 5 personajes y sacamos el primero con Dequeue()
			Gestor.PrepararColasCombate(EsModoHistoria);
			CartaJ1 = Gestor.ColaJugador1.Dequeue();
			CartaJ2 = Gestor.ColaJugador2.Dequeue();

			// 3. El jugador que inicia se decide con un generador aleatorio (Enunciado Seccion 5)
			Random aleatorio = new Random();
			Turno = aleatorio.Next(1, 3); // Devuelve 1 o 2 al azar
			if (EsModoHistoria) Turno = 1;

			// 4. Cargamos las 4 Cartas de Escenario en el ComboBox
			for (int i = 0; i < Gestor.ListaEscenarios.Count; i++)
			{
				cmbEscenario.Items.Add(Gestor.ListaEscenarios[i].Nombre);
			}
			cmbEscenario.SelectedIndex = 0;

			GuardarLog("Inicia el combate (Sorteo: empieza Jugador " + Turno + "): " + CartaJ1.Nombre + " vs " + CartaJ2.Nombre);
			ActualizarPantalla();
			timerTurno.Start();
		}

		// Actualiza las etiquetas y las barras de progreso (ProgressBar de HP y de Habilidad Especial)
		private void ActualizarPantalla()
		{
			lblDatosJ1.Text = CartaJ1.Nombre + " [" + CartaJ1.Elemento + "]\n" +
				"ATK: " + CartaJ1.ATK + " | DEF: " + CartaJ1.DEF + " | ENER: " + CartaJ1.ENER + " | EMP: " + CartaJ1.EMP;
			lblVidaJ1.Text = "Vida (HP): " + CartaJ1.HP + " / " + CartaJ1.HPMax;
			pbVidaJ1.Maximum = CartaJ1.HPMax;
			pbVidaJ1.Value = CartaJ1.HP;
			lblEspecialJ1.Text = "Carga Especial (ESP): " + (CartaJ1.ESP * 50) + "% (" + CartaJ1.ESP + "/2)";
			pbEspecialJ1.Value = CartaJ1.ESP;
			lblColaJ1.Text = "Relevos en Cola (Queue): " + Gestor.ColaJugador1.Count;

			lblDatosJ2.Text = CartaJ2.Nombre + " [" + CartaJ2.Elemento + "]\n" +
				"ATK: " + CartaJ2.ATK + " | DEF: " + CartaJ2.DEF + " | ENER: " + CartaJ2.ENER + " | EMP: " + CartaJ2.EMP;
			lblVidaJ2.Text = "Vida (HP): " + CartaJ2.HP + " / " + CartaJ2.HPMax;
			pbVidaJ2.Maximum = CartaJ2.HPMax;
			pbVidaJ2.Value = CartaJ2.HP;
			lblEspecialJ2.Text = "Carga Especial (ESP): " + (CartaJ2.ESP * 50) + "% (" + CartaJ2.ESP + "/2)";
			pbEspecialJ2.Value = CartaJ2.ESP;
			lblColaJ2.Text = "Relevos en Cola (Queue): " + Gestor.ColaJugador2.Count;

			Personaje actual = CartaJ1;
			if (Turno == 2) actual = CartaJ2;

			lblInfoTurno.Text = "Ronda " + Ronda + " | Turno Jugador " + Turno + " (" + actual.Nombre + " - ENER: " + actual.ENER + ")";
			lblReloj.Text = "Tiempo: " + Segundos + " seg";

			// La Habilidad Especial no puede usarse en Ronda 1 y requiere 100% de carga (ESP == 2) y 2 de Energia
			if (Ronda == 1 || actual.ESP < 2 || actual.ENER < 2)
				btnHabilidadEspecial.Enabled = false;
			else
				btnHabilidadEspecial.Enabled = true;
		}

		// Apila cada evento en la Pila (Stack<string>) usando Push()
		private void GuardarLog(string texto)
		{
			Gestor.PilaHistorial.Push(texto);
			lstBitacora.Items.Insert(0, texto);
		}

		// BOTON ATACAR (Costo: 1 ENER): Permite multiples acciones si al jugador aun le queda Energia
		private void BtnAtacarClick(object sender, EventArgs e)
		{
			if (FinJuego) return;

			Personaje atacante = CartaJ1;
			Personaje defensor = CartaJ2;
			if (Turno == 2)
			{
				atacante = CartaJ2;
				defensor = CartaJ1;
			}

			if (atacante.ENER < 1)
			{
				MessageBox.Show("No tienes suficiente Energía (ENER). Pasa el turno para ganar +1 ENER.");
				return;
			}

			atacante.ENER = atacante.ENER - 1;
			int dano = atacante.Atacar(defensor);

			GuardarLog(atacante.Nombre + " (" + atacante.Elemento + ") ataca a " +
			           defensor.Nombre + " (" + defensor.Elemento + ") => -" + dano + " HP (Queda " + atacante.ENER + " ENER)");

			RevisarDerrotas();
			if (!FinJuego)
			{
				// Si se quedo sin energia o es el turno de la IA, cambia el turno automaticamente
				if (atacante.ENER <= 0 || (EsModoHistoria && Turno == 2))
					CambiarTurno();
				else
					ActualizarPantalla();
			}
		}

		// BOTON HABILIDAD ESPECIAL (Costo: 2 ENER y 2 ESP)
		private void BtnHabilidadEspecialClick(object sender, EventArgs e)
		{
			if (FinJuego) return;

			Personaje atacante = CartaJ1;
			Personaje defensor = CartaJ2;
			if (Turno == 2)
			{
				atacante = CartaJ2;
				defensor = CartaJ1;
			}

			if (Ronda == 1 || atacante.ESP < 2 || atacante.ENER < 2) return;

			atacante.ENER = atacante.ENER - 2;
			atacante.ESP = 0;

			string resultado = atacante.EjecutarHabilidadEspecial(defensor);
			GuardarLog(resultado);

			RevisarDerrotas();
			if (!FinJuego) CambiarTurno();
		}

		// BOTON RELEVO: Usa la Cola (Queue<Personaje>) con Enqueue() y Dequeue()
		private void BtnRelevoClick(object sender, EventArgs e)
		{
			if (FinJuego) return;

			if (Turno == 1 && Gestor.ColaJugador1.Count > 0)
			{
				Gestor.ColaJugador1.Enqueue(CartaJ1);
				CartaJ1 = Gestor.ColaJugador1.Dequeue();
				GuardarLog("Relevo Jugador 1 (Queue): entra " + CartaJ1.Nombre);
				CambiarTurno();
			}
			else if (Turno == 2 && Gestor.ColaJugador2.Count > 0)
			{
				Gestor.ColaJugador2.Enqueue(CartaJ2);
				CartaJ2 = Gestor.ColaJugador2.Dequeue();
				GuardarLog("Relevo Jugador 2 (Queue): entra " + CartaJ2.Nombre);
				CambiarTurno();
			}
			else
			{
				MessageBox.Show("No tienes más personajes en tu Cola de relevos.");
			}
		}

		// BOTON PASAR TURNO: Permite ahorrar Energia para el siguiente turno
		private void BtnPasarTurnoClick(object sender, EventArgs e)
		{
			if (FinJuego) return;
			GuardarLog("Jugador " + Turno + " pasa el turno para ahorrar Energía.");
			CambiarTurno();
		}

		// Si un personaje llega a 0 HP, extrae el siguiente relevo de la Cola con Dequeue()
		private void RevisarDerrotas()
		{
			if (CartaJ1.HP <= 0)
			{
				if (Gestor.ColaJugador1.Count > 0)
				{
					CartaJ1 = Gestor.ColaJugador1.Dequeue();
					GuardarLog("Cae Jugador 1. Entra relevo de la Cola: " + CartaJ1.Nombre);
				}
				else
				{
					TerminarPelea(false);
					return;
				}
			}

			if (CartaJ2.HP <= 0)
			{
				if (Gestor.ColaJugador2.Count > 0)
				{
					CartaJ2 = Gestor.ColaJugador2.Dequeue();
					GuardarLog("Cae Jugador 2. Entra relevo de la Cola: " + CartaJ2.Nombre);
				}
				else
				{
					TerminarPelea(true);
					return;
				}
			}
			ActualizarPantalla();
		}

		// Exporta automaticamente la Pila al archivo .TXT y actualiza las Estadisticas en la BD
		private void TerminarPelea(bool ganoJugador1)
		{
			FinJuego = true;
			timerTurno.Stop();

			string ganador = "¡Victoria del Jugador 2!";
			if (ganoJugador1) ganador = "¡Victoria del Jugador 1!";

			GuardarLog("FIN DEL COMBATE: " + ganador);

			Gestor.GuardarTxt("HistorialBatalla.txt");
			int puntaje = 100 - (Ronda * 5);
			if (puntaje < 10) puntaje = 10;
			Gestor.RegistrarPuntajeMaximoTxt(ganador, puntaje);

			if (BaseDatos != null && BaseDatos.ConsultarTodos().Count > 0)
			{
				int idPrimero = BaseDatos.ConsultarTodos()[0].IdJugador;
				BaseDatos.SumarResultado(idPrimero, ganoJugador1);
			}

			ActualizarPantalla();
			MessageBox.Show(ganador + "\n\nBitácora exportada automáticamente a HistorialBatalla.txt");
		}

		// Al cambiar de turno, el jugador gana +1 de Energia y +1 de carga de Habilidad Especial
		private void CambiarTurno()
		{
			if (Turno == 1)
			{
				Turno = 2;
				CartaJ2.ENER = CartaJ2.ENER + 1;
				if (CartaJ2.ESP < 2) CartaJ2.ESP = CartaJ2.ESP + 1;
			}
			else
			{
				Turno = 1;
				Ronda = Ronda + 1;
				CartaJ1.ENER = CartaJ1.ENER + 1;
				if (CartaJ1.ESP < 2) CartaJ1.ESP = CartaJ1.ESP + 1;
			}

			Segundos = 15;
			ActualizarPantalla();
		}

		private void TimerTurnoTick(object sender, EventArgs e)
		{
			if (FinJuego) return;

			if (EsModoHistoria && Turno == 2 && Segundos <= 13)
			{
				if (Ronda > 1 && CartaJ2.ESP >= 2 && CartaJ2.ENER >= 2)
					BtnHabilidadEspecialClick(null, null);
				else
					BtnAtacarClick(null, null);
				return;
			}

			Segundos = Segundos - 1;
			ActualizarPantalla();

			if (Segundos <= 0)
			{
				GuardarLog("Se agotó el tiempo: pasa el turno automáticamente.");
				CambiarTurno();
			}
		}

		// Aplica Buff (+4 ATK) o Nerf (-2 DEF) segun la compatibilidad con el Escenario
		private void BtnAplicarEscenarioClick(object sender, EventArgs e)
		{
			CartaEscenario esc = Gestor.ListaEscenarios[cmbEscenario.SelectedIndex];
			string b1 = esc.AplicarBuffNerf(CartaJ1);
			string b2 = esc.AplicarBuffNerf(CartaJ2);
			GuardarLog(b1);
			GuardarLog(b2);
			ActualizarPantalla();
		}

		// Dispara el evento algoritmico "Terremoto" evaluando el umbral de Empatia (EMP)
		private void BtnTerremotoClick(object sender, EventArgs e)
		{
			CartaEscenario esc = Gestor.ListaEscenarios[cmbEscenario.SelectedIndex];
			string r1 = esc.DispararTerremoto(CartaJ1);
			string r2 = esc.DispararTerremoto(CartaJ2);
			GuardarLog(r1);
			GuardarLog(r2);
			RevisarDerrotas();
			MessageBox.Show(r1 + "\n" + r2, "Evento Algorítmico: Terremoto");
		}

		// Muestra la pequena historia (contexto y motivo) de los personajes activos en combate
		private void BtnMostrarHistoriaClick(object sender, EventArgs e)
		{
			string texto =
				"=== JUGADOR 1: " + CartaJ1.Nombre + " (" + CartaJ1.Elemento + ") ===\r\n" +
				CartaJ1.Historia + "\r\n\r\n" +
				"=== RIVAL: " + CartaJ2.Nombre + " (" + CartaJ2.Elemento + ") ===\r\n" +
				CartaJ2.Historia;

			MessageBox.Show(texto, "MOSTRAR HISTORIA DE LOS COMBATIENTES");
		}

		private void FormCombateFormClosing(object sender, FormClosingEventArgs e)
		{
			timerTurno.Stop();
		}
	}
}
