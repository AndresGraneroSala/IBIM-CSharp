using System;
using System.Numerics;




namespace POO
{

    // Videos 27-35
    class POO
    {
        
        /// <summary>
        /// Esto inicia todo
        /// </summary>
        /// <param name="args"> Vector por defecto</param>
        static void Mainn(string[] args)
        {

            /* 
            //EJEMPLO INSTANCIAR UN OBJETO VIDEO 28

            Circulo miCirculo; //variable de tipo objeto

            miCirculo = new Circulo(); //Iniciación de variable objeto -> Instanciar o ejemplar de clase
            Console.WriteLine(miCirculo.calculoArea(3));

			Circulo miCirculo2 = new Circulo(); //Iniciación de variable objeto -> Instanciar o ejemplar de clase
			Console.WriteLine(miCirculo2.calculoArea(6));
*/
            /*
            //EJEMPLO ENCAPSULAR

            ConversorEuroDolar obj = new ConversorEuroDolar();

            //obj.euro = 2;
            obj.SetEuro(5);
            
            Console.WriteLine(obj.convierte(50));*/
            
            Tests.TestContructores();
        }
	}

	/*CONSTRUCTORES*/
	/*----------------------------*/

    class Tests
    {

        public static void TestContructores()
        {
            Coche coche1 = new Coche();
        }
    }

    class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private string tapiceria;

        public Coche()
        {
            ruedas = 4;
            largo = 223.045;
            ancho = 53.6;
            climatizador = false;
            tapiceria = "cuero";

        }


        public Coche(int ruedas, string tapiceria)
        {
            this.ruedas = ruedas;
            largo = 223.045;
            ancho = 53.6;
            climatizador = false;
            this.tapiceria = tapiceria;

        }

    }



	/*----------------------------*/

	class ConversorEuroDolar
    {
        private double euro =1.253;

        public void SetEuro(double nuevoVal)
        {
            //control de como se modifica 
            if (euro < 0)
            {
                return;
            }

            euro = nuevoVal;
        }

        public double convierte(double cantidad)
        {
            return euro*cantidad;
        }

    }

	class Circulo //ejemplo de una clase
	{
		private const double Pi = 3.1416; //propiedad o campo de clase

		public double CalculoArea(int radio) //metodo de clase su comportamiento 
		{
			return Pi * radio * radio;
		}
	}

}