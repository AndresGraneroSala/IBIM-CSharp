using MongoDB.Bson;
using MongoDB.Driver;
using System;


namespace mongodb
{


	public class MongoDB
	{
        static void Mainn(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("school");

            var peopleDB = database.GetCollection<People>("people");

            var myPeople = new People() {Name="Andrés nuevo",Age=17,Id= "661e54e9f107bf881aa0a6a9" };
                
            //peopleDB.InsertOne(myPeople);


            /* List<People> peopleList = peopleDB.Find(d => true).ToList();

             foreach (People people in peopleList)
             {
                 Console.WriteLine(people.Name);
             }*/


            //peopleDB.ReplaceOne(d => d.Id == "661e54e9f107bf881aa0a6a9", myPeople);

            peopleDB.DeleteOne(d=>d.Id== "661e54e9f107bf881aa0a6a9");

        }




    }
}