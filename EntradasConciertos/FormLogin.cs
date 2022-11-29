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
            labelNumUsuariosReg.Text += Convert.ToString(ContarUsuarios());
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
            }
            else
            {
                if (campoClave.Text == u.clave)
                {
                    labelWrongLogin.Visible = false;
					if (u.empleado)
                    {
                        new ListaConciertosEmpleado().Show();
                        this.Hide();
                    }
                    else
                    {
                        new ListaConciertosCliente().Show();
                        this.Hide();
                    }
                }
                else
                {
                    labelWrongLogin.Visible = true;
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
