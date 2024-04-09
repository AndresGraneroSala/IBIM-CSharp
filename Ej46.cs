namespace Ej46
{

	// Video 46


	/*
	 ·Creacion de tres clases
		-Avión
		-Vehículo
		-Coche
	
	·Métodos coumnes a las tres clases
		-Arrancar motor
		-Parar motor

	·Método virtual
		-Conducir

	 
	 */

	class Ej46
	{

		static void Main(string[] args)
		{
            Console.WriteLine("Test avion");
			
			Avion miAvion= new Avion();
			miAvion.Arrancar();
			miAvion.Despegar();
			miAvion.Conducir();
			miAvion.Parar();


			Console.WriteLine("Test coche");

			Coche miCoche = new Coche();
			miCoche.Arrancar();
			miCoche.Conducir();
			miCoche.Parar();
		}


		class Vehiculo
		{
			

			public void Arrancar()
			{
                Console.WriteLine("arrancamos motores");
            }

			public void Parar()
			{
                Console.WriteLine("paramos motores");
            }

			public virtual void Conducir()
			{
                Console.WriteLine("conduciendo de manera generica");
            }

		}

		class Avion: Vehiculo 
		{
			public void Despegar()
			{
                Console.WriteLine("Despegue");
            }

			public void Aterrizar()
			{
                Console.WriteLine("Aterrizaje");
            }

			public override void Conducir()
			{
                Console.WriteLine("Conducir por el aire");
            }
		}

		class Coche: Vehiculo
		{
			public void Acelerar()
			{
                Console.WriteLine("Para alante");
            }

			public void Frenar()
			{
                Console.WriteLine("Para el carro");
            }

			public override void Conducir()
			{
				Console.WriteLine("Conducir por la carretera");
			}
		}




	}
}
