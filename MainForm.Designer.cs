namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox grpMenu;
		private System.Windows.Forms.Button btnModoHistoria;
		private System.Windows.Forms.Button btnModo2Jugadores;
		private System.Windows.Forms.Button btnLore;
		private System.Windows.Forms.Button btnGeneradorMazos;
		private System.Windows.Forms.Button btnGestionMazos;
		private System.Windows.Forms.Button btnCombateRed;
		private System.Windows.Forms.Button btnLeerTxt;

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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.grpMenu = new System.Windows.Forms.GroupBox();
			this.btnLeerTxt = new System.Windows.Forms.Button();
			this.btnCombateRed = new System.Windows.Forms.Button();
			this.btnGestionMazos = new System.Windows.Forms.Button();
			this.btnGeneradorMazos = new System.Windows.Forms.Button();
			this.btnLore = new System.Windows.Forms.Button();
			this.btnModo2Jugadores = new System.Windows.Forms.Button();
			this.btnModoHistoria = new System.Windows.Forms.Button();
			this.grpMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(20, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(340, 26);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Sangre y Dogma: Arena Elemental";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grpMenu
			// 
			this.grpMenu.Controls.Add(this.btnLeerTxt);
			this.grpMenu.Controls.Add(this.btnCombateRed);
			this.grpMenu.Controls.Add(this.btnGestionMazos);
			this.grpMenu.Controls.Add(this.btnGeneradorMazos);
			this.grpMenu.Controls.Add(this.btnLore);
			this.grpMenu.Controls.Add(this.btnModo2Jugadores);
			this.grpMenu.Controls.Add(this.btnModoHistoria);
			this.grpMenu.Location = new System.Drawing.Point(25, 50);
			this.grpMenu.Name = "grpMenu";
			this.grpMenu.Size = new System.Drawing.Size(330, 330);
			this.grpMenu.TabIndex = 1;
			this.grpMenu.TabStop = false;
			this.grpMenu.Text = "Menú Principal";
			// 
			// btnModoHistoria
			// 
			this.btnModoHistoria.Location = new System.Drawing.Point(30, 25);
			this.btnModoHistoria.Name = "btnModoHistoria";
			this.btnModoHistoria.Size = new System.Drawing.Size(270, 34);
			this.btnModoHistoria.TabIndex = 0;
			this.btnModoHistoria.Text = "1 Jugador vs Sistema (Duendes)";
			this.btnModoHistoria.UseVisualStyleBackColor = true;
			this.btnModoHistoria.Click += new System.EventHandler(this.BtnModoHistoriaClick);
			// 
			// btnModo2Jugadores
			// 
			this.btnModo2Jugadores.Location = new System.Drawing.Point(30, 67);
			this.btnModo2Jugadores.Name = "btnModo2Jugadores";
			this.btnModo2Jugadores.Size = new System.Drawing.Size(270, 34);
			this.btnModo2Jugadores.TabIndex = 1;
			this.btnModo2Jugadores.Text = "2 Jugadores (Local)";
			this.btnModo2Jugadores.UseVisualStyleBackColor = true;
			this.btnModo2Jugadores.Click += new System.EventHandler(this.BtnModo2JugadoresClick);
			// 
			// btnLore
			// 
			this.btnLore.Location = new System.Drawing.Point(30, 109);
			this.btnLore.Name = "btnLore";
			this.btnLore.Size = new System.Drawing.Size(270, 34);
			this.btnLore.TabIndex = 2;
			this.btnLore.Text = "MOSTRAR HISTORIA";
			this.btnLore.UseVisualStyleBackColor = true;
			this.btnLore.Click += new System.EventHandler(this.BtnLoreClick);
			// 
			// btnGeneradorMazos
			// 
			this.btnGeneradorMazos.Location = new System.Drawing.Point(30, 151);
			this.btnGeneradorMazos.Name = "btnGeneradorMazos";
			this.btnGeneradorMazos.Size = new System.Drawing.Size(270, 34);
			this.btnGeneradorMazos.TabIndex = 3;
			this.btnGeneradorMazos.Text = "Armar Mazos y Crear Cartas";
			this.btnGeneradorMazos.UseVisualStyleBackColor = true;
			this.btnGeneradorMazos.Click += new System.EventHandler(this.BtnGeneradorMazosClick);
			// 
			// btnGestionMazos
			// 
			this.btnGestionMazos.Location = new System.Drawing.Point(30, 193);
			this.btnGestionMazos.Name = "btnGestionMazos";
			this.btnGestionMazos.Size = new System.Drawing.Size(270, 34);
			this.btnGestionMazos.TabIndex = 4;
			this.btnGestionMazos.Text = "Base de Datos (SQL)";
			this.btnGestionMazos.UseVisualStyleBackColor = true;
			this.btnGestionMazos.Click += new System.EventHandler(this.BtnGestionMazosClick);
			// 
			// btnCombateRed
			// 
			this.btnCombateRed.Location = new System.Drawing.Point(30, 235);
			this.btnCombateRed.Name = "btnCombateRed";
			this.btnCombateRed.Size = new System.Drawing.Size(270, 34);
			this.btnCombateRed.TabIndex = 5;
			this.btnCombateRed.Text = "Combate en Red (LAN)";
			this.btnCombateRed.UseVisualStyleBackColor = true;
			this.btnCombateRed.Click += new System.EventHandler(this.BtnCombateRedClick);
			// 
			// btnLeerTxt
			// 
			this.btnLeerTxt.Location = new System.Drawing.Point(30, 277);
			this.btnLeerTxt.Name = "btnLeerTxt";
			this.btnLeerTxt.Size = new System.Drawing.Size(270, 34);
			this.btnLeerTxt.TabIndex = 6;
			this.btnLeerTxt.Text = "Leer Puntajes (.TXT)";
			this.btnLeerTxt.UseVisualStyleBackColor = true;
			this.btnLeerTxt.Click += new System.EventHandler(this.BtnLeerTxtClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 395);
			this.Controls.Add(this.grpMenu);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menú Principal - Sangre y Dogma";
			this.grpMenu.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
