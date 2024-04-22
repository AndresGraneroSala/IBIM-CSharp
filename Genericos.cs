using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Genericos
    {

        public static void Main(string[] args)
        {
            //clases que valen para todos los tipos de objeto

            AlmacenObjetos <Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            /*archivos.Agregar("a");


            string element0= (string) archivos.GetElement(0);

            Console.WriteLine(element0);*/


            archivos.Agregar(new Empleado(1500));

            Empleado nombrePersona= (Empleado) archivos.GetElement(0);

            Console.WriteLine(nombrePersona.GetSaSalario());


        }
    }



    class AlmacenObjetos <T>
    {
        public AlmacenObjetos(int z) { 
        
        datosElemento= new T [z];
        
        }


        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T GetElement(int i)
        {
            return datosElemento[i];
        }

        private T [] datosElemento;
        private int i = 0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSaSalario()
        {
            return salario;
        }


        private double salario;

    }


}
