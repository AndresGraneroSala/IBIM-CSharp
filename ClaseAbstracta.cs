using HelloWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal class ClaseAbstracta
    {

        public static void Mainn(string[] args)
        {
            Lagartija Juancho = new Lagartija("Juancho");
            Juancho.GetNombre();
            Juancho.Respirar();

            Humano Juan = new Humano("Juan");
            Juan.GetNombre();
            Juan.Respirar();

        }

    }






}
