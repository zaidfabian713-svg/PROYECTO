namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class FormGestionBD
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grpNuevo;
		private System.Windows.Forms.Label lblCadena;
		private System.Windows.Forms.TextBox txtCadena;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblMazo;
		private System.Windows.Forms.ListBox lstMazoGuardar;
		private System.Windows.Forms.Button btnGuardarBD;
		private System.Windows.Forms.GroupBox grpTabla;
		private System.Windows.Forms.ListBox lstRegistros;
		private System.Windows.Forms.Label lblDetalleRegistro;
		private System.Windows.Forms.Button btnSumarVictoria;
		private System.Windows.Forms.Button btnSumarDerrota;
		private System.Windows.Forms.Button btnVolver;

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
			this.grpNuevo = new System.Windows.Forms.GroupBox();
			this.btnGuardarBD = new System.Windows.Forms.Button();
			this.lstMazoGuardar = new System.Windows.Forms.ListBox();
			this.lblMazo = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCadena = new System.Windows.Forms.TextBox();
			this.lblCadena = new System.Windows.Forms.Label();
			this.grpTabla = new System.Windows.Forms.GroupBox();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnSumarDerrota = new System.Windows.Forms.Button();
			this.btnSumarVictoria = new System.Windows.Forms.Button();
			this.lblDetalleRegistro = new System.Windows.Forms.Label();
			this.lstRegistros = new System.Windows.Forms.ListBox();
			this.grpNuevo.SuspendLayout();
			this.grpTabla.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpNuevo
			// 
			this.grpNuevo.Controls.Add(this.btnGuardarBD);
			this.grpNuevo.Controls.Add(this.lstMazoGuardar);
			this.grpNuevo.Controls.Add(this.lblMazo);
			this.grpNuevo.Controls.Add(this.txtNombre);
			this.grpNuevo.Controls.Add(this.lblNombre);
			this.grpNuevo.Controls.Add(this.txtCadena);
			this.grpNuevo.Controls.Add(this.lblCadena);
			this.grpNuevo.Location = new System.Drawing.Point(12, 12);
			this.grpNuevo.Name = "grpNuevo";
			this.grpNuevo.Size = new System.Drawing.Size(290, 330);
			this.grpNuevo.TabIndex = 0;
			this.grpNuevo.TabStop = false;
			this.grpNuevo.Text = "Registrar Jugador y Mazo (SQL)";
			// 
			// lblCadena
			// 
			this.lblCadena.Location = new System.Drawing.Point(12, 22);
			this.lblCadena.Name = "lblCadena";
			this.lblCadena.Size = new System.Drawing.Size(260, 16);
			this.lblCadena.TabIndex = 0;
			this.lblCadena.Text = "Cadena de Conexión SQL:";
			// 
			// txtCadena
			// 
			this.txtCadena.Location = new System.Drawing.Point(12, 40);
			this.txtCadena.Name = "txtCadena";
			this.txtCadena.Size = new System.Drawing.Size(265, 20);
			this.txtCadena.TabIndex = 1;
			this.txtCadena.Text = "Server=localhost;Database=SangreYDogmaDB;Trusted_Connection=True;";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(12, 72);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(260, 16);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre del Jugador (Tabla Jugadores - PK):";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 90);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(265, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// lblMazo
			// 
			this.lblMazo.Location = new System.Drawing.Point(12, 122);
			this.lblMazo.Name = "lblMazo";
			this.lblMazo.Size = new System.Drawing.Size(265, 16);
			this.lblMazo.TabIndex = 4;
			this.lblMazo.Text = "Mazo de 5 Cartas (Tabla Mazos - FK):";
			// 
			// lstMazoGuardar
			// 
			this.lstMazoGuardar.FormattingEnabled = true;
			this.lstMazoGuardar.Location = new System.Drawing.Point(12, 142);
			this.lstMazoGuardar.Name = "lstMazoGuardar";
			this.lstMazoGuardar.Size = new System.Drawing.Size(265, 108);
			this.lstMazoGuardar.TabIndex = 5;
			// 
			// btnGuardarBD
			// 
			this.btnGuardarBD.Location = new System.Drawing.Point(12, 265);
			this.btnGuardarBD.Name = "btnGuardarBD";
			this.btnGuardarBD.Size = new System.Drawing.Size(265, 42);
			this.btnGuardarBD.TabIndex = 6;
			this.btnGuardarBD.Text = "Guardar Jugador y Mazo en BD";
			this.btnGuardarBD.UseVisualStyleBackColor = true;
			this.btnGuardarBD.Click += new System.EventHandler(this.BtnGuardarBDClick);
			// 
			// grpTabla
			// 
			this.grpTabla.Controls.Add(this.btnVolver);
			this.grpTabla.Controls.Add(this.btnSumarDerrota);
			this.grpTabla.Controls.Add(this.btnSumarVictoria);
			this.grpTabla.Controls.Add(this.lblDetalleRegistro);
			this.grpTabla.Controls.Add(this.lstRegistros);
			this.grpTabla.Location = new System.Drawing.Point(312, 12);
			this.grpTabla.Name = "grpTabla";
			this.grpTabla.Size = new System.Drawing.Size(400, 330);
			this.grpTabla.TabIndex = 1;
			this.grpTabla.TabStop = false;
			this.grpTabla.Text = "Jugadores, Mazos y Estadísticas (INNER JOIN PK/FK)";
			// 
			// lstRegistros
			// 
			this.lstRegistros.FormattingEnabled = true;
			this.lstRegistros.Location = new System.Drawing.Point(12, 24);
			this.lstRegistros.Name = "lstRegistros";
			this.lstRegistros.Size = new System.Drawing.Size(374, 147);
			this.lstRegistros.TabIndex = 0;
			this.lstRegistros.SelectedIndexChanged += new System.EventHandler(this.LstRegistrosSelectedIndexChanged);
			// 
			// lblDetalleRegistro
			// 
			this.lblDetalleRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDetalleRegistro.Location = new System.Drawing.Point(12, 180);
			this.lblDetalleRegistro.Name = "lblDetalleRegistro";
			this.lblDetalleRegistro.Size = new System.Drawing.Size(374, 85);
			this.lblDetalleRegistro.TabIndex = 1;
			this.lblDetalleRegistro.Text = "Seleccione un jugador para ver sus 5 cartas y estadísticas.";
			// 
			// btnSumarVictoria
			// 
			this.btnSumarVictoria.Location = new System.Drawing.Point(12, 278);
			this.btnSumarVictoria.Name = "btnSumarVictoria";
			this.btnSumarVictoria.Size = new System.Drawing.Size(115, 34);
			this.btnSumarVictoria.TabIndex = 2;
			this.btnSumarVictoria.Text = "+1 Victoria";
			this.btnSumarVictoria.UseVisualStyleBackColor = true;
			this.btnSumarVictoria.Click += new System.EventHandler(this.BtnSumarVictoriaClick);
			// 
			// btnSumarDerrota
			// 
			this.btnSumarDerrota.Location = new System.Drawing.Point(135, 278);
			this.btnSumarDerrota.Name = "btnSumarDerrota";
			this.btnSumarDerrota.Size = new System.Drawing.Size(115, 34);
			this.btnSumarDerrota.TabIndex = 3;
			this.btnSumarDerrota.Text = "+1 Derrota";
			this.btnSumarDerrota.UseVisualStyleBackColor = true;
			this.btnSumarDerrota.Click += new System.EventHandler(this.BtnSumarDerrotaClick);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(270, 278);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(116, 34);
			this.btnVolver.TabIndex = 4;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// FormGestionBD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 356);
			this.Controls.Add(this.grpTabla);
			this.Controls.Add(this.grpNuevo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormGestionBD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Gestión de Base de Datos SQL";
			this.grpNuevo.ResumeLayout(false);
			this.grpNuevo.PerformLayout();
			this.grpTabla.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
