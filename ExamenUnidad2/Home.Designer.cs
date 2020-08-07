namespace ExamenUnidad2
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombreFloricola = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTallosXBonche = new System.Windows.Forms.Label();
            this.btnClonar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numBloMa = new System.Windows.Forms.NumericUpDown();
            this.numBloCam = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBloques = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numVarMa = new System.Windows.Forms.NumericUpDown();
            this.numVarCos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVarNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstVariedades = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBloque = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbVariedad = new System.Windows.Forms.ComboBox();
            this.cmbEnfermedad = new System.Windows.Forms.ComboBox();
            this.btnDar = new System.Windows.Forms.Button();
            this.lblCostoEnfer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBloMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBloCam)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVarCos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la floricola:";
            // 
            // lblnombreFloricola
            // 
            this.lblnombreFloricola.AutoSize = true;
            this.lblnombreFloricola.Location = new System.Drawing.Point(187, 20);
            this.lblnombreFloricola.Name = "lblnombreFloricola";
            this.lblnombreFloricola.Size = new System.Drawing.Size(35, 13);
            this.lblnombreFloricola.TabIndex = 1;
            this.lblnombreFloricola.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tallos por bonche:";
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Location = new System.Drawing.Point(158, 68);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(35, 13);
            this.lblMedidas.TabIndex = 4;
            this.lblMedidas.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Medidas de exportación:";
            // 
            // lblTallosXBonche
            // 
            this.lblTallosXBonche.AutoSize = true;
            this.lblTallosXBonche.Location = new System.Drawing.Point(187, 44);
            this.lblTallosXBonche.Name = "lblTallosXBonche";
            this.lblTallosXBonche.Size = new System.Drawing.Size(35, 13);
            this.lblTallosXBonche.TabIndex = 5;
            this.lblTallosXBonche.Text = "label6";
            // 
            // btnClonar
            // 
            this.btnClonar.Location = new System.Drawing.Point(302, 49);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(75, 23);
            this.btnClonar.TabIndex = 6;
            this.btnClonar.Text = "Clonar";
            this.btnClonar.UseVisualStyleBackColor = true;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numBloMa);
            this.groupBox1.Controls.Add(this.btnClonar);
            this.groupBox1.Controls.Add(this.numBloCam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEncargado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(316, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloque culltivable";
            // 
            // numBloMa
            // 
            this.numBloMa.Location = new System.Drawing.Point(168, 74);
            this.numBloMa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBloMa.Name = "numBloMa";
            this.numBloMa.Size = new System.Drawing.Size(120, 20);
            this.numBloMa.TabIndex = 10;
            // 
            // numBloCam
            // 
            this.numBloCam.Location = new System.Drawing.Point(168, 30);
            this.numBloCam.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBloCam.Name = "numBloCam";
            this.numBloCam.Size = new System.Drawing.Size(120, 20);
            this.numBloCam.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Número de matas:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(168, 53);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(120, 20);
            this.txtEncargado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encargado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de camas:";
            // 
            // lstBloques
            // 
            this.lstBloques.FormattingEnabled = true;
            this.lstBloques.Location = new System.Drawing.Point(358, 136);
            this.lstBloques.Name = "lstBloques";
            this.lstBloques.Size = new System.Drawing.Size(296, 43);
            this.lstBloques.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.numVarMa);
            this.groupBox2.Controls.Add(this.numVarCos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtVarNombre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(32, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variedades";
            // 
            // numVarMa
            // 
            this.numVarMa.Location = new System.Drawing.Point(134, 72);
            this.numVarMa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVarMa.Name = "numVarMa";
            this.numVarMa.Size = new System.Drawing.Size(120, 20);
            this.numVarMa.TabIndex = 18;
            // 
            // numVarCos
            // 
            this.numVarCos.Location = new System.Drawing.Point(187, 108);
            this.numVarCos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numVarCos.Name = "numVarCos";
            this.numVarCos.Size = new System.Drawing.Size(67, 20);
            this.numVarCos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cantidad de matas";
            // 
            // txtVarNombre
            // 
            this.txtVarNombre.Location = new System.Drawing.Point(134, 37);
            this.txtVarNombre.Name = "txtVarNombre";
            this.txtVarNombre.Size = new System.Drawing.Size(120, 20);
            this.txtVarNombre.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Costo por mata:";
            // 
            // lstVariedades
            // 
            this.lstVariedades.FormattingEnabled = true;
            this.lstVariedades.Location = new System.Drawing.Point(32, 364);
            this.lstVariedades.Name = "lstVariedades";
            this.lstVariedades.Size = new System.Drawing.Size(296, 43);
            this.lstVariedades.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(427, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(270, 62);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 19;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblCostoEnfer);
            this.groupBox3.Controls.Add(this.btnDar);
            this.groupBox3.Controls.Add(this.cmbEnfermedad);
            this.groupBox3.Controls.Add(this.cmbVariedad);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmbBloque);
            this.groupBox3.Location = new System.Drawing.Point(419, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 201);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enfermedades";
            // 
            // cmbBloque
            // 
            this.cmbBloque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloque.FormattingEnabled = true;
            this.cmbBloque.Location = new System.Drawing.Point(147, 19);
            this.cmbBloque.Name = "cmbBloque";
            this.cmbBloque.Size = new System.Drawing.Size(121, 21);
            this.cmbBloque.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Variedad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Enfermedad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Id Bloque:";
            // 
            // cmbVariedad
            // 
            this.cmbVariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariedad.FormattingEnabled = true;
            this.cmbVariedad.Location = new System.Drawing.Point(147, 49);
            this.cmbVariedad.Name = "cmbVariedad";
            this.cmbVariedad.Size = new System.Drawing.Size(121, 21);
            this.cmbVariedad.TabIndex = 10;
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.Location = new System.Drawing.Point(147, 80);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.Size = new System.Drawing.Size(121, 21);
            this.cmbEnfermedad.TabIndex = 11;
            // 
            // btnDar
            // 
            this.btnDar.Location = new System.Drawing.Point(82, 119);
            this.btnDar.Name = "btnDar";
            this.btnDar.Size = new System.Drawing.Size(125, 23);
            this.btnDar.TabIndex = 12;
            this.btnDar.Text = "Dar enfermedad";
            this.btnDar.UseVisualStyleBackColor = true;
            this.btnDar.Click += new System.EventHandler(this.btnDar_Click);
            // 
            // lblCostoEnfer
            // 
            this.lblCostoEnfer.AutoSize = true;
            this.lblCostoEnfer.Location = new System.Drawing.Point(126, 168);
            this.lblCostoEnfer.Name = "lblCostoEnfer";
            this.lblCostoEnfer.Size = new System.Drawing.Size(25, 13);
            this.lblCostoEnfer.TabIndex = 13;
            this.lblCostoEnfer.Text = "------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Costo por mata por la enfermedad";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstVariedades);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstBloques);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTallosXBonche);
            this.Controls.Add(this.lblMedidas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnombreFloricola);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBloMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBloCam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVarCos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombreFloricola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTallosXBonche;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBloMa;
        private System.Windows.Forms.NumericUpDown numBloCam;
        private System.Windows.Forms.ListBox lstBloques;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numVarMa;
        private System.Windows.Forms.NumericUpDown numVarCos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVarNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstVariedades;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDar;
        private System.Windows.Forms.ComboBox cmbEnfermedad;
        private System.Windows.Forms.ComboBox cmbVariedad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBloque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCostoEnfer;
    }
}

