namespace EExamenPractico3
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
            this.rdbPaciente1 = new System.Windows.Forms.RadioButton();
            this.rdbPaciente2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCostoConsultaGeneral = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPadecimiento = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrarPagarMenos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoTratamiento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPaciente1
            // 
            this.rdbPaciente1.AutoSize = true;
            this.rdbPaciente1.Checked = true;
            this.rdbPaciente1.Location = new System.Drawing.Point(12, 26);
            this.rdbPaciente1.Name = "rdbPaciente1";
            this.rdbPaciente1.Size = new System.Drawing.Size(76, 17);
            this.rdbPaciente1.TabIndex = 0;
            this.rdbPaciente1.TabStop = true;
            this.rdbPaciente1.Text = "Paciente 1";
            this.rdbPaciente1.UseVisualStyleBackColor = true;
            // 
            // rdbPaciente2
            // 
            this.rdbPaciente2.AutoSize = true;
            this.rdbPaciente2.Location = new System.Drawing.Point(113, 26);
            this.rdbPaciente2.Name = "rdbPaciente2";
            this.rdbPaciente2.Size = new System.Drawing.Size(76, 17);
            this.rdbPaciente2.TabIndex = 1;
            this.rdbPaciente2.Text = "Paciente 2";
            this.rdbPaciente2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostoTratamiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnMostrarPagarMenos);
            this.groupBox1.Controls.Add(this.btnCapturar);
            this.groupBox1.Controls.Add(this.cmbPadecimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.txtCostoConsultaGeneral);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo por consulta general";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(86, 93);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(59, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtCostoConsultaGeneral
            // 
            this.txtCostoConsultaGeneral.Location = new System.Drawing.Point(151, 132);
            this.txtCostoConsultaGeneral.Name = "txtCostoConsultaGeneral";
            this.txtCostoConsultaGeneral.Size = new System.Drawing.Size(100, 20);
            this.txtCostoConsultaGeneral.TabIndex = 6;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmbSexo.Location = new System.Drawing.Point(86, 63);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(148, 21);
            this.cmbSexo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Padecimiento";
            // 
            // cmbPadecimiento
            // 
            this.cmbPadecimiento.FormattingEnabled = true;
            this.cmbPadecimiento.Items.AddRange(new object[] {
            "ARTRITIS",
            "HIPERTENCION",
            "GASTRITIS"});
            this.cmbPadecimiento.Location = new System.Drawing.Point(103, 174);
            this.cmbPadecimiento.Name = "cmbPadecimiento";
            this.cmbPadecimiento.Size = new System.Drawing.Size(148, 21);
            this.cmbPadecimiento.TabIndex = 9;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(294, 29);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(98, 55);
            this.btnCapturar.TabIndex = 10;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrarPagarMenos
            // 
            this.btnMostrarPagarMenos.Location = new System.Drawing.Point(294, 100);
            this.btnMostrarPagarMenos.Name = "btnMostrarPagarMenos";
            this.btnMostrarPagarMenos.Size = new System.Drawing.Size(98, 55);
            this.btnMostrarPagarMenos.TabIndex = 11;
            this.btnMostrarPagarMenos.Text = "Nombre de la persona que  paga menos";
            this.btnMostrarPagarMenos.UseVisualStyleBackColor = true;
            this.btnMostrarPagarMenos.Click += new System.EventHandler(this.btnMostrarPagarMenos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Costo tratamiento";
            // 
            // txtCostoTratamiento
            // 
            this.txtCostoTratamiento.Location = new System.Drawing.Point(109, 210);
            this.txtCostoTratamiento.Name = "txtCostoTratamiento";
            this.txtCostoTratamiento.Size = new System.Drawing.Size(94, 20);
            this.txtCostoTratamiento.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbPaciente2);
            this.Controls.Add(this.rdbPaciente1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPaciente1;
        private System.Windows.Forms.RadioButton rdbPaciente2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtCostoConsultaGeneral;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPadecimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMostrarPagarMenos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtCostoTratamiento;
        private System.Windows.Forms.Label label6;
    }
}

