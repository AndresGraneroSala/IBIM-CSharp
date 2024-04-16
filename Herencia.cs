namespace Herencia
{

	// Videos 41-47
	class Herencia
	{

		static void Mainn(string[] args)
		{
			
			/* 
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


			Mamiferos animal = new Mamiferos("bufalo");
			Caballo Bucefalo = new Caballo("bucefalo");
			animal = Bucefalo;

			// error -> Bucefalo = animal;

			object miMamifero = new Mamiferos("wally");
			*/


			Mamiferos[] almacenAnimales = new Mamiferos[] { new Caballo("caballo blanco de santiago"), new Humano("Pepe"), new Gorila("Jorge el curioso") };


			Mamiferos miMamifero = new Mamiferos("test protected");
			//error no accesible desde fuera de la clase o otra que no la herede -> miMamifero.Respirar();
		
		}

	}


	class Mamiferos
	{
		public Mamiferos(string nombre) { 
		
			nombreSerVivo = nombre;
		}

		protected void Respirar()
		{
			Console.WriteLine("Capaz de respirar");
		}

		public void CuidarCrias()
		{
			Console.WriteLine("Cuido de crias hasta ser mayores");
		}

		public virtual void Pensar()
		{
			Console.WriteLine("pensamiento basico instintivo");
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
			Respirar();
			Console.WriteLine("Capaz de galopar");
		}
	}

	class Humano : Mamiferos
	{
		public Humano (String nombreHumano): base(nombreHumano) { }

		//new para quitar advertencia

		public override void Pensar()
		{
			Console.WriteLine("pensamiento logico");
		}
	}

	class Gorila:Mamiferos
	{
		public Gorila(String nombreGorila) : base(nombreGorila) { }


		public void Trepar()
		{
            Console.WriteLine("Soy capaz de trepar");
        }

		public override void Pensar()
		{
			Console.WriteLine("pensamiento instintivo avanzado");
		}
	}

}
