namespace ListaGenericaDeEmpleados
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
            this.grbDatosEmpleados = new System.Windows.Forms.GroupBox();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosEmpleados
            // 
            this.grbDatosEmpleados.Controls.Add(this.btnBorrarEmpleado);
            this.grbDatosEmpleados.Controls.Add(this.btnSalir);
            this.grbDatosEmpleados.Controls.Add(this.btnInsertar);
            this.grbDatosEmpleados.Controls.Add(this.txtSueldo);
            this.grbDatosEmpleados.Controls.Add(this.txtNombre);
            this.grbDatosEmpleados.Controls.Add(this.txtNumero);
            this.grbDatosEmpleados.Controls.Add(this.label3);
            this.grbDatosEmpleados.Controls.Add(this.Nombre);
            this.grbDatosEmpleados.Controls.Add(this.Numero);
            this.grbDatosEmpleados.Location = new System.Drawing.Point(12, 12);
            this.grbDatosEmpleados.Name = "grbDatosEmpleados";
            this.grbDatosEmpleados.Size = new System.Drawing.Size(405, 153);
            this.grbDatosEmpleados.TabIndex = 0;
            this.grbDatosEmpleados.TabStop = false;
            this.grbDatosEmpleados.Text = "Datos de los empleados";
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(296, 54);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(82, 34);
            this.btnBorrarEmpleado.TabIndex = 8;
            this.btnBorrarEmpleado.Text = "Borrar empleado";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = true;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(296, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(296, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(83, 33);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(61, 97);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(51, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(65, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(15, 65);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(15, 32);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 0;
            this.Numero.Text = "Numero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumero,
            this.ColumnNombre,
            this.ColumnSueldo});
            this.dataGridView1.Location = new System.Drawing.Point(48, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 110);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // 
            // ColumnSueldo
            // 
            this.ColumnSueldo.HeaderText = "Sueldo";
            this.ColumnSueldo.Name = "ColumnSueldo";
            this.ColumnSueldo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbDatosEmpleados);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosEmpleados.ResumeLayout(false);
            this.grbDatosEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosEmpleados;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSueldo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarEmpleado;
    }
}

