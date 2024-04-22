namespace GenericosRestricciones
{
    internal class GenericosRestricciones
    {

        public static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados= new AlmacenEmpleados<Director> (3);
            empleados.Agregar(new Director(4500));

            AlmacenEmpleados<Secretaria> empleados2 = new AlmacenEmpleados<Secretaria>(3);
            empleados.Agregar(new Director(4500));


            AlmacenEmpleados<Electricista> empleados3 = new AlmacenEmpleados<Electricista>(3);
            empleados.Agregar(new Director(4500));


            //No puede porque no tiene la interfaz (salario)
            //AlmacenEmpleados<Estudiante> empleados4 = new AlmacenEmpleados<Estudiante>(3);


        }


    }


    //objetos obligados a tener interfaz
    class AlmacenEmpleados<T> where T : IParaEmpleados
    {

        public AlmacenEmpleados(int z)
        {
            datosEmpleados= new T[z];
        }

        private int i = 0;

        private T[] datosEmpleados;

        public void Agregar(T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T GetEmpleado(int i)
        {
            return datosEmpleados[i];
        }


    }

    class Director : IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;


        }

        private double salario;

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;


        }

        private double salario;

        public double GetSalario()
        {
            return salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;


        }

        private double salario;

        public double GetSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        private double GetEdad()
        {
            return edad;
        }

        private double edad;



    }


    interface IParaEmpleados
    {
        double GetSalario();
    }

}
