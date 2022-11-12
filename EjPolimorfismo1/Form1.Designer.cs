namespace EjPolimorfismo1
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
            this.grbDatosAuto = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaballosFuerza = new System.Windows.Forms.TextBox();
            this.txtNumLLantas = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtNumPuertas = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grbDatosAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAuto
            // 
            this.grbDatosAuto.Controls.Add(this.txtNumPuertas);
            this.grbDatosAuto.Controls.Add(this.txtVelocidad);
            this.grbDatosAuto.Controls.Add(this.txtNumLLantas);
            this.grbDatosAuto.Controls.Add(this.txtCaballosFuerza);
            this.grbDatosAuto.Controls.Add(this.label4);
            this.grbDatosAuto.Controls.Add(this.label3);
            this.grbDatosAuto.Controls.Add(this.label2);
            this.grbDatosAuto.Controls.Add(this.label1);
            this.grbDatosAuto.Location = new System.Drawing.Point(39, 27);
            this.grbDatosAuto.Name = "grbDatosAuto";
            this.grbDatosAuto.Size = new System.Drawing.Size(196, 135);
            this.grbDatosAuto.TabIndex = 0;
            this.grbDatosAuto.TabStop = false;
            this.grbDatosAuto.Text = "Datos del carro";
            this.grbDatosAuto.Enter += new System.EventHandler(this.grbDatosAuto_Enter);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(257, 43);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(82, 36);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caballos de fuerza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num. de Llantas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de puertas";
            // 
            // txtCaballosFuerza
            // 
            this.txtCaballosFuerza.Location = new System.Drawing.Point(116, 16);
            this.txtCaballosFuerza.Name = "txtCaballosFuerza";
            this.txtCaballosFuerza.Size = new System.Drawing.Size(69, 20);
            this.txtCaballosFuerza.TabIndex = 4;
            // 
            // txtNumLLantas
            // 
            this.txtNumLLantas.Location = new System.Drawing.Point(116, 102);
            this.txtNumLLantas.Name = "txtNumLLantas";
            this.txtNumLLantas.Size = new System.Drawing.Size(27, 20);
            this.txtNumLLantas.TabIndex = 5;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(116, 72);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(52, 20);
            this.txtVelocidad.TabIndex = 6;
            // 
            // txtNumPuertas
            // 
            this.txtNumPuertas.Location = new System.Drawing.Point(116, 44);
            this.txtNumPuertas.Name = "txtNumPuertas";
            this.txtNumPuertas.Size = new System.Drawing.Size(27, 20);
            this.txtNumPuertas.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(257, 157);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(257, 99);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(82, 36);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 199);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.grbDatosAuto);
            this.Name = "Form1";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAuto.ResumeLayout(false);
            this.grbDatosAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAuto;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumPuertas;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtNumLLantas;
        private System.Windows.Forms.TextBox txtCaballosFuerza;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
    }
}

