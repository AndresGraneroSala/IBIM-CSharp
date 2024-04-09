﻿namespace Herencia
{

	// Videos 27-35
	class Herencia
	{

		static void Main(string[] args)
		{
			
			 
			//EJEMPLO DE SINTAXIS PARA HEREDAR + CONSTRUCTORES

			Caballo Babieca	= new Caballo("babieca");

			Humano Juan = new Humano("juan");

			Gorila Copito = new Gorila("copito");

			Babieca.Galopar();
			Juan.Pensar();
			Copito.Trepar();

			Babieca.Respirar();
			Juan.CuidarCrias();

			Juan.getNombre();
			Babieca.getNombre();
			Copito.getNombre();


		}

	}


	class Mamiferos
	{
		public Mamiferos(string nombre) { 
		
			nombreSerVivo = nombre;
		}

		public void Respirar()
		{
			Console.WriteLine("Capaz de respirar");
		}

		public void CuidarCrias()
		{
			Console.WriteLine("Cuido de crias hasta ser mayores");
		}

		private String nombreSerVivo;
		
		public void getNombre()
		{
            Console.WriteLine("El nombre del ser vivo es: "+ nombreSerVivo);
        }
	}

	class Caballo : Mamiferos
	{
		public Caballo (string nombreCaballo) : base(nombreCaballo) { }


		public void Galopar() {
			Console.WriteLine("Capaz de galopar");
		}
	}

	class Humano : Mamiferos
	{
		public Humano (String nombreHumano): base(nombreHumano) { }

		public void Pensar()
		{
			Console.WriteLine("Soy capaz de pensar ¿?");
		}
	}

	class Gorila:Mamiferos
	{
		public Gorila(String nombreGorila) : base(nombreGorila) { }


		public void Trepar()
		{
            Console.WriteLine("Soy capaz de trepar");
        }
	}

}
