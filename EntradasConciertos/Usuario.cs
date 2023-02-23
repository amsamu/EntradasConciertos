using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradasConciertos
{
    internal class Usuario
    {
        public string username { get; set; }
        public string clave { get; set; }
        public bool esEmpleado { get; set; }

        public Usuario(string usuario, string clave, bool empleado)
        {
            this.username = usuario;
            this.clave = clave;
            this.esEmpleado = empleado;
        }
    }
}
