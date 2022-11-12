namespace EjPolimorfismo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbTipoAlimento = new System.Windows.Forms.GroupBox();
            this.rdbPayManzana = new System.Windows.Forms.RadioButton();
            this.rdbPapas = new System.Windows.Forms.RadioButton();
            this.rdbRefresco = new System.Windows.Forms.RadioButton();
            this.rdbHamburguesa = new System.Windows.Forms.RadioButton();
            this.cmbTHamburguesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnSAlir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtQueso = new System.Windows.Forms.TextBox();
            this.txtJalapenos = new System.Windows.Forms.TextBox();
            this.txtChampinones = new System.Windows.Forms.TextBox();
            this.grbDatosHamburguesa = new System.Windows.Forms.GroupBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHielo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbTipoAlimento.SuspendLayout();
            this.grbDatosHamburguesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoAlimento
            // 
            this.grbTipoAlimento.BackColor = System.Drawing.Color.Red;
            this.grbTipoAlimento.Controls.Add(this.rdbPayManzana);
            this.grbTipoAlimento.Controls.Add(this.rdbPapas);
            this.grbTipoAlimento.Controls.Add(this.rdbRefresco);
            this.grbTipoAlimento.Controls.Add(this.rdbHamburguesa);
            this.grbTipoAlimento.ForeColor = System.Drawing.Color.Yellow;
            this.grbTipoAlimento.Location = new System.Drawing.Point(23, 21);
            this.grbTipoAlimento.Name = "grbTipoAlimento";
            this.grbTipoAlimento.Size = new System.Drawing.Size(122, 113);
            this.grbTipoAlimento.TabIndex = 0;
            this.grbTipoAlimento.TabStop = false;
            this.grbTipoAlimento.Text = "Elija un alimento";
            // 
            // rdbPayManzana
            // 
            this.rdbPayManzana.AutoSize = true;
            this.rdbPayManzana.Location = new System.Drawing.Point(6, 87);
            this.rdbPayManzana.Name = "rdbPayManzana";
            this.rdbPayManzana.Size = new System.Drawing.Size(104, 17);
            this.rdbPayManzana.TabIndex = 3;
            this.rdbPayManzana.Text = "Pay de manzana";
            this.rdbPayManzana.UseVisualStyleBackColor = true;
            this.rdbPayManzana.CheckedChanged += new System.EventHandler(this.rdbPayManzana_CheckedChanged);
            // 
            // rdbPapas
            // 
            this.rdbPapas.AutoSize = true;
            this.rdbPapas.Location = new System.Drawing.Point(3, 41);
            this.rdbPapas.Name = "rdbPapas";
            this.rdbPapas.Size = new System.Drawing.Size(80, 17);
            this.rdbPapas.TabIndex = 2;
            this.rdbPapas.Text = "Papas fritas";
            this.rdbPapas.UseVisualStyleBackColor = true;
            this.rdbPapas.CheckedChanged += new System.EventHandler(this.rdbPapas_CheckedChanged);
            // 
            // rdbRefresco
            // 
            this.rdbRefresco.AutoSize = true;
            this.rdbRefresco.Location = new System.Drawing.Point(3, 64);
            this.rdbRefresco.Name = "rdbRefresco";
            this.rdbRefresco.Size = new System.Drawing.Size(68, 17);
            this.rdbRefresco.TabIndex = 1;
            this.rdbRefresco.Text = "Refresco";
            this.rdbRefresco.UseVisualStyleBackColor = true;
            this.rdbRefresco.CheckedChanged += new System.EventHandler(this.rdbRefresco_CheckedChanged);
            // 
            // rdbHamburguesa
            // 
            this.rdbHamburguesa.AutoSize = true;
            this.rdbHamburguesa.Checked = true;
            this.rdbHamburguesa.Location = new System.Drawing.Point(3, 16);
            this.rdbHamburguesa.Name = "rdbHamburguesa";
            this.rdbHamburguesa.Size = new System.Drawing.Size(91, 17);
            this.rdbHamburguesa.TabIndex = 0;
            this.rdbHamburguesa.TabStop = true;
            this.rdbHamburguesa.Text = "Hamburguesa";
            this.rdbHamburguesa.UseVisualStyleBackColor = true;
            this.rdbHamburguesa.CheckedChanged += new System.EventHandler(this.rdbHamburguesa_CheckedChanged);
            // 
            // cmbTHamburguesa
            // 
            this.cmbTHamburguesa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbTHamburguesa.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTHamburguesa.ForeColor = System.Drawing.Color.Gold;
            this.cmbTHamburguesa.FormattingEnabled = true;
            this.cmbTHamburguesa.Items.AddRange(new object[] {
            "Sencilla",
            "Doble con queso",
            "Con champiñones",
            "Con jalapeños"});
            this.cmbTHamburguesa.Location = new System.Drawing.Point(154, 48);
            this.cmbTHamburguesa.Name = "cmbTHamburguesa";
            this.cmbTHamburguesa.Size = new System.Drawing.Size(121, 21);
            this.cmbTHamburguesa.TabIndex = 1;
            this.cmbTHamburguesa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija un tipo de hamburguesa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(153, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(153, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(153, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(18, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "champiñones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(18, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "jalapeños";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "queso";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(325, 273);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(157, 42);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar metodo preparacion ";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(174, 273);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(136, 42);
            this.btnCapturar.TabIndex = 10;
            this.btnCapturar.Text = "capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnSAlir
            // 
            this.btnSAlir.Location = new System.Drawing.Point(587, 335);
            this.btnSAlir.Name = "btnSAlir";
            this.btnSAlir.Size = new System.Drawing.Size(75, 42);
            this.btnSAlir.TabIndex = 11;
            this.btnSAlir.Text = "salir";
            this.btnSAlir.UseVisualStyleBackColor = true;
            this.btnSAlir.Click += new System.EventHandler(this.btnSAlir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txtNombre.Location = new System.Drawing.Point(211, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtcategoria
            // 
            this.txtcategoria.BackColor = System.Drawing.Color.SeaShell;
            this.txtcategoria.Location = new System.Drawing.Point(210, 173);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.SeaShell;
            this.txtPrecio.Location = new System.Drawing.Point(211, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtQueso
            // 
            this.txtQueso.Location = new System.Drawing.Point(94, 18);
            this.txtQueso.Name = "txtQueso";
            this.txtQueso.Size = new System.Drawing.Size(100, 20);
            this.txtQueso.TabIndex = 15;
            // 
            // txtJalapenos
            // 
            this.txtJalapenos.Location = new System.Drawing.Point(94, 101);
            this.txtJalapenos.Name = "txtJalapenos";
            this.txtJalapenos.Size = new System.Drawing.Size(100, 20);
            this.txtJalapenos.TabIndex = 16;
            // 
            // txtChampinones
            // 
            this.txtChampinones.Location = new System.Drawing.Point(94, 63);
            this.txtChampinones.Name = "txtChampinones";
            this.txtChampinones.Size = new System.Drawing.Size(100, 20);
            this.txtChampinones.TabIndex = 17;
            // 
            // grbDatosHamburguesa
            // 
            this.grbDatosHamburguesa.BackColor = System.Drawing.Color.Crimson;
            this.grbDatosHamburguesa.Controls.Add(this.txtCarne);
            this.grbDatosHamburguesa.Controls.Add(this.label8);
            this.grbDatosHamburguesa.Controls.Add(this.txtJalapenos);
            this.grbDatosHamburguesa.Controls.Add(this.txtChampinones);
            this.grbDatosHamburguesa.Controls.Add(this.label7);
            this.grbDatosHamburguesa.Controls.Add(this.label6);
            this.grbDatosHamburguesa.Controls.Add(this.txtQueso);
            this.grbDatosHamburguesa.Controls.Add(this.label5);
            this.grbDatosHamburguesa.ForeColor = System.Drawing.Color.Yellow;
            this.grbDatosHamburguesa.Location = new System.Drawing.Point(349, 72);
            this.grbDatosHamburguesa.Name = "grbDatosHamburguesa";
            this.grbDatosHamburguesa.Size = new System.Drawing.Size(248, 195);
            this.grbDatosHamburguesa.TabIndex = 18;
            this.grbDatosHamburguesa.TabStop = false;
            this.grbDatosHamburguesa.Text = "Datos de la Hamburguesa";
            this.grbDatosHamburguesa.Enter += new System.EventHandler(this.grbDatosHamburguesa_Enter);
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(94, 137);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(100, 20);
            this.txtCarne.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(18, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carne";
            // 
            // txtHielo
            // 
            this.txtHielo.BackColor = System.Drawing.Color.SeaShell;
            this.txtHielo.Enabled = false;
            this.txtHielo.Location = new System.Drawing.Point(208, 209);
            this.txtHielo.Name = "txtHielo";
            this.txtHielo.Size = new System.Drawing.Size(100, 20);
            this.txtHielo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(151, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "hielo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 378);
            this.Controls.Add(this.txtHielo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grbDatosHamburguesa);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSAlir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTHamburguesa);
            this.Controls.Add(this.grbTipoAlimento);
            this.Name = "Form1";
            this.Text = "Mc Donalds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTipoAlimento.ResumeLayout(false);
            this.grbTipoAlimento.PerformLayout();
            this.grbDatosHamburguesa.ResumeLayout(false);
            this.grbDatosHamburguesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoAlimento;
        private System.Windows.Forms.RadioButton rdbPayManzana;
        private System.Windows.Forms.RadioButton rdbPapas;
        private System.Windows.Forms.RadioButton rdbRefresco;
        private System.Windows.Forms.RadioButton rdbHamburguesa;
        private System.Windows.Forms.ComboBox cmbTHamburguesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnSAlir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtQueso;
        private System.Windows.Forms.TextBox txtJalapenos;
        private System.Windows.Forms.TextBox txtChampinones;
        private System.Windows.Forms.GroupBox grbDatosHamburguesa;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHielo;
        private System.Windows.Forms.Label label9;
    }
}

