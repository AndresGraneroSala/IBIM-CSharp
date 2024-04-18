using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace serializacion
{
    internal class NewtonSoftJson
    {
        static void Mainn(string[] args)
        {
            SaveJson();
            LoadJson();
        }

        public static void SaveJson()
        {
            Person myPerson = new Person("Andres", 17, "20/05");
            string json = JsonConvert.SerializeObject(myPerson);
            File.WriteAllText("Objeto.txt", json);
        }

        public static void LoadJson() {
            string json = File.ReadAllText("Objeto.txt");
            Person person = JsonConvert.DeserializeObject<Person>(json);

            Console.WriteLine(person.Name);
        }

    }
}
