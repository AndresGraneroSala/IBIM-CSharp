using MongoDB.Driver.Core.Operations;
using System;


namespace POO
{
    public class Punto
    {
        public int x, y;

        private static int contadorDeObjetos = 0;

        public static int ContadorDeObjetos() => contadorDeObjetos;

        public const int constantePrueba=1;


        public Punto(int x,int y) {

            Console.WriteLine($"coordenada x:{x}, coordenada y:{y}");
            this.x = x; 
            this.y = y;
            contadorDeObjetos++;
        }

        public Punto() {

            Console.WriteLine("Por defecto");
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto destino)
        {
            int xDif= this.x - destino.x;
            int yDif= this.y - destino.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif,2));
            return distanciaPuntos;

        }


    }
}

