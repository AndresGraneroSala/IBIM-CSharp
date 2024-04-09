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
        static void Main(string[] args)
        {

            /* 
            //EJEMPLO INSTANCIAR UN OBJETO VIDEO 28

            Circulo miCirculo; //variable de tipo objeto

            miCirculo = new Circulo(); //Iniciación de variable objeto -> Instanciar o ejemplar de clase
            Console.WriteLine(miCirculo.calculoArea(3));

			Circulo miCirculo2 = new Circulo(); //Iniciación de variable objeto -> Instanciar o ejemplar de clase
			Console.WriteLine(miCirculo2.calculoArea(6));
*/



		}
	}


	class Circulo //ejemplo de una clase
	{
		private const double Pi = 3.1416; //propiedad o campo de clase

		public double calculoArea(int radio) //metodo de clase su comportamiento 
		{
			return Pi * radio * radio;
		}
	}
}