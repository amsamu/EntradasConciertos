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
    public partial class VentanaSignup : Form
    {
        public VentanaSignup()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void campoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoConfirmClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (campoUsuario.TextLength == 0 || campoClave.TextLength == 0 || campoConfirmClave.TextLength == 0)
            {
                labelUserAlrExists.Visible = false;
                labelPwDontMatch.Visible = false;
                labelEmptyFields.Visible = true;
            }
            else if (campoClave.Text != campoConfirmClave.Text)
            {
                labelEmptyFields.Visible = false;
                labelUserAlrExists.Visible = false;
                labelPwDontMatch.Visible = true;
            }
            else if (ExisteUsuario(campoUsuario.Text))
            {
                labelEmptyFields.Visible = false;
                labelPwDontMatch.Visible = false;
                labelUserAlrExists.Visible = true;
            }
            else
            {
                anadirUsuario(new Usuario(campoUsuario.Text, campoClave.Text, checkEmpleado.Checked));
                this.Hide();
                new VentanaLogin().Show();
            }

        }
        
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VentanaLogin().Show();
        }
    }
}
