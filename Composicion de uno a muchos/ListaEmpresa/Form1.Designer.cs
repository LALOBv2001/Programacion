namespace ListaEmpresa
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
            this.grbDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.grbDatosDepartamento = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosEmpresa.SuspendLayout();
            this.grbDatosDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosEmpresa
            // 
            this.grbDatosEmpresa.Controls.Add(this.btnCapturar);
            this.grbDatosEmpresa.Controls.Add(this.txtGerente);
            this.grbDatosEmpresa.Controls.Add(this.txtRazonSocial);
            this.grbDatosEmpresa.Controls.Add(this.txtRFC);
            this.grbDatosEmpresa.Controls.Add(this.label3);
            this.grbDatosEmpresa.Controls.Add(this.label2);
            this.grbDatosEmpresa.Controls.Add(this.label1);
            this.grbDatosEmpresa.Location = new System.Drawing.Point(21, 34);
            this.grbDatosEmpresa.Name = "grbDatosEmpresa";
            this.grbDatosEmpresa.Size = new System.Drawing.Size(399, 132);
            this.grbDatosEmpresa.TabIndex = 0;
            this.grbDatosEmpresa.TabStop = false;
            this.grbDatosEmpresa.Text = "Datos de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gerente";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(121, 29);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(128, 20);
            this.txtRFC.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(121, 65);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(128, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(121, 100);
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new System.Drawing.Size(128, 20);
            this.txtGerente.TabIndex = 5;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(307, 49);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 36);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // grbDatosDepartamento
            // 
            this.grbDatosDepartamento.Controls.Add(this.btnInsertar);
            this.grbDatosDepartamento.Controls.Add(this.txtJefe);
            this.grbDatosDepartamento.Controls.Add(this.txtNombre);
            this.grbDatosDepartamento.Controls.Add(this.txtNumero);
            this.grbDatosDepartamento.Controls.Add(this.label4);
            this.grbDatosDepartamento.Controls.Add(this.label5);
            this.grbDatosDepartamento.Controls.Add(this.label6);
            this.grbDatosDepartamento.Location = new System.Drawing.Point(21, 172);
            this.grbDatosDepartamento.Name = "grbDatosDepartamento";
            this.grbDatosDepartamento.Size = new System.Drawing.Size(399, 132);
            this.grbDatosDepartamento.TabIndex = 1;
            this.grbDatosDepartamento.TabStop = false;
            this.grbDatosDepartamento.Text = "Datos del departamento";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(307, 49);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 36);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(121, 100);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(128, 20);
            this.txtJefe.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(121, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(43, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jefe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumero,
            this.ColumnNombre,
            this.ColumnJefe});
            this.dataGridView1.Location = new System.Drawing.Point(13, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 128);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Numero";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 150;
            // 
            // ColumnJefe
            // 
            this.ColumnJefe.HeaderText = "Jefe";
            this.ColumnJefe.Name = "ColumnJefe";
            this.ColumnJefe.ReadOnly = true;
            this.ColumnJefe.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbDatosDepartamento);
            this.Controls.Add(this.grbDatosEmpresa);
            this.Name = "Form1";
            this.Text = "Empresa";
            this.grbDatosEmpresa.ResumeLayout(false);
            this.grbDatosEmpresa.PerformLayout();
            this.grbDatosDepartamento.ResumeLayout(false);
            this.grbDatosDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosEmpresa;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtGerente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDatosDepartamento;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJefe;
    }
}

