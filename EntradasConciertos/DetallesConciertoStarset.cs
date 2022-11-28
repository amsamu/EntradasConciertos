using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradasConciertos
{
    public partial class DetallesConciertoStarset : Form
    {
        public DetallesConciertoStarset()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListaConciertosCliente().Show();
        }

        private void botonComprar_Click(object sender, EventArgs e)
        {
            labelEntradasAdquiridas.Visible = true;
        }
    }
}
