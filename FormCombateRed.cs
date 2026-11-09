using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Ventana para pelear en red local usando TcpListener y TcpClient con textos separados por comas
	public partial class FormCombateRed : Form
	{
		public GestorEstructuras Gestor;
		public TcpListener Servidor;
		public TcpClient Cliente;
		public NetworkStream FlujoRed;

		public Queue<Personaje> MiCola;
		public Personaje MiCarta;
		public Personaje CartaRemota;

		public bool SoyServidor = false;
		public bool Conectado = false;
		public bool EsMiTurno = false;
		public int RondaRed = 1;

		public FormCombateRed(GestorEstructuras gestor)
		{
			InitializeComponent();
			Gestor = gestor;
			MiCola = new Queue<Personaje>();

			for (int i = 0; i < Gestor.MazoGuardadoJ1.Count; i++)
			{
				MiCola.Enqueue(Gestor.MazoGuardadoJ1[i].Copiar());
			}
			MiCarta = MiCola.Dequeue();
			CartaRemota = new Personaje(0, "Rival", "Fuego", 45, 25, 30, 50);

			ActualizarVista();
		}

		private void BtnServidorClick(object sender, EventArgs e)
		{
			try
			{
				int puerto = Convert.ToInt32(txtPuerto.Text);
				Servidor = new TcpListener(IPAddress.Any, puerto);
				Servidor.Start();

				SoyServidor = true;
				btnServidor.Enabled = false;
				btnCliente.Enabled = false;
				lblEstadoRed.Text = "Servidor esperando en puerto " + puerto + "...";
				timerRed.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al iniciar servidor: " + ex.Message);
			}
		}

		private void BtnClienteClick(object sender, EventArgs e)
		{
			try
			{
				int puerto = Convert.ToInt32(txtPuerto.Text);
				Cliente = new TcpClient(txtIP.Text.Trim(), puerto);
				FlujoRed = Cliente.GetStream();

				SoyServidor = false;
				Conectado = true;
				EsMiTurno = false;
				btnServidor.Enabled = false;
				btnCliente.Enabled = false;

				lblEstadoRed.Text = "¡Conectado al Servidor! Esperando turno del Jugador 1...";
				EnviarTextoPorRed("CARTA," + MiCarta.Nombre + "," + MiCarta.Elemento + "," + MiCarta.HP + "," + MiCarta.HPMax + "," + MiCarta.ATK + "," + MiCarta.DEF);
				ActualizarVista();
				timerRed.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al conectar cliente: " + ex.Message);
			}
		}

		private void EnviarTextoPorRed(string mensajeConComas)
		{
			if (FlujoRed == null) return;
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(mensajeConComas + "\n");
				FlujoRed.Write(bytes, 0, bytes.Length);
			}
			catch
			{
				lblEstadoRed.Text = "Se cerró la conexión.";
			}
		}

		private void TimerRedTick(object sender, EventArgs e)
		{
			if (SoyServidor && !Conectado && Servidor != null)
			{
				if (Servidor.Pending())
				{
					Cliente = Servidor.AcceptTcpClient();
					FlujoRed = Cliente.GetStream();
					Conectado = true;
					EsMiTurno = true;

					lblEstadoRed.Text = "¡Cliente conectado! Es tu turno (Jugador 1).";
					EnviarTextoPorRed("CARTA," + MiCarta.Nombre + "," + MiCarta.Elemento + "," + MiCarta.HP + "," + MiCarta.HPMax + "," + MiCarta.ATK + "," + MiCarta.DEF);
					ActualizarVista();
				}
				return;
			}

			if (Conectado && FlujoRed != null && FlujoRed.DataAvailable)
			{
				byte[] buffer = new byte[1024];
				int leidos = FlujoRed.Read(buffer, 0, buffer.Length);
				string recibido = Encoding.UTF8.GetString(buffer, 0, leidos);

				string[] lineas = recibido.Split('\n');
				for (int i = 0; i < lineas.Length; i++)
				{
					string lin = lineas[i].Trim();
					if (lin != "") ProcesarMensajeConComas(lin);
				}
			}
		}

		private void ProcesarMensajeConComas(string paquete)
		{
			string[] datos = paquete.Split(',');
			string tipo = datos[0];

			if (tipo == "CARTA" && datos.Length >= 7)
			{
				CartaRemota.Nombre = datos[1];
				CartaRemota.Elemento = datos[2];
				CartaRemota.HP = Convert.ToInt32(datos[3]);
				CartaRemota.HPMax = Convert.ToInt32(datos[4]);
				CartaRemota.ATK = Convert.ToInt32(datos[5]);
				CartaRemota.DEF = Convert.ToInt32(datos[6]);
				ActualizarVista();
			}
			else if (tipo == "ATAQUE" || tipo == "ESPECIAL")
			{
				int dano = Convert.ToInt32(datos[1]);
				string resumen = datos[2];

				MiCarta.HP = MiCarta.HP - dano;
				if (MiCarta.HP < 0) MiCarta.HP = 0;
				AgregarLog("[RED] " + resumen);

				if (MiCarta.HP <= 0)
				{
					if (MiCola.Count > 0)
					{
						MiCarta = MiCola.Dequeue();
						AgregarLog("Cae tu personaje. Entra relevo: " + MiCarta.Nombre);
					}
					else
					{
						EnviarTextoPorRed("VICTORIA,Derrotaste las 5 cartas rivales");
						Conectado = false;
						ActualizarVista();
						MessageBox.Show("Fin del combate en red: Has perdido.");
						return;
					}
				}

				EnviarTextoPorRed("CARTA," + MiCarta.Nombre + "," + MiCarta.Elemento + "," + MiCarta.HP + "," + MiCarta.HPMax + "," + MiCarta.ATK + "," + MiCarta.DEF);
				ActivarMiTurno();
			}
			else if (tipo == "TURNO")
			{
				AgregarLog("[RED] " + datos[1]);
				ActivarMiTurno();
			}
			else if (tipo == "VICTORIA")
			{
				Conectado = false;
				EsMiTurno = false;
				ActualizarVista();
				MessageBox.Show("¡GANASTE EN RED!\n" + datos[1]);
			}
			else if (tipo == "CHAT")
			{
				AgregarLog("[Rival]: " + datos[1]);
			}
		}

		private void ActivarMiTurno()
		{
			EsMiTurno = true;
			RondaRed = RondaRed + 1;
			MiCarta.ENER = MiCarta.ENER + 1;
			if (MiCarta.ESP < 2) MiCarta.ESP = MiCarta.ESP + 1;

			lblEstadoRed.Text = "¡ES TU TURNO! (Ronda " + RondaRed + ")";
			ActualizarVista();
		}

		private void BtnAtacarRedClick(object sender, EventArgs e)
		{
			if (!Conectado || !EsMiTurno) return;

			int dano = MiCarta.Atacar(CartaRemota);
			string log = MiCarta.Nombre + " ataca y quita " + dano + " HP";
			AgregarLog(log);

			EnviarTextoPorRed("ATAQUE," + dano + "," + log);
			TerminarMiTurno();
		}

		private void BtnEspecialRedClick(object sender, EventArgs e)
		{
			if (!Conectado || !EsMiTurno) return;
			if (RondaRed == 1 || MiCarta.ESP < 2 || MiCarta.ENER < 2) return;

			MiCarta.ENER = MiCarta.ENER - 2;
			MiCarta.ESP = 0;

			int vidaAntes = CartaRemota.HP;
			string log = MiCarta.EjecutarHabilidadEspecial(CartaRemota).Replace(",", ";");
			int dano = vidaAntes - CartaRemota.HP;
			if (dano < 0) dano = 0;

			AgregarLog(log);
			EnviarTextoPorRed("ESPECIAL," + dano + "," + log);
			EnviarTextoPorRed("CARTA," + MiCarta.Nombre + "," + MiCarta.Elemento + "," + MiCarta.HP + "," + MiCarta.HPMax + "," + MiCarta.ATK + "," + MiCarta.DEF);
			TerminarMiTurno();
		}

		private void BtnRelevoRedClick(object sender, EventArgs e)
		{
			if (!Conectado || !EsMiTurno || MiCola.Count == 0) return;

			MiCola.Enqueue(MiCarta);
			MiCarta = MiCola.Dequeue();

			string log = "Relevo en red: entra " + MiCarta.Nombre;
			AgregarLog(log);

			EnviarTextoPorRed("CARTA," + MiCarta.Nombre + "," + MiCarta.Elemento + "," + MiCarta.HP + "," + MiCarta.HPMax + "," + MiCarta.ATK + "," + MiCarta.DEF);
			EnviarTextoPorRed("TURNO," + log);
			TerminarMiTurno();
		}

		private void BtnPasarRedClick(object sender, EventArgs e)
		{
			if (!Conectado || !EsMiTurno) return;
			EnviarTextoPorRed("TURNO,El rival paso su turno");
			TerminarMiTurno();
		}

		private void TerminarMiTurno()
		{
			EsMiTurno = false;
			lblEstadoRed.Text = "Turno enviado por red. Esperando al rival...";
			ActualizarVista();
		}

		private void BtnEnviarChatClick(object sender, EventArgs e)
		{
			if (!Conectado || txtChat.Text.Trim() == "") return;

			string msg = txtChat.Text.Trim().Replace(",", " ");
			EnviarTextoPorRed("CHAT," + msg);
			AgregarLog("[Yo]: " + msg);
			txtChat.Text = "";
		}

		private void AgregarLog(string texto)
		{
			Gestor.PilaHistorial.Push(texto);
			lstRed.Items.Insert(0, texto);
		}

		private void ActualizarVista()
		{
			lblDatosLocal.Text = MiCarta.Nombre + " (" + MiCarta.Elemento + ")\n" +
				"HP:" + MiCarta.HP + "/" + MiCarta.HPMax + " | ATK:" + MiCarta.ATK +
				" | DEF:" + MiCarta.DEF + " | ENER:" + MiCarta.ENER + " | ESP:" + MiCarta.ESP + "/2";
			pbVidaLocal.Maximum = MiCarta.HPMax;
			pbVidaLocal.Value = MiCarta.HP;
			lblColaLocal.Text = "Mis Relevos en Cola (Queue): " + MiCola.Count;

			lblDatosRemoto.Text = CartaRemota.Nombre + " (" + CartaRemota.Elemento + ")\n" +
				"HP:" + CartaRemota.HP + "/" + CartaRemota.HPMax + " | ATK:" + CartaRemota.ATK + " | DEF:" + CartaRemota.DEF;
			pbVidaRemoto.Maximum = CartaRemota.HPMax;
			if (CartaRemota.HP <= pbVidaRemoto.Maximum)
				pbVidaRemoto.Value = CartaRemota.HP;

			btnAtacarRed.Enabled = (Conectado && EsMiTurno);
			btnRelevoRed.Enabled = (Conectado && EsMiTurno && MiCola.Count > 0);
			btnPasarRed.Enabled = (Conectado && EsMiTurno);

			if (Conectado && EsMiTurno && RondaRed > 1 && MiCarta.ESP >= 2 && MiCarta.ENER >= 2)
				btnEspecialRed.Enabled = true;
			else
				btnEspecialRed.Enabled = false;
		}

		private void FormCombateRedFormClosing(object sender, FormClosingEventArgs e)
		{
			timerRed.Stop();
			try
			{
				if (FlujoRed != null) FlujoRed.Close();
				if (Cliente != null) Cliente.Close();
				if (Servidor != null) Servidor.Stop();
			}
			catch
			{
			}
		}
	}
}
