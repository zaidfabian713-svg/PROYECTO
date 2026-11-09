using System;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{

	public partial class MainForm : Form
	{
		public GestorEstructuras Gestor;
		public ConexionBD BaseDatos;

		public MainForm()
		{
			InitializeComponent();
			Gestor = new GestorEstructuras();
			BaseDatos = new ConexionBD();
		}

		// Boton 1: Pelea de 1 jugador contra los Duendes
		private void BtnModoHistoriaClick(object sender, EventArgs e)
		{
			FormCombate ventana = new FormCombate(Gestor, BaseDatos, true);
			ventana.ShowDialog();
		}

		// Boton 2: Pelea de 2 jugadores en la misma PC
		private void BtnModo2JugadoresClick(object sender, EventArgs e)
		{
			FormCombate ventana = new FormCombate(Gestor, BaseDatos, false);
			ventana.ShowDialog();
		}

		// Boton 3: Muestra las 16 cartas y sus puntos
		private void BtnLoreClick(object sender, EventArgs e)
		{
			FormLore ventana = new FormLore(Gestor);
			ventana.ShowDialog();
		}

		// Boton 4: Crear cartas (suma = 100) y armar los mazos de 5 personajes
		private void BtnGeneradorMazosClick(object sender, EventArgs e)
		{
			FormGeneradorMazos ventana = new FormGeneradorMazos(Gestor);
			ventana.ShowDialog();
		}

		// Boton 5: Guardar jugadores y ver estadisticas en SQL
		private void BtnGestionMazosClick(object sender, EventArgs e)
		{
			FormGestionBD ventana = new FormGestionBD(Gestor, BaseDatos);
			ventana.ShowDialog();
		}

		// Boton 6: Jugar en red local entre dos ventanas
		private void BtnCombateRedClick(object sender, EventArgs e)
		{
			FormCombateRed ventana = new FormCombateRed(Gestor);
			ventana.ShowDialog();
		}

		// Boton 7: Leer el archivo de texto PuntajesMaximos.txt
		private void BtnLeerTxtClick(object sender, EventArgs e)
		{
			string datosTxt = Gestor.LeerPuntajesMaximosTxt();
			MessageBox.Show(datosTxt, "Puntajes Guardados (.TXT)");
		}
	}
}
