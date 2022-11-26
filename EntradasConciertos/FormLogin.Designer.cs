namespace EntradasConciertos
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.botonRegistrarse = new System.Windows.Forms.Button();
            this.labelWrongLogin = new System.Windows.Forms.Label();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.fondoLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelLogin.Controls.Add(this.botonRegistrarse);
            this.panelLogin.Controls.Add(this.labelWrongLogin);
            this.panelLogin.Controls.Add(this.botonEntrar);
            this.panelLogin.Controls.Add(this.campoUsuario);
            this.panelLogin.Controls.Add(this.campoClave);
            this.panelLogin.Controls.Add(this.labelClave);
            this.panelLogin.Controls.Add(this.labelUsuario);
            this.panelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.ForeColor = System.Drawing.Color.Snow;
            this.panelLogin.Location = new System.Drawing.Point(235, 116);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(335, 196);
            this.panelLogin.TabIndex = 5;
            // 
            // botonRegistrarse
            // 
            this.botonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonRegistrarse.Location = new System.Drawing.Point(156, 152);
            this.botonRegistrarse.Name = "botonRegistrarse";
            this.botonRegistrarse.Size = new System.Drawing.Size(119, 31);
            this.botonRegistrarse.TabIndex = 4;
            this.botonRegistrarse.Text = "Crear cuenta";
            this.botonRegistrarse.UseVisualStyleBackColor = true;
            this.botonRegistrarse.Click += new System.EventHandler(this.botonRegistrarse_Click);
            // 
            // labelWrongLogin
            // 
            this.labelWrongLogin.AutoSize = true;
            this.labelWrongLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongLogin.ForeColor = System.Drawing.Color.Red;
            this.labelWrongLogin.Location = new System.Drawing.Point(46, 125);
            this.labelWrongLogin.Name = "labelWrongLogin";
            this.labelWrongLogin.Size = new System.Drawing.Size(229, 15);
            this.labelWrongLogin.TabIndex = 8;
            this.labelWrongLogin.Text = "Usuario y/o contraseña incorrectos";
            this.labelWrongLogin.Visible = false;
            // 
            // botonEntrar
            // 
            this.botonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonEntrar.Location = new System.Drawing.Point(40, 152);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(90, 31);
            this.botonEntrar.TabIndex = 3;
            this.botonEntrar.Text = "Entrar";
            this.botonEntrar.UseVisualStyleBackColor = true;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // campoUsuario
            // 
            this.campoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsuario.Location = new System.Drawing.Point(144, 43);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(131, 24);
            this.campoUsuario.TabIndex = 1;
            // 
            // campoClave
            // 
            this.campoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoClave.Location = new System.Drawing.Point(144, 89);
            this.campoClave.Name = "campoClave";
            this.campoClave.PasswordChar = '●';
            this.campoClave.Size = new System.Drawing.Size(131, 24);
            this.campoClave.TabIndex = 2;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.ForeColor = System.Drawing.Color.Snow;
            this.labelClave.Location = new System.Drawing.Point(37, 92);
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
            this.labelUsuario.Location = new System.Drawing.Point(37, 49);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(60, 18);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
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
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.fondoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
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
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.Label labelWrongLogin;
        private System.Windows.Forms.Button botonRegistrarse;
    }
}

