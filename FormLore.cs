using System;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Ventana para consultar la historia (contexto y motivo) y los atributos de las 16 cartas
	public partial class FormLore : Form
	{
		public GestorEstructuras Gestor;

		public FormLore(GestorEstructuras gestor)
		{
			InitializeComponent();
			Gestor = gestor;

			this.Text = "Historia y Catálogo de Personajes";
			grpLista.Text = "16 Cartas del Catálogo";
			grpHistoria.Text = "Historia (Contexto y Motivo) y Atributos";
			btnMostrarHistoria.Text = "MOSTRAR HISTORIA";
			btnCerrar.Text = "Volver";

			for (int i = 0; i < Gestor.ListaPersonajes.Count; i++)
			{
				Personaje p = Gestor.ListaPersonajes[i];
				lstPersonajes.Items.Add("[" + p.Elemento + "] " + p.Nombre);
			}
			for (int j = 0; j < Gestor.ListaEscenarios.Count; j++)
			{
				CartaEscenario esc = Gestor.ListaEscenarios[j];
				lstPersonajes.Items.Add("[Escenario] " + esc.Nombre);
			}

			if (lstPersonajes.Items.Count > 0)
				lstPersonajes.SelectedIndex = 0;
		}

		private void LstPersonajesSelectedIndexChanged(object sender, EventArgs e)
		{
			int i = lstPersonajes.SelectedIndex;
			if (i < 0) return;

			if (i < Gestor.ListaPersonajes.Count)
			{
				Personaje p = Gestor.ListaPersonajes[i];
				int suma = p.HPMax + p.DEF + p.ATK;

				string tipoClase = "Personaje Base";
				if (p is Protagonista)
				{
					Protagonista prota = (Protagonista)p;
					tipoClase = "Clase Hija: Protagonista (Rol: " + prota.Rol + ")";
				}
				else if (p is Duende)
				{
					Duende duen = (Duende)p;
					tipoClase = "Clase Hija: Duende (Nivel: " + duen.Nivel + ")";
				}

				txtHistoria.Text =
					"HISTORIA DEL PERSONAJE (CONTEXTO Y MOTIVO)\r\n" +
					"--------------------------------------------\r\n" +
					p.Historia + "\r\n\r\n" +
					"FICHA TÉCNICA DE PERSONAJE\r\n" +
					"--------------------------------------------\r\n" +
					"Nombre: " + p.Nombre + "\r\n" +
					"Jerarquía POO: " + tipoClase + "\r\n" +
					"Facción Elemental: " + p.Elemento + "\r\n\r\n" +
					"ATRIBUTOS BALANCEADOS (SUMA = 100):\r\n" +
					"- Vida (HP): " + p.HPMax + "\r\n" +
					"- Defensa (DEF): " + p.DEF + "\r\n" +
					"- Ataque (ATK): " + p.ATK + "\r\n" +
					"- Suma Total: " + suma + " / 100 puntos\r\n" +
					"- Empatía ante Terremoto (EMP): " + p.EMP;
			}
			else
			{
				CartaEscenario esc = Gestor.ListaEscenarios[i - Gestor.ListaPersonajes.Count];
				txtHistoria.Text =
					"HISTORIA Y CONTEXTO DEL ESCENARIO\r\n" +
					"--------------------------------------------\r\n" +
					esc.Historia + "\r\n\r\n" +
					"FICHA TÉCNICA DE CARTA DE ESCENARIO\r\n" +
					"--------------------------------------------\r\n" +
					"Nombre: " + esc.Nombre + "\r\n" +
					"Elemento Asociado: " + esc.Elemento + "\r\n" +
					"Umbral de Empatía (Terremoto): " + esc.UmbralEMP + " puntos.";
			}
		}

		// Boton MOSTRAR HISTORIA para ver el contexto y motivo del personaje seleccionado
		private void BtnMostrarHistoriaClick(object sender, EventArgs e)
		{
			int i = lstPersonajes.SelectedIndex;
			if (i < 0) return;

			if (i < Gestor.ListaPersonajes.Count)
			{
				Personaje p = Gestor.ListaPersonajes[i];
				MessageBox.Show(
					"Personaje: " + p.Nombre + " (" + p.Elemento + ")\r\n\r\n" + p.Historia,
					"MOSTRAR HISTORIA - " + p.Nombre);
			}
			else
			{
				CartaEscenario esc = Gestor.ListaEscenarios[i - Gestor.ListaPersonajes.Count];
				MessageBox.Show(
					"Escenario: " + esc.Nombre + "\r\n\r\n" + esc.Historia,
					"MOSTRAR HISTORIA - " + esc.Nombre);
			}
		}

		private void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
