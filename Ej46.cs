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
            Console.WriteLine("a");
        }


		class Vehiculo
		{
			private double velocidad = 1;

			public Vehiculo(double velocidad)
			{
				this.velocidad = velocidad;
			}

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
                Console.WriteLine("conduciendo");
            }

		}

		class Avion: Vehiculo 
		{
			public override void Conducir()
			{
                Console.WriteLine("Conducir por el aire");
            }
		}

		class Coche: Vehiculo
		{
			public override void Conducir()
			{
				Console.WriteLine("Conducir por la carretera");
			}
		}




	}
}
