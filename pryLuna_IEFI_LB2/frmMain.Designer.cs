namespace pryLuna_IEFI_LB2
{
    partial class frmMain
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mrcSexo = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.nudIngreso = new System.Windows.Forms.NumericUpDown();
            this.nudPuntaje = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mrcAnadirPais = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mrcAnadirPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puntaje";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(98, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(98, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(44, 319);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 25);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(144, 319);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMasculino.Location = new System.Drawing.Point(12, 20);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(72, 18);
            this.optMasculino.TabIndex = 13;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFemenino.Location = new System.Drawing.Point(94, 20);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 18);
            this.optFemenino.TabIndex = 14;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // cmbPaises
            // 
            this.cmbPaises.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Location = new System.Drawing.Point(96, 187);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(121, 22);
            this.cmbPaises.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Edad";
            // 
            // mrcSexo
            // 
            this.mrcSexo.Controls.Add(this.optFemenino);
            this.mrcSexo.Controls.Add(this.optMasculino);
            this.mrcSexo.Location = new System.Drawing.Point(44, 123);
            this.mrcSexo.Name = "mrcSexo";
            this.mrcSexo.Size = new System.Drawing.Size(175, 52);
            this.mrcSexo.TabIndex = 20;
            this.mrcSexo.TabStop = false;
            this.mrcSexo.Text = "Sexo";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(98, 94);
            this.nudEdad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(57, 20);
            this.nudEdad.TabIndex = 23;
            this.nudEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudEdad.ValueChanged += new System.EventHandler(this.nudEdad_ValueChanged);
            // 
            // nudIngreso
            // 
            this.nudIngreso.Location = new System.Drawing.Point(96, 227);
            this.nudIngreso.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudIngreso.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIngreso.Name = "nudIngreso";
            this.nudIngreso.Size = new System.Drawing.Size(123, 20);
            this.nudIngreso.TabIndex = 24;
            this.nudIngreso.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudPuntaje
            // 
            this.nudPuntaje.Location = new System.Drawing.Point(96, 265);
            this.nudPuntaje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPuntaje.Minimum = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            this.nudPuntaje.Name = "nudPuntaje";
            this.nudPuntaje.Size = new System.Drawing.Size(123, 20);
            this.nudPuntaje.TabIndex = 25;
            this.nudPuntaje.Value = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 390);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.nudPuntaje);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.nudIngreso);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudEdad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.mrcSexo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbPaises);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mrcAnadirPais);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro del país";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mrcAnadirPais
            // 
            this.mrcAnadirPais.Controls.Add(this.textBox1);
            this.mrcAnadirPais.Controls.Add(this.btnAgregar);
            this.mrcAnadirPais.Controls.Add(this.label1);
            this.mrcAnadirPais.Location = new System.Drawing.Point(16, 18);
            this.mrcAnadirPais.Name = "mrcAnadirPais";
            this.mrcAnadirPais.Size = new System.Drawing.Size(222, 102);
            this.mrcAnadirPais.TabIndex = 12;
            this.mrcAnadirPais.TabStop = false;
            this.mrcAnadirPais.Text = "Añadir País";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(79, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(97, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar País";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 408);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Registro de miembros";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.mrcSexo.ResumeLayout(false);
            this.mrcSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.mrcAnadirPais.ResumeLayout(false);
            this.mrcAnadirPais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox mrcSexo;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.NumericUpDown nudIngreso;
        private System.Windows.Forms.NumericUpDown nudPuntaje;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox mrcAnadirPais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
    }
}

