using MongoDB.Driver;
using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            //Array1();
            Array2();

        }

        public static void Array1()
        {
            int[] edades = new int[4];
            // valores por defecto

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;

            int[] edades2 = { 15, 27, 29, 80 };

            Console.WriteLine(edades[2]);
        }

        public static void Array2()
        {
            Punto[] arrayObjetos= new Punto[2];


            arrayObjetos[0] = new Punto(2,6);

            Punto punto = new Punto(2,6);
            arrayObjetos[1] = punto;

            //array tipos/clases anonimas
            //mismo tipo
            var personas = new[]
            {
                new {Nombre= "Juan",Edad=19},
                new {Nombre= "Andres",Edad=17},
                new {Nombre= "Maria",Edad=45}
            };




        }


    }
}
