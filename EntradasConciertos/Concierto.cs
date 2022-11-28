using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EntradasConciertos
{
    internal class Concierto
    {
        public string grupo { get; set; }
        public string ciudad { get; set; }
        public string lugar { get; set; }
        public string fechaString { get; set; }

        public Concierto(string grupo, string ciudad, string lugar, string fechaString)
        {
            this.grupo = grupo;
            this.ciudad = ciudad;
            this.lugar = lugar;
            this.fechaString = fechaString;
        }

        public DateTime GetFecha()
        {
            string[] partesFecha = fechaString.Split('/');
            int dia = int.Parse(partesFecha[0]);
            int mes = int.Parse(partesFecha[1]);
            int anyo = int.Parse(partesFecha[2]);
            return new DateTime(anyo, mes, dia);
        }

    }
}
