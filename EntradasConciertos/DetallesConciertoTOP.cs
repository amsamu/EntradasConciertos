using System;
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
    public partial class DetallesConciertoTOP : Form
    {
        Concierto concierto;

        public DetallesConciertoTOP()
        {
            InitializeComponent();
            concierto = (Concierto) LeerConciertos()[0];
            PonerInfoConcierto();
        }

        private void DetallesConciertoTOP_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarAplicacion();
        }

        private void PonerInfoConcierto()
        {
            labelNumEntradasDisp.Text = Convert.ToString(concierto.entradasDisponibles);
            labelNumPrecioEntrada.Text = concierto.precioEntrada + " " + simboloDivisa;
            labelNumEntradasDisp.Text = Convert.ToString(concierto.entradasDisponibles);
            numEntradas.Maximum = concierto.entradasDisponibles;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            new ListaConciertosCliente().Show();
            this.Close();
        }

        private void botonComprar_Click(object sender, EventArgs e)
        {
            new VentanaPago(0, (int)numEntradas.Value).Show();
            this.Close();
        }

        private void numEntradas_ValueChanged(object sender, EventArgs e)
        {
            if(numEntradas.Value > 0)
            {
                botonComprar.Enabled = true;
            }
            else
            {
                botonComprar.Enabled = false;
            }
            labelNumPrecioTotal.Text = numEntradas.Value * concierto.precioEntrada + " " + simboloDivisa;
        }
        
    }
}
