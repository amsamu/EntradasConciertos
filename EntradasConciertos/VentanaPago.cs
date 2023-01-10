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
        int precio;
        bool emailValido = false;
        bool contrasenaValida = false;
        bool numTarjetaValido = false;
        bool fechaCaducidadValida = false;
        bool cvvValido = false;

        public VentanaPago(int indiceConcierto, int numEntradas, int precio)
        {
            InitializeComponent();
            this.indiceConcierto = indiceConcierto;
            this.numEntradas = numEntradas;
            this.precio = precio;
        }

        private void VentanaPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarAplicacion();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                botonVolver.PerformClick();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                botonConfirmarPago.PerformClick();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
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

            if (opcionTarjeta.Checked)
            {   
                // Si los datos de la tarjeta tienen formato válido, confirmo la operación. Si no, aviso al usuario.
                if(numTarjetaValido && fechaCaducidadValida && cvvValido)
                {
                    confirmarPago();
                }
                else
                {
                    string mensaje = "";
                    if (!numTarjetaValido)
                    {
                        mensaje += "El número de tarjeta debe de tener una longitud entre 16 y 19.\n";
                    }
                    if (!fechaCaducidadValida)
                    {
                        mensaje += "La fecha de caducidad debe tener el formato MM/AA.\n";
                    }
                    if (!cvvValido)
                    {
                        mensaje += "El CVV debe ser un número de 3 cifras.";
                    }
                    MessageBox.Show(mensaje, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si los datos de la cuenta de PayPal tienen formato válido, confirmo la operación. Si no, aviso al usuario.
                if (emailValido && contrasenaValida)
                {
                    confirmarPago();
                }
                else
                {
                    string mensaje = "";
                    if (!emailValido)
                    {
                        mensaje += "El email debe tener un formato válido de dirección de correo electrónico.\n";
                    }
                    if (!contrasenaValida)
                    {
                        mensaje += "La contraseña no puede estar en blanco.\n";
                    }
                    MessageBox.Show(mensaje, "Datos no válidos", MessageBoxButtons.OK);
                }
            }

        }

        private void confirmarPago()
        {
            string mensaje = "Está a punto de adquirir " + numEntradas + " ";
            if (numEntradas > 1)
            {
                mensaje += "entradas";
            }
            else
            {
                mensaje += "entrada";
            }
            mensaje += " por un precio de " + precio + simboloDivisa + ". ¿Desea confirmar la transacción?";
            DialogResult dr = MessageBox.Show(mensaje, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                realizarPago();
            }
        }

        public void realizarPago()
        {
            // Resto el número de entradas que se acaban de comprar al número de entradas disponibles de este concierto.
            ArrayList listaConciertos = LeerConciertos();
            Concierto concierto = (Concierto)listaConciertos[indiceConcierto];
            concierto.entradasDisponibles -= numEntradas;
            EscribirListaConciertos(listaConciertos);

            // Le digo al usuario que la operación se ha completado y le devuelvo a la venta de lista de conciertos.
            MessageBox.Show("La operación de pago se ha tramitado, pronto recibirá un email de confirmación.", "Operación confirmada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            new ListaConciertosCliente().Show();
            this.Close();
        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {
            string[] partesEmail = campoEmail.Text.Split('@');
            // El email debe tener un solo @, la parte antes del @ debe tener al menos 1 carácter y la parte de después
            // tiene que tener al menos 3.
            if (partesEmail.Length == 2 && partesEmail[0].Length > 0 && partesEmail[1].Length > 2)
            {
                string[] partesDominio = partesEmail[1].Split('.');
                // La parte después del @ (el dominio) debe tener al menos 1 punto.
                if (partesDominio.Length > 1)
                {
                    string dominioFinal = partesDominio[partesDominio.Length - 1];
                    // El dominio final debe tener al menos un carácter (.com, .net, .es, etc.).
                    if (dominioFinal.Length > 0)
                    {
                        emailValido = true;
                    }
                    else
                    {
                        emailValido = false;
                    }
                }
                else
                {
                    emailValido = false;
                }
            }
            else
            {
                emailValido = false;
            }
        }

        private void campoContrasena_TextChanged(object sender, EventArgs e)
        {
            // El campo de contraseña no puede estar vacío.
            if(campoContrasena.Text.Length > 0)
            {
                contrasenaValida = true;
            }
            else
            {
                contrasenaValida = false;
            }
        }

        private void campoNumTarjeta_TextChanged(object sender, EventArgs e)
        {
            // El número de tarjeta debe tener una longitud de entre 16 y 19.
            if(campoNumTarjeta.Text.Length >= 16 && campoNumTarjeta.Text.Length <= 19)
            {
                numTarjetaValido = true;
            }
            else
            {
                numTarjetaValido = false;
            }
        }

        private void campoFechaCaducidad_TextChanged(object sender, EventArgs e)
        {
            string[] partesFecha = campoFechaCaducidad.Text.Split('/');
            if(partesFecha.Length == 2 && partesFecha[0].Length == 2 && partesFecha[1].Length == 2)
            {
                fechaCaducidadValida = true;
            }
            else
            {
                fechaCaducidadValida = false;
            }
        }

        private void campoCVV_TextChanged(object sender, EventArgs e)
        {
            if(campoCVV.Text.Length == 3)
            {
                cvvValido = true;
            }
            else
            {
                cvvValido = false;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            switch (indiceConcierto)
            {
                case 0:
                    new DetallesConciertoTOP().Show();
                    break;
                case 1:
                    new DetallesConciertoMCR().Show();
                    break;
                case 2:
                    new DetallesConciertoStarset().Show();
                    break;
            }
            this.Close();
        }

    }
}
