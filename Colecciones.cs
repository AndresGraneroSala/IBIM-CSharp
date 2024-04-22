using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Colecciones
    {
        public static void Main(string[] args)
        {
            //arrays modificables
            //Listas();

            //listas con nodos
            //ListasEnlazadas

            //se añade abajo
            //Colas();

            //se añade arriba
            //Stacks();

            //Lista de elementos con claves
            Diccionarios();
        }

        public static void Diccionarios()
        {
            Dictionary<string,int> edades = new Dictionary<string,int>();

            edades.Add("Andres", 17);

            edades["Maria"] = 25;
            edades["Antonio"] = 29;

            foreach (KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine($"Persona {persona.Key}: Edad {persona.Value}");
            }


        }


        public static void Stacks()
        {

            Stack<int> numeros = new Stack<int>();

            Console.WriteLine("añadiendo a stack");

            foreach (int i in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(i);


            }


            Console.WriteLine("recorriendo los elementos del stack");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("eliminando los elementos  del stack");

            numeros.Pop();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }


        public static void Colas()
        {
            Queue<int> numeros= new Queue<int>();

            Console.WriteLine("añadiendo a cola");

            foreach (int i in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(i);


            }


            Console.WriteLine("recorriendo los elementos de la cola");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("eliminando los elementos de la cola");

            numeros.Dequeue();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }


        public static void ListasEnlazadas()
        {
            LinkedList<int> numeros= new LinkedList<int>();

            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.AddFirst(numero);
            }

            numeros.RemoveFirst();

            numeros.AddLast(new LinkedListNode<int>(12));

            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero= nodo.Value;
                Console.WriteLine(numero);
            }

            

            /*foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/

        }

        public static void Listas()
        {
            List<int> numeros = new List<int>();


            Console.WriteLine("Introduce los elementos y sal con 0 ");

            int elem = 1;

            while (elem!=0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            /*Console.WriteLine("¿Cuántos elem quieres introducir?");


            int elem= Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }*/

            Console.WriteLine("Elementos introducidos");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        }

    }
}
