using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoDelegados
{
    class RepasoDelegados
    {
        //definicion del objeto delegado
        delegate void ObjetoDelegado(string msj);

        static void Mainnn(string[] args)
        {
            //Delegados1();
            //Delegados2();
            DelegadosFunction();
        }

        static void Delegados1()
        {
            //creacion del objeto delegaod apuntando
            ObjetoDelegado ElDelgado = new ObjetoDelegado(MensajeBienvenida.Saludo);

            //utilizacion del delegado
            ElDelgado("hola");

            ElDelgado = new ObjetoDelegado(MensajeBienvenida.Despedida);
            ElDelgado("adios");
        }


        //los delegados predicados devuelven true/false
        static void Delegados2()
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] {1,2,3,5,6,9,56,85,7});

            Predicate<int> elDelegadoPredicado = new Predicate<int>(DamePares);


            List<int> numPares= listaNumeros.FindAll(elDelegadoPredicado);

            foreach(int num in numPares)
            {
                Console.WriteLine(num);
            }

        }

        static bool DamePares(int num)
        {

            if (num % 0 == 0) return true;
            else return false;

        }








        //https://www.youtube.com/watch?v=I_fdCzza2mg&t=754s


        delegate string Mostrar(string str);

        static void DelegadosFunction()
        {
            //recibe distintos valores y el último es el que va a devolver
            //Func<string,int> mostrar = Show;
            
            //Mostrar mostrar2 = Show;

            //action no devuelve nada solo ejecuta
            Action<string,string> mostrar = Show;

            HacerAlgo(mostrar);

        }

        public static void Show(string cad,string cad2)
        {
            Console.WriteLine(cad+cad2);
        }

        static void HacerAlgo(Action<string,string> funcionFinal)
        {
            Console.WriteLine("hago algo");
            funcionFinal("se envio desde otra funcion"," otro");
            Console.WriteLine("Hago algo mas");
        }

        static int Show(string str)
        {
            return str.Length;
        }
                                                     

    }















    class MensajeBienvenida
    {
        public static void  Saludo(string msj)
        {
            Console.WriteLine("Saludo: {0}",msj);
        }

        public static void Despedida(string msj)
        {
            Console.WriteLine("Despedida: {0}",msj);
        }

        public static void Mensaje(string str)
        {
            Console.WriteLine(str);
        }

    }
}
