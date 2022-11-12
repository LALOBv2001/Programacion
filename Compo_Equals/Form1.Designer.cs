namespace Compo_Equals
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
            this.components = new System.ComponentModel.Container();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidadDeTeles = new System.Windows.Forms.TextBox();
            this.txtPrecioCuarto = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.dtmFechaConstruccion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblhora.Location = new System.Drawing.Point(565, 45);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(35, 13);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "label1";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMes.Location = new System.Drawing.Point(565, 80);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(35, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "label2";
            this.lblMes.Click += new System.EventHandler(this.lblMes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(9, 16);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Posee abanicos?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de Tvs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio de construccion del cuarto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCantidadDeTeles
            // 
            this.txtCantidadDeTeles.Location = new System.Drawing.Point(100, 46);
            this.txtCantidadDeTeles.Name = "txtCantidadDeTeles";
            this.txtCantidadDeTeles.Size = new System.Drawing.Size(44, 20);
            this.txtCantidadDeTeles.TabIndex = 8;
            this.txtCantidadDeTeles.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrecioCuarto
            // 
            this.txtPrecioCuarto.Location = new System.Drawing.Point(181, 122);
            this.txtPrecioCuarto.Name = "txtPrecioCuarto";
            this.txtPrecioCuarto.Size = new System.Drawing.Size(119, 20);
            this.txtPrecioCuarto.TabIndex = 9;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(441, 31);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 40);
            this.btnCapturar.TabIndex = 11;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(441, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar objeto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Checked = true;
            this.rdbSi.Location = new System.Drawing.Point(123, 83);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(36, 17);
            this.rdbSi.TabIndex = 13;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Sí";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(175, 83);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 14;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // dtmFechaConstruccion
            // 
            this.dtmFechaConstruccion.Location = new System.Drawing.Point(181, 165);
            this.dtmFechaConstruccion.Name = "dtmFechaConstruccion";
            this.dtmFechaConstruccion.Size = new System.Drawing.Size(190, 20);
            this.dtmFechaConstruccion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de construccion del cuarto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(11, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 144);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad Tvs";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "¿Posee abanicos?";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.rdbNo);
            this.grbDatos.Controls.Add(this.dtmFechaConstruccion);
            this.grbDatos.Controls.Add(this.rdbSi);
            this.grbDatos.Controls.Add(this.txtPrecioCuarto);
            this.grbDatos.Controls.Add(this.txtCantidadDeTeles);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.Nombre);
            this.grbDatos.Location = new System.Drawing.Point(28, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(387, 213);
            this.grbDatos.TabIndex = 18;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del cuarto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblhora);
            this.Name = "Form1";
            this.Text = "Eskeler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidadDeTeles;
        private System.Windows.Forms.TextBox txtPrecioCuarto;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.DateTimePicker dtmFechaConstruccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox grbDatos;
    }
}

