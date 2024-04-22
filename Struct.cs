namespace HelloWord
{
    internal class Struct
    {

        public static void Mainn(string[] args)
        {
            // crear una copia
            Estructura estructura = new Estructura("var1");

            estructura.variable1 = "cambiado";

            Console.WriteLine(estructura.variable1);




        }

    }


    public struct Estructura
    {
        public Estructura(string var1)
        {

            variable1 = var1;
        }

        public string variable1
        {
            get; set;
        }
    }

}
