using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



//https://www.youtube.com/watch?v=VcCikX3J1F8
namespace Reflection
{
    internal class Reflection
    {
        static void Mainn(string[] args)
        {
            var keyboard = new Keyboard() {Name="k-06",brand="keygem", keys=106, County="USA" };
            var properities = typeof(Keyboard).GetProperties();

            foreach (var properity in properities)
            {
                string nameProperity = properity.Name;
                string type = properity.PropertyType.ToString();
                string value = properity.GetValue(keyboard).ToString();

                Console.WriteLine($"{nameProperity} {type} {value}");

            }

        }

        public class Keyboard
        {
            public string Name { get; set; }
            public string brand { get; set; }
            public int keys { get; set; }

            public string County { get; set; }

        }


    }
}
