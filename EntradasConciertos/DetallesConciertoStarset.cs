﻿using System;
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
    public partial class DetallesConciertoStarset : Form
    {
        Concierto concierto;

        public DetallesConciertoStarset()
        {
            InitializeComponent();
            concierto = (Concierto) LeerConciertos()[2];
            PonerInfoConcierto();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
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
            this.Hide();
            new ListaConciertosCliente().Show();
        }

        private void botonComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VentanaPago(2, (int)numEntradas.Value).Show();
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