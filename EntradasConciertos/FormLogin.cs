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
            leerListaUsuarios();
            //ArrayList credenciales = new ArrayList();
            //credenciales.Add(new Usuario("Rickard", "northremembers", true));
            //credenciales.Add(new Usuario("","",false));
            int posUsuario = findUser(campoUsuario.Text);
            if (posUsuario != -1)
            {
                Usuario u = (Usuario)listaUsuarios[posUsuario];
                if (campoClave.Text == u.clave)
                {
                    labelWrongLogin.Visible = false;
                    if (u.empleado)
                    {
                        
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    labelWrongLogin.Visible = true;
                    campoUsuario.Text = "";
                    campoClave.Text = "";
                }
            }
            else
            {
                labelWrongLogin.Visible = true;
                campoUsuario.Text = "";
                campoClave.Text = "";
            }
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VentanaSignup().Show();
        }
    }
}
