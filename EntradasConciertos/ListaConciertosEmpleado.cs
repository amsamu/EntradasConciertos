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
    public partial class ListaConciertosEmpleado : Form
    {

        // Variable boolean para tener constancia de cuando se hayan hecho cambios en los
        // datos de los conciertos con respecto al estado en el que estaban al abrirse
        // este form.
        bool seHanRealizadoCambios;

        ArrayList listaConciertos;

        public ListaConciertosEmpleado()
        {
            InitializeComponent();
            listaConciertos = LeerConciertos(); // Cargo la info de los conciertos desde el fichero.
            PonerInfoConciertos(); // Pongo la info de los conciertos en los elementos de la interfaz gráfica.
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (seHanRealizadoCambios && !labelCambiosGuardados.Visible)
            {
                DialogResult confirmarCierre = MessageBox.Show("Hay cambios sin guardar." +
                    " ¿Seguro que deseas salir?", "Cambios sin guardar", MessageBoxButtons.YesNo);
                if (confirmarCierre == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void PonerInfoConciertos()
        {
            campoCiudadTOP.Text = ((Concierto)listaConciertos[0]).ciudad;
            campoLugarTOP.Text = ((Concierto)listaConciertos[0]).lugar;
            selecFechaTOP.CustomFormat = "dd/MM/yyyy";
            selecFechaTOP.Value = ((Concierto)listaConciertos[0]).GetFecha();
            numEntradasTOP.Value = ((Concierto)listaConciertos[0]).entradasDisponibles;
            precioEntradaTOP.Value = ((Concierto)listaConciertos[0]).precioEntrada;

            campoCiudadMCR.Text = ((Concierto)listaConciertos[1]).ciudad;
            campoLugarMCR.Text = ((Concierto)listaConciertos[1]).lugar;
            selecFechaMCR.CustomFormat = "dd/MM/yyyy";
            selecFechaMCR.Value = ((Concierto)listaConciertos[1]).GetFecha();
            numEntradasMCR.Value = ((Concierto)listaConciertos[1]).entradasDisponibles;
            precioEntradaMCR.Value = ((Concierto)listaConciertos[1]).precioEntrada;

            campoCiudadStarset.Text = ((Concierto)listaConciertos[2]).ciudad;
            campoLugarStarset.Text = ((Concierto)listaConciertos[2]).lugar;
            selecFechaStarset.CustomFormat = "dd/MM/yyyy";
            selecFechaStarset.Value = ((Concierto)listaConciertos[2]).GetFecha();
            numEntradasStarset.Value = ((Concierto)listaConciertos[2]).entradasDisponibles;
            precioEntradaStarset.Value = ((Concierto)listaConciertos[2]).precioEntrada;

            seHanRealizadoCambios = false;
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            if(seHanRealizadoCambios && !labelCambiosGuardados.Visible)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult confirmarCierre = MessageBox.Show("Hay cambios sin guardar. ¿Seguro que deseas cerrar sesión?", "Cambios sin guardar", buttons);
                if(confirmarCierre == DialogResult.Yes)
                {
                    this.Hide();
                    new VentanaLogin().Show();
                }
            }
            else
            {
                this.Hide();
                new VentanaLogin().Show();
            }
        }

        private void masInfoTOP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DetallesConciertoTOP().Show();
        }

        private void masInfoMCR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DetallesConciertoMCR().Show();
        }

        private void masInfoStarset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DetallesConciertoStarset().Show();
        }
        
        private void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            // Actualizo los datos de los tres conciertos en el ArrayList.
            ((Concierto)listaConciertos[0]).ciudad = campoCiudadTOP.Text;
            ((Concierto)listaConciertos[0]).lugar = campoLugarTOP.Text;
            ((Concierto)listaConciertos[0]).fechaString = selecFechaTOP.Text;
            ((Concierto)listaConciertos[0]).entradasDisponibles = (int)numEntradasTOP.Value;
            ((Concierto)listaConciertos[0]).precioEntrada = (int)precioEntradaTOP.Value;

            ((Concierto)listaConciertos[1]).ciudad = campoCiudadMCR.Text;
            ((Concierto)listaConciertos[1]).lugar = campoLugarMCR.Text;
            ((Concierto)listaConciertos[1]).fechaString = selecFechaMCR.Text;
            ((Concierto)listaConciertos[1]).entradasDisponibles = (int)numEntradasMCR.Value;
            ((Concierto)listaConciertos[1]).precioEntrada = (int)precioEntradaMCR.Value;

            ((Concierto)listaConciertos[2]).ciudad = campoCiudadStarset.Text;
            ((Concierto)listaConciertos[2]).lugar = campoLugarStarset.Text;
            ((Concierto)listaConciertos[2]).fechaString = selecFechaStarset.Text;
            ((Concierto)listaConciertos[2]).entradasDisponibles = (int)numEntradasStarset.Value;
            ((Concierto)listaConciertos[2]).precioEntrada = (int)precioEntradaStarset.Value;

            // Después escribo el ArrayList al fichero.
            EscribirListaConciertos(listaConciertos);
            // Muestro el mensaje de que los cambios se han guardado.
            labelCambiosGuardados.Visible = true;
        }



        // Cuando se realice cualquier cambio, se quita el mensaje de Cambios guardados
        // hasta que se vuelva a pulsar el botón de guardar.
        private void campoCiudadTOP_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void campoLugarTOP_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void selecFechaTOP_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }
        private void numEntradasTOP_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void precioEntradaTOP_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void campoCiudadMCR_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void campoLugarMCR_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void selecFechaMCR_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void numEntradasMCR_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void precioEntradaMCR_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void campoCiudadStarset_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void campoLugarStarset_TextChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void selecFechaStarset_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void numEntradasStarset_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }

        private void precioEntradaStarset_ValueChanged(object sender, EventArgs e)
        {
            labelCambiosGuardados.Visible = false;
            seHanRealizadoCambios = true;
        }
    }
}
