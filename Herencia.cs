using DnsClient.Protocol;
using HelloWord.Models;

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


	

}
