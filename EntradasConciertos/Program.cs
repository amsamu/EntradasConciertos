using System;
using System.Collections;
using System.Collections.Generic;
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
            new VentanaLogin().Show();
            Application.Run();
        }

        static string ficheroUsuarios = "usuarios.txt";
        static string ficheroConciertos = "datos-conciertos.txt";
        public static char simboloDivisa = '€';

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
            using (StreamWriter writetext = new StreamWriter(ficheroUsuarios, true))
            {
               writetext.WriteLine(u.username + ";" + u.clave + ";" + u.empleado);
            }
        }
		
        // Método para buscar un usuario por el nombre, si no existe devuelve null.
		public static Usuario EncontrarUsuario(string nombre)
        {
            Usuario resultado = null;
			if (File.Exists(ficheroUsuarios))
            {
				using(StreamReader sr = new StreamReader(ficheroUsuarios))
				{
					string linea = sr.ReadLine();
					while(linea!=null && resultado == null)
					{
						string[] partesLinea = linea.Split(';');
						if (partesLinea[0] == nombre)
						{
							resultado = new Usuario(partesLinea[0], partesLinea[1], Convert.ToBoolean(partesLinea[2]));
						}
						linea = sr.ReadLine();
					}
				}
			}
            else
            {
                File.Create(ficheroUsuarios);
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
            int contador = 0;
            if (!File.Exists(ficheroUsuarios))
            {
                File.Create(ficheroUsuarios);
            }
            using (StreamReader sr = new StreamReader(ficheroUsuarios))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    contador++;
                    linea = sr.ReadLine();
                }
            }
            return contador;
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
