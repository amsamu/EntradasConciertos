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
    public partial class VentanaPago : Form
    {
        int indiceConcierto;
        int numEntradas;
        public VentanaPago(int indiceConcierto, int numEntradas)
        {
            InitializeComponent();
            this.indiceConcierto = indiceConcierto;
            this.numEntradas = numEntradas;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void opcionTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            opcionSeleccionada();
        }

        private void opcionPayPal_CheckedChanged(object sender, EventArgs e)
        {
            opcionSeleccionada();
        }

        private void opcionSeleccionada()
        {
            botonConfirmarPago.Enabled = true;
            if (opcionTarjeta.Checked)
            {
                labelEmail.Visible = false;
                labelContrasena.Visible = false;
                campoEmail.Visible = false;
                campoContrasena.Visible = false;

                labelNumTarjeta.Visible = true;
                labelFechaCaducidad.Visible = true;
                labelCVV.Visible = true;
                campoNumTarjeta.Visible = true;
                campoFechaCaducidad.Visible = true;
                campoCVV.Visible = true;
            }
            else if(opcionPayPal.Checked)
            {
                labelNumTarjeta.Visible = false;
                labelFechaCaducidad.Visible = false;
                labelCVV.Visible = false;
                campoNumTarjeta.Visible = false;
                campoFechaCaducidad.Visible = false;
                campoCVV.Visible = false;

                labelEmail.Visible = true;
                labelContrasena.Visible = true;
                campoEmail.Visible = true;
                campoContrasena.Visible = true;
            }
        }

        private void botonConfirmarPago_Click(object sender, EventArgs e)
        {
            ArrayList listaConciertos = LeerConciertos();
            Concierto concierto = (Concierto)listaConciertos[indiceConcierto];
            concierto.entradasDisponibles -= numEntradas;
            EscribirListaConciertos(listaConciertos);

            MessageBox.Show("La operación de pago se ha tramitado, pronto recibirá un email de confirmación.", "Operación confirmada", MessageBoxButtons.OK);
            this.Hide();
            new ListaConciertosCliente().Show();
        }
    }
}
