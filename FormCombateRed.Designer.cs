namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class FormCombateRed
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grpConexion;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label lblPuerto;
		private System.Windows.Forms.TextBox txtPuerto;
		private System.Windows.Forms.Button btnServidor;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Label lblEstadoRed;
		private System.Windows.Forms.GroupBox grpLocal;
		private System.Windows.Forms.Label lblDatosLocal;
		private System.Windows.Forms.ProgressBar pbVidaLocal;
		private System.Windows.Forms.Label lblColaLocal;
		private System.Windows.Forms.GroupBox grpRemoto;
		private System.Windows.Forms.Label lblDatosRemoto;
		private System.Windows.Forms.ProgressBar pbVidaRemoto;
		private System.Windows.Forms.Button btnAtacarRed;
		private System.Windows.Forms.Button btnEspecialRed;
		private System.Windows.Forms.Button btnRelevoRed;
		private System.Windows.Forms.Button btnPasarRed;
		private System.Windows.Forms.GroupBox grpLog;
		private System.Windows.Forms.ListBox lstRed;
		private System.Windows.Forms.TextBox txtChat;
		private System.Windows.Forms.Button btnEnviarChat;
		private System.Windows.Forms.Timer timerRed;

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.grpConexion = new System.Windows.Forms.GroupBox();
			this.lblEstadoRed = new System.Windows.Forms.Label();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnServidor = new System.Windows.Forms.Button();
			this.txtPuerto = new System.Windows.Forms.TextBox();
			this.lblPuerto = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblIP = new System.Windows.Forms.Label();
			this.grpLocal = new System.Windows.Forms.GroupBox();
			this.lblColaLocal = new System.Windows.Forms.Label();
			this.pbVidaLocal = new System.Windows.Forms.ProgressBar();
			this.lblDatosLocal = new System.Windows.Forms.Label();
			this.grpRemoto = new System.Windows.Forms.GroupBox();
			this.pbVidaRemoto = new System.Windows.Forms.ProgressBar();
			this.lblDatosRemoto = new System.Windows.Forms.Label();
			this.btnAtacarRed = new System.Windows.Forms.Button();
			this.btnEspecialRed = new System.Windows.Forms.Button();
			this.btnRelevoRed = new System.Windows.Forms.Button();
			this.btnPasarRed = new System.Windows.Forms.Button();
			this.grpLog = new System.Windows.Forms.GroupBox();
			this.btnEnviarChat = new System.Windows.Forms.Button();
			this.txtChat = new System.Windows.Forms.TextBox();
			this.lstRed = new System.Windows.Forms.ListBox();
			this.timerRed = new System.Windows.Forms.Timer(this.components);
			this.grpConexion.SuspendLayout();
			this.grpLocal.SuspendLayout();
			this.grpRemoto.SuspendLayout();
			this.grpLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpConexion
			// 
			this.grpConexion.Controls.Add(this.lblEstadoRed);
			this.grpConexion.Controls.Add(this.btnCliente);
			this.grpConexion.Controls.Add(this.btnServidor);
			this.grpConexion.Controls.Add(this.txtPuerto);
			this.grpConexion.Controls.Add(this.lblPuerto);
			this.grpConexion.Controls.Add(this.txtIP);
			this.grpConexion.Controls.Add(this.lblIP);
			this.grpConexion.Location = new System.Drawing.Point(12, 12);
			this.grpConexion.Name = "grpConexion";
			this.grpConexion.Size = new System.Drawing.Size(740, 82);
			this.grpConexion.TabIndex = 0;
			this.grpConexion.TabStop = false;
			this.grpConexion.Text = "Conexión TCP/IP (TcpListener / TcpClient)";
			// 
			// lblIP
			// 
			this.lblIP.Location = new System.Drawing.Point(12, 25);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(70, 18);
			this.lblIP.TabIndex = 0;
			this.lblIP.Text = "IP Servidor:";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(85, 22);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(110, 20);
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "127.0.0.1";
			// 
			// lblPuerto
			// 
			this.lblPuerto.Location = new System.Drawing.Point(205, 25);
			this.lblPuerto.Name = "lblPuerto";
			this.lblPuerto.Size = new System.Drawing.Size(48, 18);
			this.lblPuerto.TabIndex = 2;
			this.lblPuerto.Text = "Puerto:";
			// 
			// txtPuerto
			// 
			this.txtPuerto.Location = new System.Drawing.Point(255, 22);
			this.txtPuerto.Name = "txtPuerto";
			this.txtPuerto.Size = new System.Drawing.Size(55, 20);
			this.txtPuerto.TabIndex = 3;
			this.txtPuerto.Text = "5000";
			// 
			// btnServidor
			// 
			this.btnServidor.Location = new System.Drawing.Point(325, 18);
			this.btnServidor.Name = "btnServidor";
			this.btnServidor.Size = new System.Drawing.Size(195, 28);
			this.btnServidor.TabIndex = 4;
			this.btnServidor.Text = "1. Iniciar Servidor (Jugador 1)";
			this.btnServidor.UseVisualStyleBackColor = true;
			this.btnServidor.Click += new System.EventHandler(this.BtnServidorClick);
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(530, 18);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(195, 28);
			this.btnCliente.TabIndex = 5;
			this.btnCliente.Text = "2. Conectar Cliente (Jugador 2)";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// lblEstadoRed
			// 
			this.lblEstadoRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblEstadoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstadoRed.Location = new System.Drawing.Point(12, 52);
			this.lblEstadoRed.Name = "lblEstadoRed";
			this.lblEstadoRed.Size = new System.Drawing.Size(713, 22);
			this.lblEstadoRed.TabIndex = 6;
			this.lblEstadoRed.Text = "Estado: Desconectado (Usa 127.0.0.1 para probar en la misma PC con 2 ventanas, o la IP local en 2 PCs)";
			this.lblEstadoRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grpLocal
			// 
			this.grpLocal.Controls.Add(this.lblColaLocal);
			this.grpLocal.Controls.Add(this.pbVidaLocal);
			this.grpLocal.Controls.Add(this.lblDatosLocal);
			this.grpLocal.Location = new System.Drawing.Point(12, 102);
			this.grpLocal.Name = "grpLocal";
			this.grpLocal.Size = new System.Drawing.Size(360, 130);
			this.grpLocal.TabIndex = 1;
			this.grpLocal.TabStop = false;
			this.grpLocal.Text = "Mi Personaje en Arena";
			// 
			// lblDatosLocal
			// 
			this.lblDatosLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDatosLocal.Location = new System.Drawing.Point(12, 22);
			this.lblDatosLocal.Name = "lblDatosLocal";
			this.lblDatosLocal.Size = new System.Drawing.Size(335, 48);
			this.lblDatosLocal.TabIndex = 0;
			this.lblDatosLocal.Text = "Esperando inicio...";
			// 
			// pbVidaLocal
			// 
			this.pbVidaLocal.Location = new System.Drawing.Point(12, 78);
			this.pbVidaLocal.Name = "pbVidaLocal";
			this.pbVidaLocal.Size = new System.Drawing.Size(335, 18);
			this.pbVidaLocal.TabIndex = 1;
			this.pbVidaLocal.Value = 100;
			// 
			// lblColaLocal
			// 
			this.lblColaLocal.Location = new System.Drawing.Point(12, 102);
			this.lblColaLocal.Name = "lblColaLocal";
			this.lblColaLocal.Size = new System.Drawing.Size(335, 18);
			this.lblColaLocal.TabIndex = 2;
			this.lblColaLocal.Text = "Mis Relevos en Cola (Queue): 4";
			// 
			// grpRemoto
			// 
			this.grpRemoto.Controls.Add(this.pbVidaRemoto);
			this.grpRemoto.Controls.Add(this.lblDatosRemoto);
			this.grpRemoto.Location = new System.Drawing.Point(392, 102);
			this.grpRemoto.Name = "grpRemoto";
			this.grpRemoto.Size = new System.Drawing.Size(360, 130);
			this.grpRemoto.TabIndex = 2;
			this.grpRemoto.TabStop = false;
			this.grpRemoto.Text = "Personaje Rival (En Red)";
			// 
			// lblDatosRemoto
			// 
			this.lblDatosRemoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDatosRemoto.Location = new System.Drawing.Point(12, 22);
			this.lblDatosRemoto.Name = "lblDatosRemoto";
			this.lblDatosRemoto.Size = new System.Drawing.Size(335, 48);
			this.lblDatosRemoto.TabIndex = 0;
			this.lblDatosRemoto.Text = "Esperando rival...";
			// 
			// pbVidaRemoto
			// 
			this.pbVidaRemoto.Location = new System.Drawing.Point(12, 78);
			this.pbVidaRemoto.Name = "pbVidaRemoto";
			this.pbVidaRemoto.Size = new System.Drawing.Size(335, 18);
			this.pbVidaRemoto.TabIndex = 1;
			this.pbVidaRemoto.Value = 100;
			// 
			// btnAtacarRed
			// 
			this.btnAtacarRed.Enabled = false;
			this.btnAtacarRed.Location = new System.Drawing.Point(12, 242);
			this.btnAtacarRed.Name = "btnAtacarRed";
			this.btnAtacarRed.Size = new System.Drawing.Size(175, 34);
			this.btnAtacarRed.TabIndex = 3;
			this.btnAtacarRed.Text = "Atacar";
			this.btnAtacarRed.UseVisualStyleBackColor = true;
			this.btnAtacarRed.Click += new System.EventHandler(this.BtnAtacarRedClick);
			// 
			// btnEspecialRed
			// 
			this.btnEspecialRed.Enabled = false;
			this.btnEspecialRed.Location = new System.Drawing.Point(198, 242);
			this.btnEspecialRed.Name = "btnEspecialRed";
			this.btnEspecialRed.Size = new System.Drawing.Size(185, 34);
			this.btnEspecialRed.TabIndex = 4;
			this.btnEspecialRed.Text = "Habilidad Especial";
			this.btnEspecialRed.UseVisualStyleBackColor = true;
			this.btnEspecialRed.Click += new System.EventHandler(this.BtnEspecialRedClick);
			// 
			// btnRelevoRed
			// 
			this.btnRelevoRed.Enabled = false;
			this.btnRelevoRed.Location = new System.Drawing.Point(394, 242);
			this.btnRelevoRed.Name = "btnRelevoRed";
			this.btnRelevoRed.Size = new System.Drawing.Size(175, 34);
			this.btnRelevoRed.TabIndex = 5;
			this.btnRelevoRed.Text = "Relevo";
			this.btnRelevoRed.UseVisualStyleBackColor = true;
			this.btnRelevoRed.Click += new System.EventHandler(this.BtnRelevoRedClick);
			// 
			// btnPasarRed
			// 
			this.btnPasarRed.Enabled = false;
			this.btnPasarRed.Location = new System.Drawing.Point(580, 242);
			this.btnPasarRed.Name = "btnPasarRed";
			this.btnPasarRed.Size = new System.Drawing.Size(172, 34);
			this.btnPasarRed.TabIndex = 6;
			this.btnPasarRed.Text = "Pasar Turno";
			this.btnPasarRed.UseVisualStyleBackColor = true;
			this.btnPasarRed.Click += new System.EventHandler(this.BtnPasarRedClick);
			// 
			// grpLog
			// 
			this.grpLog.Controls.Add(this.btnEnviarChat);
			this.grpLog.Controls.Add(this.txtChat);
			this.grpLog.Controls.Add(this.lstRed);
			this.grpLog.Location = new System.Drawing.Point(12, 285);
			this.grpLog.Name = "grpLog";
			this.grpLog.Size = new System.Drawing.Size(740, 165);
			this.grpLog.TabIndex = 7;
			this.grpLog.TabStop = false;
			this.grpLog.Text = "Paquetes Recibidos / Registro de Red TCP/IP";
			// 
			// lstRed
			// 
			this.lstRed.FormattingEnabled = true;
			this.lstRed.Location = new System.Drawing.Point(12, 20);
			this.lstRed.Name = "lstRed";
			this.lstRed.Size = new System.Drawing.Size(715, 108);
			this.lstRed.TabIndex = 0;
			// 
			// txtChat
			// 
			this.txtChat.Location = new System.Drawing.Point(12, 135);
			this.txtChat.Name = "txtChat";
			this.txtChat.Size = new System.Drawing.Size(575, 20);
			this.txtChat.TabIndex = 1;
			// 
			// btnEnviarChat
			// 
			this.btnEnviarChat.Location = new System.Drawing.Point(595, 133);
			this.btnEnviarChat.Name = "btnEnviarChat";
			this.btnEnviarChat.Size = new System.Drawing.Size(132, 24);
			this.btnEnviarChat.TabIndex = 2;
			this.btnEnviarChat.Text = "Enviar Mensaje";
			this.btnEnviarChat.UseVisualStyleBackColor = true;
			this.btnEnviarChat.Click += new System.EventHandler(this.BtnEnviarChatClick);
			// 
			// timerRed
			// 
			this.timerRed.Interval = 400;
			this.timerRed.Tick += new System.EventHandler(this.TimerRedTick);
			// 
			// FormCombateRed
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 462);
			this.Controls.Add(this.grpLog);
			this.Controls.Add(this.btnPasarRed);
			this.Controls.Add(this.btnRelevoRed);
			this.Controls.Add(this.btnEspecialRed);
			this.Controls.Add(this.btnAtacarRed);
			this.Controls.Add(this.grpRemoto);
			this.Controls.Add(this.grpLocal);
			this.Controls.Add(this.grpConexion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormCombateRed";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Combate Multijugador en Red (TCP/IP)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCombateRedFormClosing);
			this.grpConexion.ResumeLayout(false);
			this.grpConexion.PerformLayout();
			this.grpLocal.ResumeLayout(false);
			this.grpRemoto.ResumeLayout(false);
			this.grpLog.ResumeLayout(false);
			this.grpLog.PerformLayout();
			this.ResumeLayout(false);
		}
	}
}
