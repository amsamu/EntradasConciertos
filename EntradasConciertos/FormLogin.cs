using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntradasConciertos.Program;

namespace EntradasConciertos
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {	
			Usuario u = EncontrarUsuario(campoUsuario.Text);
            if (u == null)
            {
                labelWrongLogin.Visible = true;
				campoUsuario.Text = "";
				campoClave.Text = "";
            }
            else
            {
                if (campoClave.Text == u.clave)
                {
                    labelWrongLogin.Visible = false;
                    usuarioActual = u.username;
					if (u.empleado)
                    {
                        
                    }
                    else
                    {
                        new ListaConciertos().Show();
                        this.Hide();
                    }
                }
                else
                {
                    labelWrongLogin.Visible = true;
                    campoUsuario.Text = "";
                    campoClave.Text = "";
                }
            }
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VentanaSignup().Show();
        }
    }
}
