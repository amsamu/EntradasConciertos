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
            listaUsuarios = leerListaUsuarios();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaLogin());
        }

        public static ArrayList listaUsuarios;
        static string ficheroUsuarios = "usuarios.txt";

        public static void anadirUsuario(Usuario u)
        {
            using (StreamWriter writetext = new StreamWriter(ficheroUsuarios, true))
            {
               writetext.WriteLine(u.usuario + ";" + u.clave + ";" + u.empleado);
            }
        }

        public static void escribirListaUsuarios(ArrayList usuarios)
        {
            using (StreamWriter writetext = new StreamWriter(ficheroUsuarios, true))
            {
                foreach (Usuario u in usuarios){
                    writetext.WriteLine(u.usuario + ";" + u.clave + ";" + u.empleado);
                }
                //writetext.WriteLine("Rickard;northremembers;true");
                //writetext.WriteLine("Edmure;tullyrules;false");
            }
        }

        public static ArrayList leerListaUsuarios()
        {
            ArrayList usuarios = new ArrayList();
            if (File.Exists(ficheroUsuarios))
            {
                using (StreamReader readtext = new StreamReader(ficheroUsuarios))
                {
                    string line = readtext.ReadLine();
                    while (line != null)
                    {
                        string[] atributos = line.Split(';');
                        usuarios.Add(new Usuario(atributos[0], atributos[1], Convert.ToBoolean(atributos[2])));
                        line = readtext.ReadLine();
                    }
                }
            }
            else
            {
                File.Create(ficheroUsuarios);
            }
            return usuarios;
        }

        public static int findUser(string usuario)
        {
            int pos = -1;
            int i = 0;
            while (i < listaUsuarios.Count && pos!=-1)
            {
                string usuarioLista = (string)listaUsuarios[i];
                if (usuarioLista.Split(';')[0] == usuario)
                {
                    pos = i;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        public static bool userExists(string usuario)
        {
            bool exists = false;
            if (findUser(usuario) != -1)
            {
                exists = true;
            }
            return exists;
        }

    }
}
