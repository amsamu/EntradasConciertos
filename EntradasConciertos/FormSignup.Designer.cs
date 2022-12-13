namespace EntradasConciertos
{
    partial class VentanaSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaSignup));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.checkEmpleado = new System.Windows.Forms.CheckBox();
            this.campoConfirmClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelUserAlrExists = new System.Windows.Forms.Label();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPwDontMatch = new System.Windows.Forms.Label();
            this.labelEmptyFields = new System.Windows.Forms.Label();
            this.fondoLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelLogin.Controls.Add(this.checkEmpleado);
            this.panelLogin.Controls.Add(this.campoConfirmClave);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.botonCancelar);
            this.panelLogin.Controls.Add(this.labelUserAlrExists);
            this.panelLogin.Controls.Add(this.botonConfirmar);
            this.panelLogin.Controls.Add(this.campoUsuario);
            this.panelLogin.Controls.Add(this.campoClave);
            this.panelLogin.Controls.Add(this.labelClave);
            this.panelLogin.Controls.Add(this.labelUsuario);
            this.panelLogin.Controls.Add(this.labelPwDontMatch);
            this.panelLogin.Controls.Add(this.labelEmptyFields);
            this.panelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.ForeColor = System.Drawing.Color.Snow;
            this.panelLogin.Location = new System.Drawing.Point(255, 50);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(316, 348);
            this.panelLogin.TabIndex = 5;
            // 
            // checkEmpleado
            // 
            this.checkEmpleado.AutoSize = true;
            this.checkEmpleado.Location = new System.Drawing.Point(81, 236);
            this.checkEmpleado.Name = "checkEmpleado";
            this.checkEmpleado.Size = new System.Drawing.Size(191, 22);
            this.checkEmpleado.TabIndex = 4;
            this.checkEmpleado.Text = "Empleado de la empresa";
            this.checkEmpleado.UseVisualStyleBackColor = true;
            // 
            // campoConfirmClave
            // 
            this.campoConfirmClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoConfirmClave.Location = new System.Drawing.Point(81, 195);
            this.campoConfirmClave.Name = "campoConfirmClave";
            this.campoConfirmClave.PasswordChar = '●';
            this.campoConfirmClave.Size = new System.Drawing.Size(149, 24);
            this.campoConfirmClave.TabIndex = 3;
            this.campoConfirmClave.TextChanged += new System.EventHandler(this.campoConfirmClave_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(78, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmar contraseña";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonCancelar.Location = new System.Drawing.Point(183, 294);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(90, 31);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelUserAlrExists
            // 
            this.labelUserAlrExists.AutoSize = true;
            this.labelUserAlrExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAlrExists.ForeColor = System.Drawing.Color.Red;
            this.labelUserAlrExists.Location = new System.Drawing.Point(81, 267);
            this.labelUserAlrExists.Name = "labelUserAlrExists";
            this.labelUserAlrExists.Size = new System.Drawing.Size(147, 15);
            this.labelUserAlrExists.TabIndex = 8;
            this.labelUserAlrExists.Text = "Ese usuario ya existe.";
            this.labelUserAlrExists.Visible = false;
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonConfirmar.Location = new System.Drawing.Point(38, 294);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(90, 31);
            this.botonConfirmar.TabIndex = 5;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // campoUsuario
            // 
            this.campoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsuario.Location = new System.Drawing.Point(81, 50);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(149, 24);
            this.campoUsuario.TabIndex = 1;
            this.campoUsuario.TextChanged += new System.EventHandler(this.campoUsuario_TextChanged);
            // 
            // campoClave
            // 
            this.campoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoClave.Location = new System.Drawing.Point(81, 119);
            this.campoClave.Name = "campoClave";
            this.campoClave.PasswordChar = '●';
            this.campoClave.Size = new System.Drawing.Size(149, 24);
            this.campoClave.TabIndex = 2;
            this.campoClave.TextChanged += new System.EventHandler(this.campoClave_TextChanged);
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.ForeColor = System.Drawing.Color.Snow;
            this.labelClave.Location = new System.Drawing.Point(78, 87);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(85, 18);
            this.labelClave.TabIndex = 1;
            this.labelClave.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Snow;
            this.labelUsuario.Location = new System.Drawing.Point(78, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(60, 18);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelPwDontMatch
            // 
            this.labelPwDontMatch.AutoSize = true;
            this.labelPwDontMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPwDontMatch.ForeColor = System.Drawing.Color.Red;
            this.labelPwDontMatch.Location = new System.Drawing.Point(44, 267);
            this.labelPwDontMatch.Name = "labelPwDontMatch";
            this.labelPwDontMatch.Size = new System.Drawing.Size(198, 15);
            this.labelPwDontMatch.TabIndex = 12;
            this.labelPwDontMatch.Text = "Las contraseñas no coinciden";
            this.labelPwDontMatch.Visible = false;
            // 
            // labelEmptyFields
            // 
            this.labelEmptyFields.AutoSize = true;
            this.labelEmptyFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmptyFields.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyFields.Location = new System.Drawing.Point(44, 267);
            this.labelEmptyFields.Name = "labelEmptyFields";
            this.labelEmptyFields.Size = new System.Drawing.Size(217, 15);
            this.labelEmptyFields.TabIndex = 13;
            this.labelEmptyFields.Text = "Ningún campo puede estar vacío";
            this.labelEmptyFields.Visible = false;
            // 
            // fondoLogin
            // 
            this.fondoLogin.Image = global::EntradasConciertos.Properties.Resources.emotionalroadshow1414x900;
            this.fondoLogin.Location = new System.Drawing.Point(0, -1);
            this.fondoLogin.Name = "fondoLogin";
            this.fondoLogin.Size = new System.Drawing.Size(1000, 636);
            this.fondoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fondoLogin.TabIndex = 0;
            this.fondoLogin.TabStop = false;
            // 
            // VentanaSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.fondoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cuenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaSignup_FormClosed);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fondoLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.TextBox campoClave;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label labelUserAlrExists;
        private System.Windows.Forms.TextBox campoConfirmClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label labelPwDontMatch;
        private System.Windows.Forms.Label labelEmptyFields;
        private System.Windows.Forms.CheckBox checkEmpleado;
    }
}

