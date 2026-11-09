/*
 * Created by SharpDevelop.
 * User: WINDOWS
 * Date: 7/11/2026
 */
namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class FormLore
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grpLista;
		private System.Windows.Forms.ListBox lstPersonajes;
		private System.Windows.Forms.GroupBox grpHistoria;
		private System.Windows.Forms.TextBox txtHistoria;
		private System.Windows.Forms.Button btnMostrarHistoria;
		private System.Windows.Forms.Button btnCerrar;

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
			this.grpLista = new System.Windows.Forms.GroupBox();
			this.lstPersonajes = new System.Windows.Forms.ListBox();
			this.grpHistoria = new System.Windows.Forms.GroupBox();
			this.txtHistoria = new System.Windows.Forms.TextBox();
			this.btnMostrarHistoria = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.grpLista.SuspendLayout();
			this.grpHistoria.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpLista
			// 
			this.grpLista.Controls.Add(this.lstPersonajes);
			this.grpLista.Location = new System.Drawing.Point(12, 12);
			this.grpLista.Name = "grpLista";
			this.grpLista.Size = new System.Drawing.Size(250, 310);
			this.grpLista.TabIndex = 0;
			this.grpLista.TabStop = false;
			this.grpLista.Text = "Personajes del Catálogo";
			// 
			// lstPersonajes
			// 
			this.lstPersonajes.FormattingEnabled = true;
			this.lstPersonajes.Location = new System.Drawing.Point(12, 22);
			this.lstPersonajes.Name = "lstPersonajes";
			this.lstPersonajes.Size = new System.Drawing.Size(226, 277);
			this.lstPersonajes.TabIndex = 0;
			this.lstPersonajes.SelectedIndexChanged += new System.EventHandler(this.LstPersonajesSelectedIndexChanged);
			// 
			// grpHistoria
			// 
			this.grpHistoria.Controls.Add(this.txtHistoria);
			this.grpHistoria.Location = new System.Drawing.Point(272, 12);
			this.grpHistoria.Name = "grpHistoria";
			this.grpHistoria.Size = new System.Drawing.Size(440, 310);
			this.grpHistoria.TabIndex = 1;
			this.grpHistoria.TabStop = false;
			this.grpHistoria.Text = "Historia y Atributos del Personaje";
			// 
			// txtHistoria
			// 
			this.txtHistoria.Location = new System.Drawing.Point(12, 22);
			this.txtHistoria.Multiline = true;
			this.txtHistoria.Name = "txtHistoria";
			this.txtHistoria.ReadOnly = true;
			this.txtHistoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHistoria.Size = new System.Drawing.Size(416, 277);
			this.txtHistoria.TabIndex = 0;
			// 
			// btnMostrarHistoria
			// 
			this.btnMostrarHistoria.Location = new System.Drawing.Point(272, 330);
			this.btnMostrarHistoria.Name = "btnMostrarHistoria";
			this.btnMostrarHistoria.Size = new System.Drawing.Size(180, 30);
			this.btnMostrarHistoria.TabIndex = 2;
			this.btnMostrarHistoria.Text = "MOSTRAR HISTORIA";
			this.btnMostrarHistoria.UseVisualStyleBackColor = true;
			this.btnMostrarHistoria.Click += new System.EventHandler(this.BtnMostrarHistoriaClick);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(582, 330);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(130, 30);
			this.btnCerrar.TabIndex = 3;
			this.btnCerrar.Text = "Volver";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// FormLore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 372);
			this.Controls.Add(this.btnMostrarHistoria);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.grpHistoria);
			this.Controls.Add(this.grpLista);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormLore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Historia de Personajes (Lore)";
			this.grpLista.ResumeLayout(false);
			this.grpHistoria.ResumeLayout(false);
			this.grpHistoria.PerformLayout();
			this.ResumeLayout(false);
		}
	}
}
