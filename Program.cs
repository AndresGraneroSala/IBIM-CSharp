// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

/*
 
Variable Se puede modificar
Constante No cambia nunca una vez definido

int numeros enteros 

numeros decimales - bits
--------------------------
float 4 f
double 8 
decimal 16 m
--------------------------

string texto
char letra
bool condicion


camel case firstName variables
pascal case Pi constantes
 
 */

using System;
using System.Numerics;

namespace HelloWorld
{
    class Program
    {
        
        /// <summary>
        /// Esto inicia todo
        /// </summary>
        /// <param name="args"> Vector por defecto</param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World, have a nice day");


            /*
            VARAIBLES EJEMPLOS

            byte number=2;
            int count = 10;
            float price = 20.95f;
            char character = 'A';
            string firstName = "Andres";
            var isWorking = true;


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            */


            /*
            //MÁXIMOS Y MÍNIMOS DE LOS TIPOS DE DATOS
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            */



            /*
            //CONVERSIONES

            int i = 1;
            byte b =  (byte)i;
            
            Console.WriteLine(i);



            //try hace que si hay un error no se pare y se ejecute otra parte
            try
            {
                var number = "1234";
                int j = int.Parse(number);
                byte c = Convert.ToByte(number);

                Console.WriteLine(j);

            }
            catch (Exception)
            {
                Console.WriteLine("No se puede convertir a byte");
            }

            string str = "true";
            bool boolConv= Convert.ToBoolean(str);

            Console.WriteLine(boolConv);*/


            /*
            //OPERADORES ARITMÉTICOS (operaciones simples)

            var a = 10;
            var b = 2;
            var c = 3;



            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
            Console.WriteLine((float)a / (float)b);*/



            /*
            //OPERADORES DE COMPARACION (resultado booleano)
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b || c == a);
            */

            //OPERADORES ASIGNACIÓN (aritméticos aplicados directamente a variables)
            //OPERADORES LÓGICOS 
            //OPERADORES BITWISE (para bits)

        }
    }
}