namespace Delegados
{
	internal class Delegados
	{
		static void Mainn(string[] args)
		{
			/*
			//Creacion del delegado apuntando a MensajeBienvenido
			ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
			//Llama al delegado
			ElDelegado("");

			ElDelegado = new ObjetoDelegado(MensajeDesdepdida.SaludoDespedida);
			ElDelegado("");
			*/

			/*
			List<int> listaNumeros = new List<int>();
			listaNumeros.AddRange(new int[] {1,2,3,45,8,6});
			//Declaramos delegado predicado

			Predicate<int> elDelegadoPred = new Predicate<int>(Predicados.DamePares);

			List<int> numPares= listaNumeros.FindAll(elDelegadoPred);

			foreach (var num in numPares)
			{
                Console.WriteLine(num);
            }*/

			List<Personas> gente = new List<Personas>();

			Personas P1= new Personas();
			P1.Nombre = "Juan";
			P1.Edad = 18;

			Personas P2 = new Personas();
			P2.Nombre = "Andrés";
			P2.Edad = 17;

			Personas P3 = new Personas();
			P3.Nombre = "Maria";
			P3.Edad = 28;

			gente.AddRange(new Personas[] { P1, P2, P3 });

			Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteAndres);
			bool existe= gente.Exists(elPredicado);

			if (existe)
			{
				Console.WriteLine("Existo");
			}
			else
			{
                Console.WriteLine("No estoy");
            }

		}

		static bool ExisteAndres(Personas persona)
		{
			if (persona.Nombre == "Andrés")
			{
				return true;
			}
			return false;
		}


		//Definicion del objeto delecado

		delegate void ObjetoDelegado(string msj);
		
		//delegate
		//Action 
		//Func 
	}


	class Predicados
	{



		/*public static bool DamePares(int num)
		{
			if (num % 2 == 0)
			{
				return true;
			}

			return false;
		}*/
	}

	class Personas
	{
		private string nombre;
		private int edad;

		public string Nombre { get => nombre; set => nombre = value; }
		public int Edad { get => edad; set => edad = value; }
	}

	/*class MensajeBienvenida
	{
		public static void SaludoBienvenida(string msj)
		{
			Console.WriteLine("Mensaje de bienvenida: {0}", msj);
		}
	}

	class MensajeDesdepdida
	{
		public static void SaludoDespedida(string msj)
		{
			Console.WriteLine("Mensaje de despedida: " + msj);
		}
	}*/

}
