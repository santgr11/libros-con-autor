namespace libro_con_autor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLibro = new System.Windows.Forms.GroupBox();
            this.cbLibrGenero = new System.Windows.Forms.ComboBox();
            this.txtLibrTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.rbAutSexoF = new System.Windows.Forms.RadioButton();
            this.rbAutSexoM = new System.Windows.Forms.RadioButton();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtAutNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblAutFecNac = new System.Windows.Forms.Label();
            this.lblAutSexo = new System.Windows.Forms.Label();
            this.lblAutDoc = new System.Windows.Forms.Label();
            this.lblAutNombre = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.lblTotalHdsd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalH = new System.Windows.Forms.Label();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.gbLibro.SuspendLayout();
            this.gbAutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLibro
            // 
            this.gbLibro.Controls.Add(this.cbLibrGenero);
            this.gbLibro.Controls.Add(this.txtLibrTitulo);
            this.gbLibro.Controls.Add(this.txtISBN);
            this.gbLibro.Controls.Add(this.lblGenero);
            this.gbLibro.Controls.Add(this.lblTitulo);
            this.gbLibro.Controls.Add(this.lblISBN);
            this.gbLibro.Controls.Add(this.groupBox2);
            this.gbLibro.Location = new System.Drawing.Point(12, 12);
            this.gbLibro.Name = "gbLibro";
            this.gbLibro.Size = new System.Drawing.Size(305, 122);
            this.gbLibro.TabIndex = 0;
            this.gbLibro.TabStop = false;
            this.gbLibro.Text = "Libro";
            this.gbLibro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbLibrGenero
            // 
            this.cbLibrGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLibrGenero.FormattingEnabled = true;
            this.cbLibrGenero.Items.AddRange(new object[] {
            "Matematica",
            "Fisica",
            "Quimica",
            "Biologia"});
            this.cbLibrGenero.Location = new System.Drawing.Point(153, 85);
            this.cbLibrGenero.Name = "cbLibrGenero";
            this.cbLibrGenero.Size = new System.Drawing.Size(119, 21);
            this.cbLibrGenero.TabIndex = 2;
            // 
            // txtLibrTitulo
            // 
            this.txtLibrTitulo.Location = new System.Drawing.Point(153, 51);
            this.txtLibrTitulo.Name = "txtLibrTitulo";
            this.txtLibrTitulo.Size = new System.Drawing.Size(119, 20);
            this.txtLibrTitulo.TabIndex = 1;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(153, 17);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(119, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(85, 88);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(94, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(95, 20);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 219);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbAutor
            // 
            this.gbAutor.Controls.Add(this.rbAutSexoF);
            this.gbAutor.Controls.Add(this.rbAutSexoM);
            this.gbAutor.Controls.Add(this.txtDocumento);
            this.gbAutor.Controls.Add(this.txtAutNombre);
            this.gbAutor.Controls.Add(this.dtpFechaNac);
            this.gbAutor.Controls.Add(this.lblAutFecNac);
            this.gbAutor.Controls.Add(this.lblAutSexo);
            this.gbAutor.Controls.Add(this.lblAutDoc);
            this.gbAutor.Controls.Add(this.lblAutNombre);
            this.gbAutor.Controls.Add(this.groupBox3);
            this.gbAutor.Location = new System.Drawing.Point(12, 151);
            this.gbAutor.Name = "gbAutor";
            this.gbAutor.Size = new System.Drawing.Size(305, 155);
            this.gbAutor.TabIndex = 1;
            this.gbAutor.TabStop = false;
            this.gbAutor.Text = "Autor";
            // 
            // rbAutSexoF
            // 
            this.rbAutSexoF.AutoSize = true;
            this.rbAutSexoF.Location = new System.Drawing.Point(221, 82);
            this.rbAutSexoF.Name = "rbAutSexoF";
            this.rbAutSexoF.Size = new System.Drawing.Size(51, 17);
            this.rbAutSexoF.TabIndex = 14;
            this.rbAutSexoF.TabStop = true;
            this.rbAutSexoF.Text = "Mujer";
            this.rbAutSexoF.UseVisualStyleBackColor = true;
            // 
            // rbAutSexoM
            // 
            this.rbAutSexoM.AutoSize = true;
            this.rbAutSexoM.Location = new System.Drawing.Point(153, 82);
            this.rbAutSexoM.Name = "rbAutSexoM";
            this.rbAutSexoM.Size = new System.Drawing.Size(62, 17);
            this.rbAutSexoM.TabIndex = 2;
            this.rbAutSexoM.TabStop = true;
            this.rbAutSexoM.Text = "Hombre";
            this.rbAutSexoM.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(153, 51);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(119, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // txtAutNombre
            // 
            this.txtAutNombre.Location = new System.Drawing.Point(153, 20);
            this.txtAutNombre.Name = "txtAutNombre";
            this.txtAutNombre.Size = new System.Drawing.Size(119, 20);
            this.txtAutNombre.TabIndex = 0;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(153, 110);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(119, 20);
            this.dtpFechaNac.TabIndex = 3;
            // 
            // lblAutFecNac
            // 
            this.lblAutFecNac.AutoSize = true;
            this.lblAutFecNac.Location = new System.Drawing.Point(19, 116);
            this.lblAutFecNac.Name = "lblAutFecNac";
            this.lblAutFecNac.Size = new System.Drawing.Size(108, 13);
            this.lblAutFecNac.TabIndex = 10;
            this.lblAutFecNac.Text = "Fecha de Nacimiento";
            // 
            // lblAutSexo
            // 
            this.lblAutSexo.AutoSize = true;
            this.lblAutSexo.Location = new System.Drawing.Point(96, 84);
            this.lblAutSexo.Name = "lblAutSexo";
            this.lblAutSexo.Size = new System.Drawing.Size(31, 13);
            this.lblAutSexo.TabIndex = 9;
            this.lblAutSexo.Text = "Sexo";
            // 
            // lblAutDoc
            // 
            this.lblAutDoc.AutoSize = true;
            this.lblAutDoc.Location = new System.Drawing.Point(65, 54);
            this.lblAutDoc.Name = "lblAutDoc";
            this.lblAutDoc.Size = new System.Drawing.Size(62, 13);
            this.lblAutDoc.TabIndex = 8;
            this.lblAutDoc.Text = "Documento";
            // 
            // lblAutNombre
            // 
            this.lblAutNombre.AutoSize = true;
            this.lblAutNombre.Location = new System.Drawing.Point(83, 23);
            this.lblAutNombre.Name = "lblAutNombre";
            this.lblAutNombre.Size = new System.Drawing.Size(44, 13);
            this.lblAutNombre.TabIndex = 7;
            this.lblAutNombre.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(81, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(178, 321);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblTotalHdsd
            // 
            this.lblTotalHdsd.AutoSize = true;
            this.lblTotalHdsd.Location = new System.Drawing.Point(36, 361);
            this.lblTotalHdsd.Name = "lblTotalHdsd";
            this.lblTotalHdsd.Size = new System.Drawing.Size(183, 13);
            this.lblTotalHdsd.TabIndex = 4;
            this.lblTotalHdsd.Text = "Cantidad de Libros con autor Hombre";
            this.lblTotalHdsd.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de Libros con autor Mujer";
            // 
            // lblTotalH
            // 
            this.lblTotalH.AutoSize = true;
            this.lblTotalH.Location = new System.Drawing.Point(285, 361);
            this.lblTotalH.Name = "lblTotalH";
            this.lblTotalH.Size = new System.Drawing.Size(13, 13);
            this.lblTotalH.TabIndex = 6;
            this.lblTotalH.Text = "0";
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.Location = new System.Drawing.Point(285, 387);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(13, 13);
            this.lblTotalF.TabIndex = 7;
            this.lblTotalF.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 438);
            this.Controls.Add(this.lblTotalF);
            this.Controls.Add(this.lblTotalH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalHdsd);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbAutor);
            this.Controls.Add(this.gbLibro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLibro.ResumeLayout(false);
            this.gbLibro.PerformLayout();
            this.gbAutor.ResumeLayout(false);
            this.gbAutor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.GroupBox gbAutor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbLibrGenero;
        private System.Windows.Forms.TextBox txtLibrTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.RadioButton rbAutSexoF;
        private System.Windows.Forms.RadioButton rbAutSexoM;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtAutNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblAutFecNac;
        private System.Windows.Forms.Label lblAutSexo;
        private System.Windows.Forms.Label lblAutDoc;
        private System.Windows.Forms.Label lblAutNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.Label lblTotalHdsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalH;
        private System.Windows.Forms.Label lblTotalF;
    }
}

