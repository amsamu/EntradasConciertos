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
            Application.Run(new VentanaLogin());
        }

        public static ArrayList listaUsuarios;
        static string ficheroUsuarios = "usuarios.txt";
        public static string usuarioActual = "";

        public static void anadirUsuario(Usuario u)
        {
            using (StreamWriter writetext = new StreamWriter(ficheroUsuarios, true))
            {
               writetext.WriteLine(u.username + ";" + u.clave + ";" + u.empleado);
            }
        }
		
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
		
		public static bool ExisteUsuario(string nombre)
        {
            bool existe = false;
            if (EncontrarUsuario(nombre) != null)
            {
                existe = true;
            }
            return existe;
        }
		
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
    }
}
