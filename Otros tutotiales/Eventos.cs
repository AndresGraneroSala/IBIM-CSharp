//https://www.youtube.com/watch?v=wnr5eY1yUjI

namespace Eventos
{
	internal class Eventos
	{
		static void Main(string[] args)
		{
			SuscriptorCalculadoreaVirtual calculadoraVirtual = new SuscriptorCalculadoreaVirtual(3,2);

			calculadoraVirtual.OperacionSuma();
			calculadoraVirtual.OperacionResta();


		}
	}


	public class EditorCalculadora //acciones
	{
		public delegate void EjemploDelegado();
		public event EjemploDelegado evento;

		public void Suma(int a, int b)
		{
			if (evento != null)
			{
				evento();
				Console.WriteLine(value: $"Suma: {a + b}");

			}
			else
			{
				Console.WriteLine("No estas suscrito");
			}

		}

		public void Resta(int a, int b)
		{
			if (evento != null)
			{
				evento();
				Console.WriteLine(value: $"Resta: {a - b}");

			}
			else
			{
				Console.WriteLine("No estas suscrito");
			}
		}

	}



	public class SuscriptorCalculadoreaVirtual
	{
		private EditorCalculadora editor;

		private int A;
		private int B;


		public void EjemploEventHandler()
		{
			Console.WriteLine("La operacion va a ser ejecutada");

		}

		public SuscriptorCalculadoreaVirtual(int a, int b)
		{
			editor =new EditorCalculadora();
			A= a; B = b;
			editor.evento += EjemploEventHandler;
		}

		public void OperacionSuma()
		{
			editor.Suma(A, B);
		}

		public void OperacionResta()
		{
			editor.Resta(A, B);
		}





	}
}
