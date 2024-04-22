using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Destructores
    {


        public static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.Mensaje();
        }

    }


    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador;
        string linia;
        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\texto.txt");

            while ((linia = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linia);
                contador++;
            }

        }

        public void Mensaje()
        {
            Console.WriteLine($"hay {contador} linias");
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }

    }
}
