namespace PROYECTO_SANGRE_Y_DOGMA
{
	partial class FormGeneradorMazos
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox grpCatalogo;
		private System.Windows.Forms.ListBox lstCatalogo;
		private System.Windows.Forms.Label lblInfoCarta;
		private System.Windows.Forms.GroupBox grpEditor;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblElemento;
		private System.Windows.Forms.ComboBox cmbElemento;
		private System.Windows.Forms.Label lblHP;
		private System.Windows.Forms.TextBox txtHP;
		private System.Windows.Forms.Label lblDEF;
		private System.Windows.Forms.TextBox txtDEF;
		private System.Windows.Forms.Label lblATK;
		private System.Windows.Forms.TextBox txtATK;
		private System.Windows.Forms.Label lblEMP;
		private System.Windows.Forms.TextBox txtEMP;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.Button btnCrearCarta;
		private System.Windows.Forms.GroupBox grpMazos;
		private System.Windows.Forms.Label lblJ1;
		private System.Windows.Forms.ListBox lstMazoJ1;
		private System.Windows.Forms.Button btnAgregarJ1;
		private System.Windows.Forms.Button btnLimpiarJ1;
		private System.Windows.Forms.Label lblJ2;
		private System.Windows.Forms.ListBox lstMazoJ2;
		private System.Windows.Forms.Button btnAgregarJ2;
		private System.Windows.Forms.Button btnLimpiarJ2;
		private System.Windows.Forms.Button btnGuardar;

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
			this.grpCatalogo = new System.Windows.Forms.GroupBox();
			this.lblInfoCarta = new System.Windows.Forms.Label();
			this.lstCatalogo = new System.Windows.Forms.ListBox();
			this.grpEditor = new System.Windows.Forms.GroupBox();
			this.btnCrearCarta = new System.Windows.Forms.Button();
			this.lblNota = new System.Windows.Forms.Label();
			this.txtEMP = new System.Windows.Forms.TextBox();
			this.lblEMP = new System.Windows.Forms.Label();
			this.txtATK = new System.Windows.Forms.TextBox();
			this.lblATK = new System.Windows.Forms.Label();
			this.txtDEF = new System.Windows.Forms.TextBox();
			this.lblDEF = new System.Windows.Forms.Label();
			this.txtHP = new System.Windows.Forms.TextBox();
			this.lblHP = new System.Windows.Forms.Label();
			this.cmbElemento = new System.Windows.Forms.ComboBox();
			this.lblElemento = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.grpMazos = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiarJ2 = new System.Windows.Forms.Button();
			this.btnAgregarJ2 = new System.Windows.Forms.Button();
			this.lstMazoJ2 = new System.Windows.Forms.ListBox();
			this.lblJ2 = new System.Windows.Forms.Label();
			this.btnLimpiarJ1 = new System.Windows.Forms.Button();
			this.btnAgregarJ1 = new System.Windows.Forms.Button();
			this.lstMazoJ1 = new System.Windows.Forms.ListBox();
			this.lblJ1 = new System.Windows.Forms.Label();
			this.grpCatalogo.SuspendLayout();
			this.grpEditor.SuspendLayout();
			this.grpMazos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpCatalogo
			// 
			this.grpCatalogo.Controls.Add(this.lblInfoCarta);
			this.grpCatalogo.Controls.Add(this.lstCatalogo);
			this.grpCatalogo.Location = new System.Drawing.Point(12, 12);
			this.grpCatalogo.Name = "grpCatalogo";
			this.grpCatalogo.Size = new System.Drawing.Size(265, 360);
			this.grpCatalogo.TabIndex = 0;
			this.grpCatalogo.TabStop = false;
			this.grpCatalogo.Text = "Catálogo (16 Cartas)";
			// 
			// lstCatalogo
			// 
			this.lstCatalogo.FormattingEnabled = true;
			this.lstCatalogo.Location = new System.Drawing.Point(12, 22);
			this.lstCatalogo.Name = "lstCatalogo";
			this.lstCatalogo.Size = new System.Drawing.Size(240, 238);
			this.lstCatalogo.TabIndex = 0;
			this.lstCatalogo.SelectedIndexChanged += new System.EventHandler(this.LstCatalogoSelectedIndexChanged);
			// 
			// lblInfoCarta
			// 
			this.lblInfoCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblInfoCarta.Location = new System.Drawing.Point(12, 270);
			this.lblInfoCarta.Name = "lblInfoCarta";
			this.lblInfoCarta.Size = new System.Drawing.Size(240, 75);
			this.lblInfoCarta.TabIndex = 1;
			this.lblInfoCarta.Text = "Seleccione una carta.";
			// 
			// grpEditor
			// 
			this.grpEditor.Controls.Add(this.btnCrearCarta);
			this.grpEditor.Controls.Add(this.lblNota);
			this.grpEditor.Controls.Add(this.txtEMP);
			this.grpEditor.Controls.Add(this.lblEMP);
			this.grpEditor.Controls.Add(this.txtATK);
			this.grpEditor.Controls.Add(this.lblATK);
			this.grpEditor.Controls.Add(this.txtDEF);
			this.grpEditor.Controls.Add(this.lblDEF);
			this.grpEditor.Controls.Add(this.txtHP);
			this.grpEditor.Controls.Add(this.lblHP);
			this.grpEditor.Controls.Add(this.cmbElemento);
			this.grpEditor.Controls.Add(this.lblElemento);
			this.grpEditor.Controls.Add(this.txtNombre);
			this.grpEditor.Controls.Add(this.lblNombre);
			this.grpEditor.Location = new System.Drawing.Point(285, 12);
			this.grpEditor.Name = "grpEditor";
			this.grpEditor.Size = new System.Drawing.Size(240, 360);
			this.grpEditor.TabIndex = 1;
			this.grpEditor.TabStop = false;
			this.grpEditor.Text = "Crear Carta (HP+DEF+ATK = 100)";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(12, 25);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(210, 16);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 43);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(210, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// lblElemento
			// 
			this.lblElemento.Location = new System.Drawing.Point(12, 75);
			this.lblElemento.Name = "lblElemento";
			this.lblElemento.Size = new System.Drawing.Size(80, 18);
			this.lblElemento.TabIndex = 2;
			this.lblElemento.Text = "Elemento:";
			// 
			// cmbElemento
			// 
			this.cmbElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbElemento.FormattingEnabled = true;
			this.cmbElemento.Items.AddRange(new object[] {
			"Agua",
			"Tierra",
			"Viento",
			"Fuego"});
			this.cmbElemento.Location = new System.Drawing.Point(95, 72);
			this.cmbElemento.Name = "cmbElemento";
			this.cmbElemento.Size = new System.Drawing.Size(127, 21);
			this.cmbElemento.TabIndex = 3;
			// 
			// lblHP
			// 
			this.lblHP.Location = new System.Drawing.Point(12, 112);
			this.lblHP.Name = "lblHP";
			this.lblHP.Size = new System.Drawing.Size(40, 18);
			this.lblHP.TabIndex = 4;
			this.lblHP.Text = "HP:";
			// 
			// txtHP
			// 
			this.txtHP.Location = new System.Drawing.Point(55, 109);
			this.txtHP.Name = "txtHP";
			this.txtHP.Size = new System.Drawing.Size(50, 20);
			this.txtHP.TabIndex = 5;
			this.txtHP.Text = "45";
			// 
			// lblDEF
			// 
			this.lblDEF.Location = new System.Drawing.Point(120, 112);
			this.lblDEF.Name = "lblDEF";
			this.lblDEF.Size = new System.Drawing.Size(45, 18);
			this.lblDEF.TabIndex = 6;
			this.lblDEF.Text = "DEF:";
			// 
			// txtDEF
			// 
			this.txtDEF.Location = new System.Drawing.Point(170, 109);
			this.txtDEF.Name = "txtDEF";
			this.txtDEF.Size = new System.Drawing.Size(52, 20);
			this.txtDEF.TabIndex = 7;
			this.txtDEF.Text = "30";
			// 
			// lblATK
			// 
			this.lblATK.Location = new System.Drawing.Point(12, 148);
			this.lblATK.Name = "lblATK";
			this.lblATK.Size = new System.Drawing.Size(40, 18);
			this.lblATK.TabIndex = 8;
			this.lblATK.Text = "ATK:";
			// 
			// txtATK
			// 
			this.txtATK.Location = new System.Drawing.Point(55, 145);
			this.txtATK.Name = "txtATK";
			this.txtATK.Size = new System.Drawing.Size(50, 20);
			this.txtATK.TabIndex = 9;
			this.txtATK.Text = "25";
			// 
			// lblEMP
			// 
			this.lblEMP.Location = new System.Drawing.Point(120, 148);
			this.lblEMP.Name = "lblEMP";
			this.lblEMP.Size = new System.Drawing.Size(45, 18);
			this.lblEMP.TabIndex = 10;
			this.lblEMP.Text = "EMP:";
			// 
			// txtEMP
			// 
			this.txtEMP.Location = new System.Drawing.Point(170, 145);
			this.txtEMP.Name = "txtEMP";
			this.txtEMP.Size = new System.Drawing.Size(52, 20);
			this.txtEMP.TabIndex = 11;
			this.txtEMP.Text = "60";
			// 
			// lblNota
			// 
			this.lblNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNota.Location = new System.Drawing.Point(12, 185);
			this.lblNota.Name = "lblNota";
			this.lblNota.Size = new System.Drawing.Size(210, 55);
			this.lblNota.TabIndex = 12;
			this.lblNota.Text = "Regla de la guía: la suma de HP + DEF + ATK debe dar exactamente 100.";
			// 
			// btnCrearCarta
			// 
			this.btnCrearCarta.Location = new System.Drawing.Point(12, 260);
			this.btnCrearCarta.Name = "btnCrearCarta";
			this.btnCrearCarta.Size = new System.Drawing.Size(210, 40);
			this.btnCrearCarta.TabIndex = 13;
			this.btnCrearCarta.Text = "Guardar Carta en Catálogo";
			this.btnCrearCarta.UseVisualStyleBackColor = true;
			this.btnCrearCarta.Click += new System.EventHandler(this.BtnCrearCartaClick);
			// 
			// grpMazos
			// 
			this.grpMazos.Controls.Add(this.btnGuardar);
			this.grpMazos.Controls.Add(this.btnLimpiarJ2);
			this.grpMazos.Controls.Add(this.btnAgregarJ2);
			this.grpMazos.Controls.Add(this.lstMazoJ2);
			this.grpMazos.Controls.Add(this.lblJ2);
			this.grpMazos.Controls.Add(this.btnLimpiarJ1);
			this.grpMazos.Controls.Add(this.btnAgregarJ1);
			this.grpMazos.Controls.Add(this.lstMazoJ1);
			this.grpMazos.Controls.Add(this.lblJ1);
			this.grpMazos.Location = new System.Drawing.Point(535, 12);
			this.grpMazos.Name = "grpMazos";
			this.grpMazos.Size = new System.Drawing.Size(280, 360);
			this.grpMazos.TabIndex = 2;
			this.grpMazos.TabStop = false;
			this.grpMazos.Text = "Armar Mazos de 5 Cartas (Queue)";
			// 
			// lblJ1
			// 
			this.lblJ1.Location = new System.Drawing.Point(12, 22);
			this.lblJ1.Name = "lblJ1";
			this.lblJ1.Size = new System.Drawing.Size(250, 16);
			this.lblJ1.TabIndex = 0;
			this.lblJ1.Text = "Mazo Jugador 1 (5 cartas):";
			// 
			// lstMazoJ1
			// 
			this.lstMazoJ1.FormattingEnabled = true;
			this.lstMazoJ1.Location = new System.Drawing.Point(12, 40);
			this.lstMazoJ1.Name = "lstMazoJ1";
			this.lstMazoJ1.Size = new System.Drawing.Size(255, 82);
			this.lstMazoJ1.TabIndex = 1;
			// 
			// btnAgregarJ1
			// 
			this.btnAgregarJ1.Location = new System.Drawing.Point(12, 126);
			this.btnAgregarJ1.Name = "btnAgregarJ1";
			this.btnAgregarJ1.Size = new System.Drawing.Size(155, 25);
			this.btnAgregarJ1.TabIndex = 2;
			this.btnAgregarJ1.Text = "Agregar a Jugador 1";
			this.btnAgregarJ1.UseVisualStyleBackColor = true;
			this.btnAgregarJ1.Click += new System.EventHandler(this.BtnAgregarJ1Click);
			// 
			// btnLimpiarJ1
			// 
			this.btnLimpiarJ1.Location = new System.Drawing.Point(175, 126);
			this.btnLimpiarJ1.Name = "btnLimpiarJ1";
			this.btnLimpiarJ1.Size = new System.Drawing.Size(92, 25);
			this.btnLimpiarJ1.TabIndex = 3;
			this.btnLimpiarJ1.Text = "Borrar J1";
			this.btnLimpiarJ1.UseVisualStyleBackColor = true;
			this.btnLimpiarJ1.Click += new System.EventHandler(this.BtnLimpiarJ1Click);
			// 
			// lblJ2
			// 
			this.lblJ2.Location = new System.Drawing.Point(12, 162);
			this.lblJ2.Name = "lblJ2";
			this.lblJ2.Size = new System.Drawing.Size(250, 16);
			this.lblJ2.TabIndex = 4;
			this.lblJ2.Text = "Mazo Jugador 2 (5 cartas):";
			// 
			// lstMazoJ2
			// 
			this.lstMazoJ2.FormattingEnabled = true;
			this.lstMazoJ2.Location = new System.Drawing.Point(12, 180);
			this.lstMazoJ2.Name = "lstMazoJ2";
			this.lstMazoJ2.Size = new System.Drawing.Size(255, 82);
			this.lstMazoJ2.TabIndex = 5;
			// 
			// btnAgregarJ2
			// 
			this.btnAgregarJ2.Location = new System.Drawing.Point(12, 266);
			this.btnAgregarJ2.Name = "btnAgregarJ2";
			this.btnAgregarJ2.Size = new System.Drawing.Size(155, 25);
			this.btnAgregarJ2.TabIndex = 6;
			this.btnAgregarJ2.Text = "Agregar a Jugador 2";
			this.btnAgregarJ2.UseVisualStyleBackColor = true;
			this.btnAgregarJ2.Click += new System.EventHandler(this.BtnAgregarJ2Click);
			// 
			// btnLimpiarJ2
			// 
			this.btnLimpiarJ2.Location = new System.Drawing.Point(175, 266);
			this.btnLimpiarJ2.Name = "btnLimpiarJ2";
			this.btnLimpiarJ2.Size = new System.Drawing.Size(92, 25);
			this.btnLimpiarJ2.TabIndex = 7;
			this.btnLimpiarJ2.Text = "Borrar J2";
			this.btnLimpiarJ2.UseVisualStyleBackColor = true;
			this.btnLimpiarJ2.Click += new System.EventHandler(this.BtnLimpiarJ2Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(12, 305);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(255, 40);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar Mazos y Salir";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FormGeneradorMazos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 386);
			this.Controls.Add(this.grpMazos);
			this.Controls.Add(this.grpEditor);
			this.Controls.Add(this.grpCatalogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormGeneradorMazos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Generador de Cartas y Mazos";
			this.grpCatalogo.ResumeLayout(false);
			this.grpEditor.ResumeLayout(false);
			this.grpEditor.PerformLayout();
			this.grpMazos.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
