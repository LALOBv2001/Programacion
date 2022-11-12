namespace PolimorfismoParametrico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTransferenciaElectronica = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPagar = new System.Windows.Forms.TextBox();
            this.txtClaveInterbancaria = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.grbPagar = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grbPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(108, 111);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(170, 20);
            this.txtRFC.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTransferenciaElectronica);
            this.groupBox1.Controls.Add(this.rdbTarjeta);
            this.groupBox1.Controls.Add(this.rdbEfectivo);
            this.groupBox1.Location = new System.Drawing.Point(41, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pago";
            // 
            // rdbTransferenciaElectronica
            // 
            this.rdbTransferenciaElectronica.AutoSize = true;
            this.rdbTransferenciaElectronica.Location = new System.Drawing.Point(171, 16);
            this.rdbTransferenciaElectronica.Name = "rdbTransferenciaElectronica";
            this.rdbTransferenciaElectronica.Size = new System.Drawing.Size(145, 17);
            this.rdbTransferenciaElectronica.TabIndex = 2;
            this.rdbTransferenciaElectronica.Text = "Transferencia electronica";
            this.rdbTransferenciaElectronica.UseVisualStyleBackColor = true;
            this.rdbTransferenciaElectronica.CheckedChanged += new System.EventHandler(this.rdbTransferenciaElectronica_CheckedChanged);
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(87, 16);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbTarjeta.TabIndex = 1;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            this.rdbTarjeta.CheckedChanged += new System.EventHandler(this.rdbTarjeta_CheckedChanged);
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Checked = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(3, 16);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 0;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            this.rdbEfectivo.CheckedChanged += new System.EventHandler(this.rdbEfectivo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad a pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave interbancaria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CCV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Num. de tarjeta";
            // 
            // txtCPagar
            // 
            this.txtCPagar.Location = new System.Drawing.Point(152, 18);
            this.txtCPagar.Name = "txtCPagar";
            this.txtCPagar.Size = new System.Drawing.Size(126, 20);
            this.txtCPagar.TabIndex = 11;
            // 
            // txtClaveInterbancaria
            // 
            this.txtClaveInterbancaria.Location = new System.Drawing.Point(152, 132);
            this.txtClaveInterbancaria.Name = "txtClaveInterbancaria";
            this.txtClaveInterbancaria.Size = new System.Drawing.Size(126, 20);
            this.txtClaveInterbancaria.TabIndex = 12;
            // 
            // txtCCV
            // 
            this.txtCCV.Location = new System.Drawing.Point(152, 92);
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(126, 20);
            this.txtCCV.TabIndex = 13;
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Location = new System.Drawing.Point(152, 59);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(126, 20);
            this.txtNumTarjeta.TabIndex = 14;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(328, 240);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(86, 95);
            this.btnPagar.TabIndex = 15;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // grbPagar
            // 
            this.grbPagar.Controls.Add(this.txtClaveInterbancaria);
            this.grbPagar.Controls.Add(this.label4);
            this.grbPagar.Controls.Add(this.txtNumTarjeta);
            this.grbPagar.Controls.Add(this.label5);
            this.grbPagar.Controls.Add(this.txtCCV);
            this.grbPagar.Controls.Add(this.label6);
            this.grbPagar.Controls.Add(this.label7);
            this.grbPagar.Controls.Add(this.txtCPagar);
            this.grbPagar.Location = new System.Drawing.Point(12, 209);
            this.grbPagar.Name = "grbPagar";
            this.grbPagar.Size = new System.Drawing.Size(298, 158);
            this.grbPagar.TabIndex = 16;
            this.grbPagar.TabStop = false;
            this.grbPagar.Text = "Forma de pago";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 379);
            this.Controls.Add(this.grbPagar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Forma de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbPagar.ResumeLayout(false);
            this.grbPagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTransferenciaElectronica;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCPagar;
        private System.Windows.Forms.TextBox txtClaveInterbancaria;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox grbPagar;
    }
}

