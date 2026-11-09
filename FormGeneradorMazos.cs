using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Ventana para crear cartas (suma = 100) y armar los mazos de 5 personajes usando Listas
	public partial class FormGeneradorMazos : Form
	{
		public GestorEstructuras Gestor;
		public List<Personaje> TemporalJ1;
		public List<Personaje> TemporalJ2;

		public FormGeneradorMazos(GestorEstructuras gestor)
		{
			InitializeComponent();
			Gestor = gestor;
			TemporalJ1 = new List<Personaje>();
			TemporalJ2 = new List<Personaje>();

			// Recorremos con foreach las listas guardadas y agregamos con .Add()
			foreach (Personaje p1 in Gestor.MazoGuardadoJ1)
			{
				TemporalJ1.Add(p1.Copiar());
			}
			foreach (Personaje p2 in Gestor.MazoGuardadoJ2)
			{
				TemporalJ2.Add(p2.Copiar());
			}

			cmbElemento.SelectedIndex = 0;
			MostrarCatalogo();
			MostrarMazos();

			if (lstCatalogo.Items.Count > 0)
				lstCatalogo.SelectedIndex = 0;
		}

		private void MostrarCatalogo()
		{
			lstCatalogo.Items.Clear();
			for (int i = 0; i < Gestor.ListaPersonajes.Count; i++)
			{
				Personaje p = Gestor.ListaPersonajes[i];
				lstCatalogo.Items.Add("[" + p.Elemento + "] " + p.Nombre);
			}
			for (int j = 0; j < Gestor.ListaEscenarios.Count; j++)
			{
				CartaEscenario esc = Gestor.ListaEscenarios[j];
				lstCatalogo.Items.Add("[Escenario] " + esc.Nombre);
			}
		}

		private void MostrarMazos()
		{
			lstMazoJ1.Items.Clear();
			for (int i = 0; i < TemporalJ1.Count; i++)
				lstMazoJ1.Items.Add((i + 1) + ". " + TemporalJ1[i].Nombre);

			lstMazoJ2.Items.Clear();
			for (int j = 0; j < TemporalJ2.Count; j++)
				lstMazoJ2.Items.Add((j + 1) + ". " + TemporalJ2[j].Nombre);

			lblJ1.Text = "Mazo Jugador 1 (" + TemporalJ1.Count + "/5 cartas):";
			lblJ2.Text = "Mazo Jugador 2 (" + TemporalJ2.Count + "/5 cartas):";
		}

		private void LstCatalogoSelectedIndexChanged(object sender, EventArgs e)
		{
			int i = lstCatalogo.SelectedIndex;
			if (i < 0) return;

			if (i < Gestor.ListaPersonajes.Count)
			{
				Personaje p = Gestor.ListaPersonajes[i];
				int suma = p.HPMax + p.DEF + p.ATK;
				lblInfoCarta.Text = p.Nombre + "\r\nHP=" + p.HPMax + " DEF=" + p.DEF + " ATK=" + p.ATK + " (Suma=" + suma + ")\r\nEMP=" + p.EMP;
			}
			else
			{
				CartaEscenario esc = Gestor.ListaEscenarios[i - Gestor.ListaPersonajes.Count];
				lblInfoCarta.Text = "Escenario: " + esc.Nombre + "\r\nFacción: " + esc.Elemento + "\r\nUmbral EMP: " + esc.UmbralEMP;
			}
		}

		// Valida con int.TryParse y comprueba que HP + DEF + ATK sumen exactamente 100
		private void BtnCrearCartaClick(object sender, EventArgs e)
		{
			if (txtNombre.Text.Trim() == "")
			{
				MessageBox.Show("Escribe el nombre del personaje.");
				return;
			}

			int hp = 0;
			int def = 0;
			int atk = 0;
			int emp = 50;

			if (!int.TryParse(txtHP.Text, out hp) || !int.TryParse(txtDEF.Text, out def) ||
			    !int.TryParse(txtATK.Text, out atk) || !int.TryParse(txtEMP.Text, out emp))
			{
				MessageBox.Show("Ingresa solo números enteros válidos.");
				return;
			}

			int suma = hp + def + atk;
			if (suma != 100)
			{
				MessageBox.Show("Regla de balance: HP + DEF + ATK debe sumar 100 exactos.\nTu suma actual da: " + suma);
				return;
			}

			int nuevoId = Gestor.ListaPersonajes.Count + 1;
			Personaje nueva = new Personaje(nuevoId, txtNombre.Text.Trim(), cmbElemento.Text, hp, def, atk, emp);
			Gestor.ListaPersonajes.Add(nueva);
			MostrarCatalogo();
			MessageBox.Show("¡Carta creada y agregada a la Lista con .Add()!");
		}

		private void BtnAgregarJ1Click(object sender, EventArgs e)
		{
			int i = lstCatalogo.SelectedIndex;
			if (i < 0 || i >= Gestor.ListaPersonajes.Count) return;

			if (TemporalJ1.Count < 5)
			{
				TemporalJ1.Add(Gestor.ListaPersonajes[i].Copiar());
				MostrarMazos();
			}
			else
			{
				MessageBox.Show("El Mazo 1 ya tiene 5 cartas.");
			}
		}

		// Demuestra el uso de .Remove() si selecciono una carta, o .Clear() si no selecciono ninguna
		private void BtnLimpiarJ1Click(object sender, EventArgs e)
		{
			if (lstMazoJ1.SelectedIndex >= 0)
			{
				Gestor.QuitarPersonajeDeMazo(TemporalJ1, lstMazoJ1.SelectedIndex);
			}
			else
			{
				TemporalJ1.Clear();
			}
			MostrarMazos();
		}

		private void BtnAgregarJ2Click(object sender, EventArgs e)
		{
			int i = lstCatalogo.SelectedIndex;
			if (i < 0 || i >= Gestor.ListaPersonajes.Count) return;

			if (TemporalJ2.Count < 5)
			{
				TemporalJ2.Add(Gestor.ListaPersonajes[i].Copiar());
				MostrarMazos();
			}
			else
			{
				MessageBox.Show("El Mazo 2 ya tiene 5 cartas.");
			}
		}

		private void BtnLimpiarJ2Click(object sender, EventArgs e)
		{
			if (lstMazoJ2.SelectedIndex >= 0)
			{
				Gestor.QuitarPersonajeDeMazo(TemporalJ2, lstMazoJ2.SelectedIndex);
			}
			else
			{
				TemporalJ2.Clear();
			}
			MostrarMazos();
		}

		private void BtnGuardarClick(object sender, EventArgs e)
		{
			if (TemporalJ1.Count != 5 || TemporalJ2.Count != 5)
			{
				MessageBox.Show("Cada jugador debe seleccionar exactamente 5 personajes.");
				return;
			}

			Gestor.MazoGuardadoJ1.Clear();
			Gestor.MazoGuardadoJ2.Clear();

			foreach (Personaje p1 in TemporalJ1)
			{
				Gestor.MazoGuardadoJ1.Add(p1.Copiar());
			}
			foreach (Personaje p2 in TemporalJ2)
			{
				Gestor.MazoGuardadoJ2.Add(p2.Copiar());
			}

			Gestor.PrepararColasCombate(false);
			MessageBox.Show("¡Mazos de 5 personajes guardados correctamente!");
			this.Close();
		}
	}
}
