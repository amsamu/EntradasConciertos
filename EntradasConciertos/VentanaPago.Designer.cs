namespace EntradasConciertos
{
    partial class VentanaPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPago = new System.Windows.Forms.Panel();
            this.campoCVV = new System.Windows.Forms.TextBox();
            this.campoFechaCaducidad = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.campoContrasena = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSeparador = new System.Windows.Forms.Label();
            this.botonConfirmarPago = new System.Windows.Forms.Button();
            this.labelEligeMetodoPago = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.campoNumTarjeta = new System.Windows.Forms.TextBox();
            this.labelNumTarjeta = new System.Windows.Forms.Label();
            this.labelFechaCaducidad = new System.Windows.Forms.Label();
            this.panelOpcionesPago = new System.Windows.Forms.Panel();
            this.opcionPayPal = new System.Windows.Forms.RadioButton();
            this.opcionTarjeta = new System.Windows.Forms.RadioButton();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPago.SuspendLayout();
            this.panelOpcionesPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntradasConciertos.Properties.Resources.Imagine_Dragons_1200x799;
            this.pictureBox1.Location = new System.Drawing.Point(-59, -103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPago
            // 
            this.panelPago.BackColor = System.Drawing.Color.Black;
            this.panelPago.Controls.Add(this.campoCVV);
            this.panelPago.Controls.Add(this.campoFechaCaducidad);
            this.panelPago.Controls.Add(this.labelCVV);
            this.panelPago.Controls.Add(this.campoContrasena);
            this.panelPago.Controls.Add(this.labelEmail);
            this.panelPago.Controls.Add(this.labelSeparador);
            this.panelPago.Controls.Add(this.botonConfirmarPago);
            this.panelPago.Controls.Add(this.labelEligeMetodoPago);
            this.panelPago.Controls.Add(this.labelContrasena);
            this.panelPago.Controls.Add(this.campoNumTarjeta);
            this.panelPago.Controls.Add(this.labelNumTarjeta);
            this.panelPago.Controls.Add(this.labelFechaCaducidad);
            this.panelPago.Controls.Add(this.panelOpcionesPago);
            this.panelPago.Controls.Add(this.campoEmail);
            this.panelPago.Location = new System.Drawing.Point(153, 20);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(516, 382);
            this.panelPago.TabIndex = 2;
            // 
            // campoCVV
            // 
            this.campoCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCVV.Location = new System.Drawing.Point(179, 265);
            this.campoCVV.MaxLength = 3;
            this.campoCVV.Name = "campoCVV";
            this.campoCVV.Size = new System.Drawing.Size(79, 26);
            this.campoCVV.TabIndex = 33;
            this.campoCVV.Visible = false;
            this.campoCVV.TextChanged += new System.EventHandler(this.campoCVV_TextChanged);
            // 
            // campoFechaCaducidad
            // 
            this.campoFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaCaducidad.Location = new System.Drawing.Point(179, 223);
            this.campoFechaCaducidad.MaxLength = 5;
            this.campoFechaCaducidad.Name = "campoFechaCaducidad";
            this.campoFechaCaducidad.Size = new System.Drawing.Size(79, 26);
            this.campoFechaCaducidad.TabIndex = 32;
            this.campoFechaCaducidad.Visible = false;
            this.campoFechaCaducidad.TextChanged += new System.EventHandler(this.campoFechaCaducidad_TextChanged);
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCVV.Location = new System.Drawing.Point(123, 268);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(42, 20);
            this.labelCVV.TabIndex = 30;
            this.labelCVV.Text = "CVV";
            this.labelCVV.Visible = false;
            // 
            // campoContrasena
            // 
            this.campoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoContrasena.Location = new System.Drawing.Point(179, 223);
            this.campoContrasena.Name = "campoContrasena";
            this.campoContrasena.PasswordChar = '●';
            this.campoContrasena.Size = new System.Drawing.Size(212, 26);
            this.campoContrasena.TabIndex = 26;
            this.campoContrasena.Visible = false;
            this.campoContrasena.TextChanged += new System.EventHandler(this.campoContrasena_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Location = new System.Drawing.Point(117, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "Email";
            this.labelEmail.Visible = false;
            // 
            // labelSeparador
            // 
            this.labelSeparador.BackColor = System.Drawing.SystemColors.Control;
            this.labelSeparador.Location = new System.Drawing.Point(101, 144);
            this.labelSeparador.Name = "labelSeparador";
            this.labelSeparador.Size = new System.Drawing.Size(300, 1);
            this.labelSeparador.TabIndex = 18;
            // 
            // botonConfirmarPago
            // 
            this.botonConfirmarPago.Enabled = false;
            this.botonConfirmarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarPago.Location = new System.Drawing.Point(179, 314);
            this.botonConfirmarPago.Name = "botonConfirmarPago";
            this.botonConfirmarPago.Size = new System.Drawing.Size(147, 36);
            this.botonConfirmarPago.TabIndex = 11;
            this.botonConfirmarPago.Text = "Confirmar pago";
            this.botonConfirmarPago.UseVisualStyleBackColor = true;
            this.botonConfirmarPago.Click += new System.EventHandler(this.botonConfirmarPago_Click);
            // 
            // labelEligeMetodoPago
            // 
            this.labelEligeMetodoPago.AutoSize = true;
            this.labelEligeMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEligeMetodoPago.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEligeMetodoPago.Location = new System.Drawing.Point(100, 35);
            this.labelEligeMetodoPago.Name = "labelEligeMetodoPago";
            this.labelEligeMetodoPago.Size = new System.Drawing.Size(190, 20);
            this.labelEligeMetodoPago.TabIndex = 10;
            this.labelEligeMetodoPago.Text = "Elige un método de pago:";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContrasena.Location = new System.Drawing.Point(73, 226);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(92, 20);
            this.labelContrasena.TabIndex = 27;
            this.labelContrasena.Text = "Contraseña";
            this.labelContrasena.Visible = false;
            // 
            // campoNumTarjeta
            // 
            this.campoNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNumTarjeta.Location = new System.Drawing.Point(179, 176);
            this.campoNumTarjeta.MaxLength = 19;
            this.campoNumTarjeta.Name = "campoNumTarjeta";
            this.campoNumTarjeta.Size = new System.Drawing.Size(212, 26);
            this.campoNumTarjeta.TabIndex = 31;
            this.campoNumTarjeta.Visible = false;
            this.campoNumTarjeta.TextChanged += new System.EventHandler(this.campoNumTarjeta_TextChanged);
            // 
            // labelNumTarjeta
            // 
            this.labelNumTarjeta.AutoSize = true;
            this.labelNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTarjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumTarjeta.Location = new System.Drawing.Point(90, 179);
            this.labelNumTarjeta.Name = "labelNumTarjeta";
            this.labelNumTarjeta.Size = new System.Drawing.Size(75, 20);
            this.labelNumTarjeta.TabIndex = 28;
            this.labelNumTarjeta.Text = "Nº tarjeta";
            this.labelNumTarjeta.Visible = false;
            // 
            // labelFechaCaducidad
            // 
            this.labelFechaCaducidad.AutoSize = true;
            this.labelFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCaducidad.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFechaCaducidad.Location = new System.Drawing.Point(34, 226);
            this.labelFechaCaducidad.Name = "labelFechaCaducidad";
            this.labelFechaCaducidad.Size = new System.Drawing.Size(131, 20);
            this.labelFechaCaducidad.TabIndex = 29;
            this.labelFechaCaducidad.Text = "Fecha caducidad";
            this.labelFechaCaducidad.Visible = false;
            // 
            // panelOpcionesPago
            // 
            this.panelOpcionesPago.Controls.Add(this.opcionPayPal);
            this.panelOpcionesPago.Controls.Add(this.opcionTarjeta);
            this.panelOpcionesPago.Location = new System.Drawing.Point(105, 58);
            this.panelOpcionesPago.Name = "panelOpcionesPago";
            this.panelOpcionesPago.Size = new System.Drawing.Size(286, 83);
            this.panelOpcionesPago.TabIndex = 34;
            // 
            // opcionPayPal
            // 
            this.opcionPayPal.AutoSize = true;
            this.opcionPayPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionPayPal.ForeColor = System.Drawing.SystemColors.Control;
            this.opcionPayPal.Location = new System.Drawing.Point(16, 49);
            this.opcionPayPal.Name = "opcionPayPal";
            this.opcionPayPal.Size = new System.Drawing.Size(75, 24);
            this.opcionPayPal.TabIndex = 25;
            this.opcionPayPal.TabStop = true;
            this.opcionPayPal.Text = "PayPal";
            this.opcionPayPal.UseVisualStyleBackColor = true;
            this.opcionPayPal.CheckedChanged += new System.EventHandler(this.opcionPayPal_CheckedChanged);
            // 
            // opcionTarjeta
            // 
            this.opcionTarjeta.AutoSize = true;
            this.opcionTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionTarjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.opcionTarjeta.Location = new System.Drawing.Point(16, 14);
            this.opcionTarjeta.Name = "opcionTarjeta";
            this.opcionTarjeta.Size = new System.Drawing.Size(198, 24);
            this.opcionTarjeta.TabIndex = 24;
            this.opcionTarjeta.TabStop = true;
            this.opcionTarjeta.Text = "Tarjeta de débito/crédito";
            this.opcionTarjeta.UseVisualStyleBackColor = true;
            this.opcionTarjeta.CheckedChanged += new System.EventHandler(this.opcionTarjeta_CheckedChanged);
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(179, 176);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(212, 26);
            this.campoEmail.TabIndex = 24;
            this.campoEmail.Visible = false;
            this.campoEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(697, 20);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(91, 31);
            this.botonVolver.TabIndex = 6;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // VentanaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "VentanaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trámite de pago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaPago_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            this.panelOpcionesPago.ResumeLayout(false);
            this.panelOpcionesPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label labelSeparador;
        private System.Windows.Forms.Button botonConfirmarPago;
        private System.Windows.Forms.Label labelEligeMetodoPago;
        private System.Windows.Forms.TextBox campoNumTarjeta;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Label labelNumTarjeta;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox campoContrasena;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label labelFechaCaducidad;
        private System.Windows.Forms.TextBox campoCVV;
        private System.Windows.Forms.TextBox campoFechaCaducidad;
        private System.Windows.Forms.Panel panelOpcionesPago;
        private System.Windows.Forms.RadioButton opcionPayPal;
        private System.Windows.Forms.RadioButton opcionTarjeta;
        private System.Windows.Forms.Button botonVolver;
    }
}