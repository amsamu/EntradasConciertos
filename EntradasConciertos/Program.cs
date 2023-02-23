using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradasConciertos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            new VentanaLogin().Show();
            Application.Run();
        }

        static string ficheroConciertos = "datos-conciertos.txt";
        public static char simboloDivisa = '€';

        static DatabaseDataSetTableAdapters.UsuariosTableAdapter usuariosAdapter = new DatabaseDataSetTableAdapters.UsuariosTableAdapter();

        public static void CerrarAplicacion()
        {
            Console.WriteLine(Application.OpenForms.Count);
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        // Método para añadir un solo usuario al fichero.
        public static void anadirUsuario(Usuario u)
        {
            usuariosAdapter.Insert(u.username, u.clave, u.esEmpleado);
        }
		
        // Método para buscar un usuario por el nombre, si no existe devuelve null.
		public static Usuario EncontrarUsuario(string nombre)
        {
            DatabaseDataSet.UsuariosDataTable tablaUsuarios =  usuariosAdapter.GetData();
            Usuario resultado = null;
            int i = 0;
            while(i < tablaUsuarios.Count && resultado == null)
            {
                if (tablaUsuarios[i][0].ToString().Trim() == nombre)
                {
                    resultado = new Usuario(tablaUsuarios[i][0].ToString().Trim(), tablaUsuarios[i][1].ToString().Trim(), Convert.ToBoolean(tablaUsuarios[i][2].ToString().Trim()));
                }
                else
                {
                    i++;
                }
            }
            return resultado;
        }
		
        // Método que llama a EncontrarUsuario solo para comprobar si un usuario existe o no, devuelve true o false en consecuencia.
		public static bool ExisteUsuario(string nombre)
        {
            bool existe = false;
            if (EncontrarUsuario(nombre) != null)
            {
                existe = true;
            }
            return existe;
        }
		
        // Método que recorre el fichero de usuarios y cuenta el número total.
		public static int ContarUsuarios()
        {
            DatabaseDataSet.UsuariosDataTable tablaUsuarios = usuariosAdapter.GetData();
            return tablaUsuarios.Count;
        }

        // Método que lee el fichero de usuarios y los carga en un ArrayList.
        public static ArrayList LeerConciertos()
        {
            ArrayList listaConciertos = new ArrayList();
            if (File.Exists(ficheroConciertos))
            {
                using (StreamReader sr = new StreamReader(ficheroConciertos))
                {
                    string linea = sr.ReadLine();
                    while (linea != null)
                    {
                        string[] grupoYDatos = linea.Split(':');
                        string[] datosConcierto = grupoYDatos[1].Split(';');

                        string grupo = grupoYDatos[0];
                        string ciudad = datosConcierto[0];
                        string lugar = datosConcierto[1];
                        string fechaString = datosConcierto[2];
                        int entradasDisponibles = int.Parse(datosConcierto[3]);
                        int precioEntrada = int.Parse(datosConcierto[4]);

                        listaConciertos.Add(new Concierto(grupo, ciudad, lugar, fechaString,
                            entradasDisponibles, precioEntrada));
                        linea = sr.ReadLine();
                    }
                }
            }
            else
            {
                File.Create(ficheroConciertos);
            }
            return listaConciertos;
        }

        // Método para volver a escribir la lista entera de usuarios al fichero para reflejar los cambios
        // que se hayan hecho.
        public static void EscribirListaConciertos(ArrayList listaConciertos)
        {
            using (StreamWriter writetext = new StreamWriter(ficheroConciertos))
            {
                foreach (Concierto c in listaConciertos)
                {
                    writetext.WriteLine(c.grupo + ":" + c.ciudad + ";" + c.lugar + ";" + c.fechaString
                        + ";" + c.entradasDisponibles + ";" + c.precioEntrada);
                }
            }
        }

    }

}
