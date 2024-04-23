using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class ExpresionesRegulares
    {
        public static void Mainn(string[] args)
        {
            //Clase1();
            Clase2();
        }


        public static void Clase2()
        {
            string frase = "mi web es http://ejemplo.com";

            //? una o ninguna
            string patronWeb = "https?://(www.)?";

            Regex miRegex= new Regex(patronWeb);

            MatchCollection matchCollection = miRegex.Matches(frase);

            if (matchCollection.Count > 0 )
            {
                Console.WriteLine("Hay web valida");
            }else
            {
                Console.WriteLine("No hay web valida");

            }



        }

        public static void Clase1()
        {
            string frase = "Hola mundo mi nombre es Andres nacido en 2006 tlf (+44)124-13-16";

            //buscar letra
            string patron = "[A]";
            string numeroPatron = @"\d{3}-\d{2}-\d{2}";
            string numeroEspañaUK = @"\+34|\+44";

            Regex miRegex= new Regex(patron);

            MatchCollection matches = miRegex.Matches(frase);

            if (matches.Count > 0)
            {
                Console.WriteLine("Se ha encontrado una A");
            }
            else{
                Console.WriteLine("No se ha encontrado una A");

            }

            miRegex = new Regex(numeroPatron);

            matches = miRegex.Matches(frase);

            if (matches.Count > 0)
            {
                Console.WriteLine("Se ha encontrado un número tlf");

                miRegex = new Regex(numeroEspañaUK);
                matches = miRegex.Matches(frase);


                if (matches[0].Success) {

                    Console.WriteLine("Es de España o UK");
                }
                else
                {
                    Console.WriteLine("No es de España o UK");

                }

            }
            else
            {
                Console.WriteLine("No se ha encontrado un número tlf");

            }

        }

    }
}
