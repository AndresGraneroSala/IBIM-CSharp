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
        public static void Main(string[] args)
        {
            //TestGettersSetters();
            //TestPunto();
            TestClasesAnonimas();
        }

        public static void TestGettersSetters()
        {
            Coche coche1 = new Coche();
            Console.WriteLine(coche1.getExtraCoche());
            coche1.setExtras(true, "cuero");
            Console.WriteLine(coche1.getExtraCoche());


        }


        public static void TestContructores()
        {
            Coche coche1 = new Coche();
        }

        public static void TestPunto()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(2,6);

            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"la distancia es:{distancia}");

            Punto otroPunto= new Punto();

            Console.WriteLine($"Hay {Punto.ContadorDeObjetos()} puntos");
            Console.WriteLine($"Las constantes son static {Punto.constantePrueba}");

        }

        public static void TestClasesAnonimas()
        {
            //using static System.Math; -> para evitar usar Math.


            double raiz = Math.Sqrt(9);
            double potencia= Math.Pow(3,4);

            Console.WriteLine(raiz);
            Console.WriteLine(potencia);

            var mivariable = new { Nombre = "Andres", Edad = 17 };
            var otraVarialbe = new { Nombre = "Ana", Edad = 35 };



            Console.WriteLine(mivariable.Nombre);


        }




    }



    class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private string tapiceria;

        //getter
        public string getInfoCoche()
        {
            return $"ruedas: {ruedas}, largo: {largo}, ancho{ancho}, climatizador:{climatizador}, tapiceria:{tapiceria}";
        }

        public string getExtraCoche()
        {
            return $"climatizador:{climatizador}, tapiceria:{tapiceria}";

        }

        //setter
        public void setExtras(bool climatizador, string tapiceria)
        {
            //this -> hace referencia a este objeto, en este caso esta clase
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }



        public Coche()
        {
            ruedas = 4;
            largo = 223.045;
            ancho = 53.6;
            climatizador = false;
            tapiceria = "tela";

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