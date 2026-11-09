namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class PantallaInicioForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox picPortada;
		private System.Windows.Forms.Panel pnlInferior;
		private System.Windows.Forms.Button btnIniciarJuego;
		private System.Windows.Forms.Button btnSalir;

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
			this.picPortada = new System.Windows.Forms.PictureBox();
			this.pnlInferior = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnIniciarJuego = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
			this.pnlInferior.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlInferior
			// 
			this.pnlInferior.Controls.Add(this.btnSalir);
			this.pnlInferior.Controls.Add(this.btnIniciarJuego);
			this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlInferior.Location = new System.Drawing.Point(0, 430);
			this.pnlInferior.Name = "pnlInferior";
			this.pnlInferior.Size = new System.Drawing.Size(760, 55);
			this.pnlInferior.TabIndex = 0;
			// 
			// btnIniciarJuego
			// 
			this.btnIniciarJuego.Location = new System.Drawing.Point(180, 12);
			this.btnIniciarJuego.Name = "btnIniciarJuego";
			this.btnIniciarJuego.Size = new System.Drawing.Size(190, 32);
			this.btnIniciarJuego.TabIndex = 0;
			this.btnIniciarJuego.Text = "Iniciar Juego";
			this.btnIniciarJuego.UseVisualStyleBackColor = true;
			this.btnIniciarJuego.Click += new System.EventHandler(this.BtnIniciarJuegoClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(390, 12);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(190, 32);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// picPortada
			// 
			this.picPortada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPortada.Location = new System.Drawing.Point(0, 0);
			this.picPortada.Name = "picPortada";
			this.picPortada.Size = new System.Drawing.Size(760, 430);
			this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPortada.TabIndex = 1;
			this.picPortada.TabStop = false;
			// 
			// PantallaInicioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 485);
			this.Controls.Add(this.picPortada);
			this.Controls.Add(this.pnlInferior);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PantallaInicioForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sangre y Dogma: Arena Elemental";
			((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
			this.pnlInferior.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
