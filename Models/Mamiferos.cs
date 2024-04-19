using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Models
{

    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        //metodo abstracto
        public abstract void GetNombre();
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena) { }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();
        bool esOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    class Lagartija : Animales
    {
        string nombreReptil;

        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }


        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil}");
        }
    }


    class Mamiferos: Animales
    {
        public Mamiferos(string nombre)
        {

            nombreSerVivo = nombre;
        }


        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de crias hasta ser mayores");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("pensamiento basico instintivo");
        }


        private String nombreSerVivo;

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) { }



        public void Galopar()
        {
            Respirar();
            Console.WriteLine("Capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "Hípica";
        }

        public bool esOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) { }

        //new para quitar advertencia

        public override void Pensar()
        {
            Console.WriteLine("pensamiento logico");
        }
    }

   


    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }


        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("pensamiento instintivo avanzado");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }

    // nadie puede heredar Chimpance
    sealed class Chimpance: Gorila
    {
        public Chimpance(string nombreChimpance):base(nombreChimpance)
        {

        }
    }
}
