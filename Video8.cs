﻿
using System;
using System.Numerics;

namespace HelloWorld
{
    class Videos
    {
        
        /// <summary>
        /// Esto inicia todo
        /// </summary>
        /// <param name="args"> Vector por defecto</param>
        static void Main(string[] args)
        {
            //Video7();
            //Console.WriteLine(Video9Metodos.SumaNumeros(1,3));
            //Video9Metodos.ImprimirSuma(5,9);
            //Video18Switch();
            //Videos19Al20While.Video20();
			Videos19Al20While.Video21();
        
        }


        


        static void Video7()/*Recibir datos de consola*/
        {

            Console.WriteLine("Introduce el 1º número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el 2º número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma es  {num1 + num2}");
        }

        static void Video18Switch()
        {
            int num=int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                
                case 2:
                    Console.WriteLine("Dos");
                    break;
                
                case 3:
                    Console.WriteLine("Tre");
                    break;

                default:
                    Console.WriteLine("Un puñao");
                    break;
            }

        }

    }

    class Videos19Al20While
    {
        internal static void Video20()
        {
            Random random = new Random();
            int numRandom = random.Next(0,100);

            int intentos = 0;

            int minumero = 101;

            Console.WriteLine("Adivina el numerín");

            while (numRandom!=minumero)
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());

				string esMas = minumero > numRandom ?  "bajo":"alto";


				Console.WriteLine($"El número es más {esMas}");
            }

            Console.WriteLine($"Bien el número era {numRandom}, has tardado {intentos} intentos");
        }

        internal static void Video21()
		{
			Random random = new Random();
			int numRandom = random.Next(0, 100);

			int intentos = 0;

			int minumero = 101;

			Console.WriteLine("Adivina el numerín");

            do
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());

                string esMas = minumero > numRandom ? "bajo" : "alto";


                Console.WriteLine($"El número es más {esMas}");
            } while (numRandom != minumero);

			Console.WriteLine($"Bien el número era {numRandom}, has tardado {intentos} intentos");
		}
	}


    class Video9Metodos
    {
        internal static int SumaNumeros(int num1,int num2)
        {
            return (num1 + num2);
        }

        internal static void ImprimirSuma(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }

    class Video12Sobrecarga
    {
        internal static int Resta(int num1,int num2)
        {
            return num1 - num2;
        }

        internal static int Resta(float num1,float num2)
        {
            return (int)(num2 - num1);
        }
    }

    class Condicionales
    {
        
        internal static void Test()
        {
            int edad = 17;

            Console.WriteLine("Vamos a comprobar tu edad");

            if (edad>=18)
            {
                Console.WriteLine("Adelante puedes pasar");
            }
            else
            {
                Console.WriteLine($"No puedes pasar vuelve en {18-edad} años");
            }
        }
        

    }
}