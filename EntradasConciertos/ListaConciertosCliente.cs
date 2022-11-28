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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VentanaLogin().Show();
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
    }
}
