using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradasConciertos
{
    internal class Usuario
    {
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool empleado { get; set; }

        public Usuario(string usuario, string clave, bool empleado)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.empleado = empleado;
        }
    }
}
