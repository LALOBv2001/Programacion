namespace Tarea3._4
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
            this.grbDatosEstante = new System.Windows.Forms.GroupBox();
            this.grbDatosEstuche = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtNumeroRepisas = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadDiscos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnTotalDiscos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMayores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosEstante.SuspendLayout();
            this.grbDatosEstuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosEstante
            // 
            this.grbDatosEstante.Controls.Add(this.label2);
            this.grbDatosEstante.Controls.Add(this.label1);
            this.grbDatosEstante.Controls.Add(this.btnInsertar);
            this.grbDatosEstante.Controls.Add(this.txtNumeroRepisas);
            this.grbDatosEstante.Controls.Add(this.txtColor);
            this.grbDatosEstante.Location = new System.Drawing.Point(51, 44);
            this.grbDatosEstante.Name = "grbDatosEstante";
            this.grbDatosEstante.Size = new System.Drawing.Size(338, 98);
            this.grbDatosEstante.TabIndex = 0;
            this.grbDatosEstante.TabStop = false;
            this.grbDatosEstante.Text = "Datos del estante";
            // 
            // grbDatosEstuche
            // 
            this.grbDatosEstuche.Controls.Add(this.btnCapturar);
            this.grbDatosEstuche.Controls.Add(this.txtNombre);
            this.grbDatosEstuche.Controls.Add(this.txtCantidadDiscos);
            this.grbDatosEstuche.Controls.Add(this.txtPrecio);
            this.grbDatosEstuche.Controls.Add(this.radB);
            this.grbDatosEstuche.Controls.Add(this.radC);
            this.grbDatosEstuche.Controls.Add(this.radD);
            this.grbDatosEstuche.Controls.Add(this.radA);
            this.grbDatosEstuche.Controls.Add(this.label6);
            this.grbDatosEstuche.Controls.Add(this.label5);
            this.grbDatosEstuche.Controls.Add(this.label4);
            this.grbDatosEstuche.Controls.Add(this.label3);
            this.grbDatosEstuche.Location = new System.Drawing.Point(51, 158);
            this.grbDatosEstuche.Name = "grbDatosEstuche";
            this.grbDatosEstuche.Size = new System.Drawing.Size(338, 188);
            this.grbDatosEstuche.TabIndex = 1;
            this.grbDatosEstuche.TabStop = false;
            this.grbDatosEstuche.Text = "Datos estuche";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(100, 39);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 0;
            // 
            // txtNumeroRepisas
            // 
            this.txtNumeroRepisas.Location = new System.Drawing.Point(100, 67);
            this.txtNumeroRepisas.Name = "txtNumeroRepisas";
            this.txtNumeroRepisas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroRepisas.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(226, 39);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(76, 44);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. de repisas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de la Pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clasificacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad de discos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio";
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Checked = true;
            this.radA.Location = new System.Drawing.Point(22, 154);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(32, 17);
            this.radA.TabIndex = 8;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(168, 154);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(33, 17);
            this.radD.TabIndex = 9;
            this.radD.TabStop = true;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(113, 154);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(32, 17);
            this.radC.TabIndex = 10;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(62, 154);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(32, 17);
            this.radB.TabIndex = 11;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(135, 59);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtCantidadDiscos
            // 
            this.txtCantidadDiscos.Location = new System.Drawing.Point(135, 92);
            this.txtCantidadDiscos.Name = "txtCantidadDiscos";
            this.txtCantidadDiscos.Size = new System.Drawing.Size(50, 20);
            this.txtCantidadDiscos.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(242, 107);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 44);
            this.btnCapturar.TabIndex = 15;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnTotalDiscos
            // 
            this.btnTotalDiscos.Location = new System.Drawing.Point(420, 223);
            this.btnTotalDiscos.Name = "btnTotalDiscos";
            this.btnTotalDiscos.Size = new System.Drawing.Size(92, 71);
            this.btnTotalDiscos.TabIndex = 2;
            this.btnTotalDiscos.Text = "Total de discos";
            this.btnTotalDiscos.UseVisualStyleBackColor = true;
            this.btnTotalDiscos.Click += new System.EventHandler(this.btnTotalDiscos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnPrecio,
            this.ColumnClasificacion,
            this.ColumnDiscos,
            this.ColumnMayores});
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 141);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(428, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 130;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnClasificacion
            // 
            this.ColumnClasificacion.HeaderText = "Clasificacion";
            this.ColumnClasificacion.Name = "ColumnClasificacion";
            this.ColumnClasificacion.ReadOnly = true;
            // 
            // ColumnDiscos
            // 
            this.ColumnDiscos.HeaderText = "Cantidad de Discos";
            this.ColumnDiscos.Name = "ColumnDiscos";
            this.ColumnDiscos.ReadOnly = true;
            // 
            // ColumnMayores
            // 
            this.ColumnMayores.HeaderText = "¿Es para mayores de edad?";
            this.ColumnMayores.Name = "ColumnMayores";
            this.ColumnMayores.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 564);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTotalDiscos);
            this.Controls.Add(this.grbDatosEstuche);
            this.Controls.Add(this.grbDatosEstante);
            this.Name = "Form1";
            this.Text = "Pelicula";
            this.grbDatosEstante.ResumeLayout(false);
            this.grbDatosEstante.PerformLayout();
            this.grbDatosEstuche.ResumeLayout(false);
            this.grbDatosEstuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosEstante;
        private System.Windows.Forms.GroupBox grbDatosEstuche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNumeroRepisas;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidadDiscos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTotalDiscos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMayores;
    }
}

