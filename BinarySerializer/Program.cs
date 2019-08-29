using SerializableObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            InMemoryDb db = new InMemoryDb();
            List<Person> people = db.People;

            BinaryFormatter serializeAsBinary = new BinaryFormatter();
            using (FileStream fs = new FileStream("personInfo.dat", FileMode.OpenOrCreate))
            {
                serializeAsBinary.Serialize(fs, people);
            }

            List<Person> peopleDeserialized = new List<Person>();
            using (FileStream fs = new FileStream("personInfo.dat", FileMode.OpenOrCreate))
            {
                peopleDeserialized = (List<Person>)serializeAsBinary.Deserialize(fs);
            }

            Console.WriteLine(peopleDeserialized[0].Name);
            Console.ReadLine();
        }
    }
}
