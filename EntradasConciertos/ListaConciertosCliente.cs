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
    public partial class ListaConciertosCliente : Form
    {

        ArrayList listaConciertos;

        public ListaConciertosCliente()
        {
            InitializeComponent();
            listaConciertos = LeerConciertos();
            PonerInfoConciertos();
        }

        private void ListaConciertosCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarAplicacion();
        }

        private void PonerInfoConciertos()
        {
            labelCiudadTwentyOnePilots.Text = ((Concierto)listaConciertos[0]).ciudad;
            labelLugarTwentyOnePilots.Text = ((Concierto)listaConciertos[0]).lugar;
            labelFechaTwentyOnePilots.Text = ((Concierto)listaConciertos[0]).fechaString;

            labelCiudadMCR.Text = ((Concierto)listaConciertos[1]).ciudad;
            labelLugarMCR.Text = ((Concierto)listaConciertos[1]).lugar;
            labelFechaMCR.Text = ((Concierto)listaConciertos[1]).fechaString;

            labelCiudadStarset.Text = ((Concierto)listaConciertos[2]).ciudad;
            labelLugarStarset.Text = ((Concierto)listaConciertos[2]).lugar;
            labelFechaStarset.Text = ((Concierto)listaConciertos[2]).fechaString;
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            new VentanaLogin().Show();
            this.Close();
        }

        private void masInfoTOP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DetallesConciertoTOP().Show();
            this.Close();
        }

        private void masInfoMCR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DetallesConciertoMCR().Show();
            this.Close();
        }

        private void masInfoStarset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DetallesConciertoStarset().Show();
            this.Close();
        }
        
    }
}
