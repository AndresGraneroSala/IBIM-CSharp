using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace serializacion
{
    public class Serializacion
    {
        static void Mainm(string[] args)
        {
            SaveJson();
            LoadJson();
        }

        public static void SaveJson()
        {
            Person myPerson = new Person("Andres", 17, "20/05");
            string miJson = JsonSerializer.Serialize(myPerson);
            File.WriteAllText("objeto.txt", miJson);
        }

        public static void LoadJson()
        {
            string miJson= File.ReadAllText("objeto.txt");
            Person person = JsonSerializer.Deserialize<Person>(miJson);
            Console.WriteLine(person.Name);
        }

    }


    public class Person
    {
        public Person(string name, int age, string birthday)
        {

            Name = name;
            Age = age;
            Birthday = birthday;

        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
    }
}