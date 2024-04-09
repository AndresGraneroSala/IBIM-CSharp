namespace Herencia
{

	// Videos 27-35
	class Herencia
	{

		static void Main(string[] args)
		{

			//EJEMPLO DE SINTAXIS PARA HEREDAR

			Caballo Babieca	= new Caballo();

			Humano Juan = new Humano();

			Gorila Copito = new Gorila();

			Babieca.Galopar();
			Juan.Pensar();
			Copito.Trepar();

			Babieca.Respirar();
			Juan.CuidarCrias();
		}

	}


	class Mamiferos
	{
		public void Respirar()
		{
			Console.WriteLine("Capaz de respirar");
		}

		public void CuidarCrias()
		{
			Console.WriteLine("Cuido de crias hasta ser mayores");
		}
	}

	class Caballo : Mamiferos
	{
		public void Galopar() {
			Console.WriteLine("Capaz de galopar");
		}
	}

	class Humano : Mamiferos
	{
		public void Pensar()
		{
			Console.WriteLine("Soy capaz de pensar ¿?");
		}
	}

	class Gorila:Mamiferos
	{
		public void Trepar()
		{
            Console.WriteLine("Soy capaz de trepar");
        }
	}

}
