using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    enum Estaciones
    {
        Primavera,Verano,Otoño,Invierno
    }

    enum Bonus { bajo=500,normal=1000,bueno=1500,extra=3000}

    internal class Enumerado
    {



        public static void Main(string[] args)
        {
            Empleado Antonio = new Empleado(Bonus.extra,1550);

            Console.WriteLine("Salario de antonio");
            Console.WriteLine(Antonio.GetSalario);


            /*
            Bonus Antonio= Bonus.bueno;

            double bonusAntonio= (double)Antonio;

            double salarioAntonio=1500+bonusAntonio;

            Console.WriteLine(salarioAntonio);*/


            /*Estaciones? valorNulo = null;

            Estaciones alergia = Estaciones.Primavera;

            string la_Alergia =alergia.ToString();

            Console.WriteLine($"Las alergias son en {alergia}");*/


        }

    }


    class Empleado
    {
        private double salario, bonus;

        public Empleado(Bonus bonusEmpleado, double salario) { 
        
            bonus = (double)bonusEmpleado; 
            this.salario = salario;
        
        }  
        

        public double GetSalario()
        {
            return salario+ bonus;
        }
    }
}
