
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
        static void Mainnn(string[] args)
        {
            //Video7();
            //Console.WriteLine(Video9Metodos.SumaNumeros(1,3));
            //Video9Metodos.ImprimirSuma(5,9);
            //Video18Switch();
            //Videos19Al20While.Video20();
            //Videos19Al20While.Video21();
            //Videos22Al26Excepciones.Video22y24();
            //Videos22Al26Excepciones.Video24y25Checked();


            /*Console.WriteLine(Videos22Al26Excepciones.Meses(2));
            try
            {
				Console.WriteLine(Videos22Al26Excepciones.Meses(15));
			}
			catch (Exception e)
            {

                Console.WriteLine($"Mensaje de la excepción: {e.Message}");
            }*/

            Videos22Al26Excepciones.Video26Finally();

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

    class Videos22Al26Excepciones {

        //ventana de configuración de extensiones en Depurar>Ventanas>Configuración de excepciones


        internal static void Video26Finally()
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linia;
                int contador = 0;

                string ruta = @"C:\Users\Andriu\Desktop\PruebasC#.txt";

                archivo = new System.IO.StreamReader(ruta);

				while ((linia = archivo.ReadLine()) != null) {
                    Console.WriteLine(linia);
                    contador++;
                }

			}
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");

            }
            finally
            {
                if(archivo!= null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexión con el fichero cerrada");
                }
            }


        }


        internal static string Meses(int numMes)
        {
            switch (numMes)
            {
				case 1:
					return "Enero";
				case 2:
					return "Febrero";
				case 3:
					return "Marzo";
				case 4:
					return "Abril";
				case 5:
					return "Mayo";
				case 6:
					return "Junio";
				case 7:
					return "Julio";
				case 8:
					return "Agosto";
				case 9:
					return "Septiembre";
				case 10:
					return "Octubre";
				case 11:
					return "Noviembre";
				case 12:
					return "Diciembre";
				default:
                    throw new ArgumentOutOfRangeException();
			}
        }

        internal static void Video24y25Checked()
        {
            //no dejar pasar errores

            int num = int.MaxValue;

            int resultado = checked(num + 20);
            int resultadoSinChecked = unchecked(num+30);



            Console.WriteLine(num);
            Console.WriteLine(resultado);



        }

        internal static void Video22y24()
        {
			Random random = new Random();
			int numRandom = random.Next(0, 100);

			int intentos = 0;

			int minumero = 101;

			Console.WriteLine("Adivina el numerín del 1-100");

			do
			{
				intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());

                }
                catch (FormatException e) when (e.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine($"Ha ocurrido un error, {e.Message}");
                    minumero=101;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Has introducido texto");
                    minumero = 101;
				}


				/*catch (OverflowException ex)
                {
					Console.WriteLine($"Tu número es demasiado alto, {ex.Message}");
					minumero = 101;
                }
                catch (Exception ex)
                {
					Console.WriteLine($"Tu número es demasiado alto, {ex.Message}");
					minumero = 101;
				}*/


				string esMas =minumero==numRandom? "" : minumero > numRandom ? "bajo" : "alto";

                if (minumero != 101)
                {
					Console.WriteLine("El número es más {esMas}");
				}

			} while (numRandom != minumero);

			Console.WriteLine($"Bien el número era {numRandom}, has tardado {intentos} intentos");
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