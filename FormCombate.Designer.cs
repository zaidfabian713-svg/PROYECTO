/*
 * Created by SharpDevelop.
 * User: WINDOWS
 */
namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class FormCombate
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblInfoTurno;
		private System.Windows.Forms.Label lblReloj;
		private System.Windows.Forms.Label lblEscenario;
		private System.Windows.Forms.ComboBox cmbEscenario;
		private System.Windows.Forms.Button btnAplicarEscenario;
		private System.Windows.Forms.Button btnTerremoto;
		private System.Windows.Forms.GroupBox grpJugador1;
		private System.Windows.Forms.Label lblDatosJ1;
		private System.Windows.Forms.Label lblVidaJ1;
		private System.Windows.Forms.ProgressBar pbVidaJ1;
		private System.Windows.Forms.Label lblEspecialJ1;
		private System.Windows.Forms.ProgressBar pbEspecialJ1;
		private System.Windows.Forms.Label lblColaJ1;
		private System.Windows.Forms.GroupBox grpJugador2;
		private System.Windows.Forms.Label lblDatosJ2;
		private System.Windows.Forms.Label lblVidaJ2;
		private System.Windows.Forms.ProgressBar pbVidaJ2;
		private System.Windows.Forms.Label lblEspecialJ2;
		private System.Windows.Forms.ProgressBar pbEspecialJ2;
		private System.Windows.Forms.Label lblColaJ2;
		private System.Windows.Forms.Button btnAtacar;
		private System.Windows.Forms.Button btnHabilidadEspecial;
		private System.Windows.Forms.Button btnRelevo;
		private System.Windows.Forms.Button btnPasarTurno;
		private System.Windows.Forms.Button btnMostrarHistoria;
		private System.Windows.Forms.Label lblBitacora;
		private System.Windows.Forms.ListBox lstBitacora;
		private System.Windows.Forms.Timer timerTurno;

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
			this.lblInfoTurno = new System.Windows.Forms.Label();
			this.lblReloj = new System.Windows.Forms.Label();
			this.lblEscenario = new System.Windows.Forms.Label();
			this.cmbEscenario = new System.Windows.Forms.ComboBox();
			this.btnAplicarEscenario = new System.Windows.Forms.Button();
			this.btnTerremoto = new System.Windows.Forms.Button();
			this.grpJugador1 = new System.Windows.Forms.GroupBox();
			this.lblColaJ1 = new System.Windows.Forms.Label();
			this.pbEspecialJ1 = new System.Windows.Forms.ProgressBar();
			this.lblEspecialJ1 = new System.Windows.Forms.Label();
			this.pbVidaJ1 = new System.Windows.Forms.ProgressBar();
			this.lblVidaJ1 = new System.Windows.Forms.Label();
			this.lblDatosJ1 = new System.Windows.Forms.Label();
			this.grpJugador2 = new System.Windows.Forms.GroupBox();
			this.lblColaJ2 = new System.Windows.Forms.Label();
			this.pbEspecialJ2 = new System.Windows.Forms.ProgressBar();
			this.lblEspecialJ2 = new System.Windows.Forms.Label();
			this.pbVidaJ2 = new System.Windows.Forms.ProgressBar();
			this.lblVidaJ2 = new System.Windows.Forms.Label();
			this.lblDatosJ2 = new System.Windows.Forms.Label();
			this.btnAtacar = new System.Windows.Forms.Button();
			this.btnHabilidadEspecial = new System.Windows.Forms.Button();
			this.btnRelevo = new System.Windows.Forms.Button();
			this.btnPasarTurno = new System.Windows.Forms.Button();
			this.btnMostrarHistoria = new System.Windows.Forms.Button();
			this.lblBitacora = new System.Windows.Forms.Label();
			this.lstBitacora = new System.Windows.Forms.ListBox();
			this.timerTurno = new System.Windows.Forms.Timer(this.components);
			this.grpJugador1.SuspendLayout();
			this.grpJugador2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblInfoTurno
			// 
			this.lblInfoTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblInfoTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoTurno.Location = new System.Drawing.Point(12, 12);
			this.lblInfoTurno.Name = "lblInfoTurno";
			this.lblInfoTurno.Size = new System.Drawing.Size(580, 26);
			this.lblInfoTurno.TabIndex = 0;
			this.lblInfoTurno.Text = "Ronda 1 | Turno: Jugador 1";
			this.lblInfoTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblReloj
			// 
			this.lblReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReloj.Location = new System.Drawing.Point(600, 12);
			this.lblReloj.Name = "lblReloj";
			this.lblReloj.Size = new System.Drawing.Size(210, 26);
			this.lblReloj.TabIndex = 1;
			this.lblReloj.Text = "Tiempo: 15 seg";
			this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEscenario
			// 
			this.lblEscenario.Location = new System.Drawing.Point(12, 50);
			this.lblEscenario.Name = "lblEscenario";
			this.lblEscenario.Size = new System.Drawing.Size(120, 18);
			this.lblEscenario.TabIndex = 2;
			this.lblEscenario.Text = "Carta de Escenario:";
			// 
			// cmbEscenario
			// 
			this.cmbEscenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEscenario.FormattingEnabled = true;
			this.cmbEscenario.Location = new System.Drawing.Point(135, 47);
			this.cmbEscenario.Name = "cmbEscenario";
			this.cmbEscenario.Size = new System.Drawing.Size(280, 21);
			this.cmbEscenario.TabIndex = 3;
			// 
			// btnAplicarEscenario
			// 
			this.btnAplicarEscenario.Location = new System.Drawing.Point(425, 45);
			this.btnAplicarEscenario.Name = "btnAplicarEscenario";
			this.btnAplicarEscenario.Size = new System.Drawing.Size(185, 25);
			this.btnAplicarEscenario.TabIndex = 4;
			this.btnAplicarEscenario.Text = "Aplicar Escenario";
			this.btnAplicarEscenario.UseVisualStyleBackColor = true;
			this.btnAplicarEscenario.Click += new System.EventHandler(this.BtnAplicarEscenarioClick);
			// 
			// btnTerremoto
			// 
			this.btnTerremoto.Location = new System.Drawing.Point(620, 45);
			this.btnTerremoto.Name = "btnTerremoto";
			this.btnTerremoto.Size = new System.Drawing.Size(190, 25);
			this.btnTerremoto.TabIndex = 5;
			this.btnTerremoto.Text = "Terremoto";
			this.btnTerremoto.UseVisualStyleBackColor = true;
			this.btnTerremoto.Click += new System.EventHandler(this.BtnTerremotoClick);
			// 
			// grpJugador1
			// 
			this.grpJugador1.Controls.Add(this.lblColaJ1);
			this.grpJugador1.Controls.Add(this.pbEspecialJ1);
			this.grpJugador1.Controls.Add(this.lblEspecialJ1);
			this.grpJugador1.Controls.Add(this.pbVidaJ1);
			this.grpJugador1.Controls.Add(this.lblVidaJ1);
			this.grpJugador1.Controls.Add(this.lblDatosJ1);
			this.grpJugador1.Location = new System.Drawing.Point(12, 80);
			this.grpJugador1.Name = "grpJugador1";
			this.grpJugador1.Size = new System.Drawing.Size(390, 195);
			this.grpJugador1.TabIndex = 6;
			this.grpJugador1.TabStop = false;
			this.grpJugador1.Text = "Jugador 1";
			// 
			// lblDatosJ1
			// 
			this.lblDatosJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDatosJ1.Location = new System.Drawing.Point(12, 22);
			this.lblDatosJ1.Name = "lblDatosJ1";
			this.lblDatosJ1.Size = new System.Drawing.Size(365, 50);
			this.lblDatosJ1.TabIndex = 0;
			this.lblDatosJ1.Text = "Datos Jugador 1";
			// 
			// lblVidaJ1
			// 
			this.lblVidaJ1.Location = new System.Drawing.Point(12, 78);
			this.lblVidaJ1.Name = "lblVidaJ1";
			this.lblVidaJ1.Size = new System.Drawing.Size(365, 16);
			this.lblVidaJ1.TabIndex = 1;
			this.lblVidaJ1.Text = "Vida (HP):";
			// 
			// pbVidaJ1
			// 
			this.pbVidaJ1.Location = new System.Drawing.Point(12, 96);
			this.pbVidaJ1.Name = "pbVidaJ1";
			this.pbVidaJ1.Size = new System.Drawing.Size(365, 18);
			this.pbVidaJ1.TabIndex = 2;
			this.pbVidaJ1.Value = 100;
			// 
			// lblEspecialJ1
			// 
			this.lblEspecialJ1.Location = new System.Drawing.Point(12, 120);
			this.lblEspecialJ1.Name = "lblEspecialJ1";
			this.lblEspecialJ1.Size = new System.Drawing.Size(365, 16);
			this.lblEspecialJ1.TabIndex = 3;
			this.lblEspecialJ1.Text = "Habilidad Especial:";
			// 
			// pbEspecialJ1
			// 
			this.pbEspecialJ1.Location = new System.Drawing.Point(12, 138);
			this.pbEspecialJ1.Maximum = 2;
			this.pbEspecialJ1.Name = "pbEspecialJ1";
			this.pbEspecialJ1.Size = new System.Drawing.Size(365, 16);
			this.pbEspecialJ1.TabIndex = 4;
			// 
			// lblColaJ1
			// 
			this.lblColaJ1.Location = new System.Drawing.Point(12, 162);
			this.lblColaJ1.Name = "lblColaJ1";
			this.lblColaJ1.Size = new System.Drawing.Size(365, 18);
			this.lblColaJ1.TabIndex = 5;
			this.lblColaJ1.Text = "Relevos disponibles: 4";
			// 
			// grpJugador2
			// 
			this.grpJugador2.Controls.Add(this.lblColaJ2);
			this.grpJugador2.Controls.Add(this.pbEspecialJ2);
			this.grpJugador2.Controls.Add(this.lblEspecialJ2);
			this.grpJugador2.Controls.Add(this.pbVidaJ2);
			this.grpJugador2.Controls.Add(this.lblVidaJ2);
			this.grpJugador2.Controls.Add(this.lblDatosJ2);
			this.grpJugador2.Location = new System.Drawing.Point(420, 80);
			this.grpJugador2.Name = "grpJugador2";
			this.grpJugador2.Size = new System.Drawing.Size(390, 195);
			this.grpJugador2.TabIndex = 7;
			this.grpJugador2.TabStop = false;
			this.grpJugador2.Text = "Jugador 2";
			// 
			// lblDatosJ2
			// 
			this.lblDatosJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDatosJ2.Location = new System.Drawing.Point(12, 22);
			this.lblDatosJ2.Name = "lblDatosJ2";
			this.lblDatosJ2.Size = new System.Drawing.Size(365, 50);
			this.lblDatosJ2.TabIndex = 0;
			this.lblDatosJ2.Text = "Datos Jugador 2";
			// 
			// lblVidaJ2
			// 
			this.lblVidaJ2.Location = new System.Drawing.Point(12, 78);
			this.lblVidaJ2.Name = "lblVidaJ2";
			this.lblVidaJ2.Size = new System.Drawing.Size(365, 16);
			this.lblVidaJ2.TabIndex = 1;
			this.lblVidaJ2.Text = "Vida (HP):";
			// 
			// pbVidaJ2
			// 
			this.pbVidaJ2.Location = new System.Drawing.Point(12, 96);
			this.pbVidaJ2.Name = "pbVidaJ2";
			this.pbVidaJ2.Size = new System.Drawing.Size(365, 18);
			this.pbVidaJ2.TabIndex = 2;
			this.pbVidaJ2.Value = 100;
			// 
			// lblEspecialJ2
			// 
			this.lblEspecialJ2.Location = new System.Drawing.Point(12, 120);
			this.lblEspecialJ2.Name = "lblEspecialJ2";
			this.lblEspecialJ2.Size = new System.Drawing.Size(365, 16);
			this.lblEspecialJ2.TabIndex = 3;
			this.lblEspecialJ2.Text = "Habilidad Especial:";
			// 
			// pbEspecialJ2
			// 
			this.pbEspecialJ2.Location = new System.Drawing.Point(12, 138);
			this.pbEspecialJ2.Maximum = 2;
			this.pbEspecialJ2.Name = "pbEspecialJ2";
			this.pbEspecialJ2.Size = new System.Drawing.Size(365, 16);
			this.pbEspecialJ2.TabIndex = 4;
			// 
			// lblColaJ2
			// 
			this.lblColaJ2.Location = new System.Drawing.Point(12, 162);
			this.lblColaJ2.Name = "lblColaJ2";
			this.lblColaJ2.Size = new System.Drawing.Size(365, 18);
			this.lblColaJ2.TabIndex = 5;
			this.lblColaJ2.Text = "Relevos disponibles: 4";
			// 
			// btnAtacar
			// 
			this.btnAtacar.Location = new System.Drawing.Point(12, 285);
			this.btnAtacar.Name = "btnAtacar";
			this.btnAtacar.Size = new System.Drawing.Size(190, 32);
			this.btnAtacar.TabIndex = 8;
			this.btnAtacar.Text = "Atacar";
			this.btnAtacar.UseVisualStyleBackColor = true;
			this.btnAtacar.Click += new System.EventHandler(this.BtnAtacarClick);
			// 
			// btnHabilidadEspecial
			// 
			this.btnHabilidadEspecial.Location = new System.Drawing.Point(212, 285);
			this.btnHabilidadEspecial.Name = "btnHabilidadEspecial";
			this.btnHabilidadEspecial.Size = new System.Drawing.Size(210, 32);
			this.btnHabilidadEspecial.TabIndex = 9;
			this.btnHabilidadEspecial.Text = "Habilidad Especial";
			this.btnHabilidadEspecial.UseVisualStyleBackColor = true;
			this.btnHabilidadEspecial.Click += new System.EventHandler(this.BtnHabilidadEspecialClick);
			// 
			// btnRelevo
			// 
			this.btnRelevo.Location = new System.Drawing.Point(432, 285);
			this.btnRelevo.Name = "btnRelevo";
			this.btnRelevo.Size = new System.Drawing.Size(185, 32);
			this.btnRelevo.TabIndex = 10;
			this.btnRelevo.Text = "Relevo";
			this.btnRelevo.UseVisualStyleBackColor = true;
			this.btnRelevo.Click += new System.EventHandler(this.BtnRelevoClick);
			// 
			// btnPasarTurno
			// 
			this.btnPasarTurno.Location = new System.Drawing.Point(625, 285);
			this.btnPasarTurno.Name = "btnPasarTurno";
			this.btnPasarTurno.Size = new System.Drawing.Size(185, 32);
			this.btnPasarTurno.TabIndex = 11;
			this.btnPasarTurno.Text = "Pasar Turno";
			this.btnPasarTurno.UseVisualStyleBackColor = true;
			this.btnPasarTurno.Click += new System.EventHandler(this.BtnPasarTurnoClick);
			// 
			// btnMostrarHistoria
			// 
			this.btnMostrarHistoria.Location = new System.Drawing.Point(625, 320);
			this.btnMostrarHistoria.Name = "btnMostrarHistoria";
			this.btnMostrarHistoria.Size = new System.Drawing.Size(185, 22);
			this.btnMostrarHistoria.TabIndex = 14;
			this.btnMostrarHistoria.Text = "MOSTRAR HISTORIA";
			this.btnMostrarHistoria.UseVisualStyleBackColor = true;
			this.btnMostrarHistoria.Click += new System.EventHandler(this.BtnMostrarHistoriaClick);
			// 
			// lblBitacora
			// 
			this.lblBitacora.Location = new System.Drawing.Point(12, 325);
			this.lblBitacora.Name = "lblBitacora";
			this.lblBitacora.Size = new System.Drawing.Size(400, 16);
			this.lblBitacora.TabIndex = 12;
			this.lblBitacora.Text = "Registro de Combate:";
			// 
			// lstBitacora
			// 
			this.lstBitacora.FormattingEnabled = true;
			this.lstBitacora.Location = new System.Drawing.Point(12, 344);
			this.lstBitacora.Name = "lstBitacora";
			this.lstBitacora.Size = new System.Drawing.Size(798, 108);
			this.lstBitacora.TabIndex = 13;
			// 
			// timerTurno
			// 
			this.timerTurno.Interval = 1000;
			this.timerTurno.Tick += new System.EventHandler(this.TimerTurnoTick);
			// 
			// FormCombate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 465);
			this.Controls.Add(this.btnMostrarHistoria);
			this.Controls.Add(this.lstBitacora);
			this.Controls.Add(this.lblBitacora);
			this.Controls.Add(this.btnPasarTurno);
			this.Controls.Add(this.btnRelevo);
			this.Controls.Add(this.btnHabilidadEspecial);
			this.Controls.Add(this.btnAtacar);
			this.Controls.Add(this.grpJugador2);
			this.Controls.Add(this.grpJugador1);
			this.Controls.Add(this.btnTerremoto);
			this.Controls.Add(this.btnAplicarEscenario);
			this.Controls.Add(this.cmbEscenario);
			this.Controls.Add(this.lblEscenario);
			this.Controls.Add(this.lblReloj);
			this.Controls.Add(this.lblInfoTurno);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormCombate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sangre y Dogma: Arena Elemental";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCombateFormClosing);
			this.grpJugador1.ResumeLayout(false);
			this.grpJugador2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
