using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Propiedades
    {
        public static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            ///Juan.SetSalario(1200);
            Juan.SALARIO = 1200;


            //double nuevoSalario= Juan.GetSalario()+700;
            //Juan.SetSalario(nuevoSalario);

            Juan.SALARIO += 700;

            Console.WriteLine($"El salario es {Juan.GetSalario()}");

            Juan.SALARIO = -60;
            Console.WriteLine($"El salario es {Juan.GetSalario()}");

            //=> SALARIO


        }



    }
}
