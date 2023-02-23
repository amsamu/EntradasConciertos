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

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarAplicacion();
        }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                botonEntrar.PerformClick();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
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
					if (u.esEmpleado)
                    {
                        new ListaConciertosEmpleado().Show();
                        this.Close();
                    }
                    else
                    {
                        new ListaConciertosCliente().Show();
                        this.Close();
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
            new VentanaSignup().Show();
            this.Close();
        }
    }
}
