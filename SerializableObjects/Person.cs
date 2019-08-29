using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
   public class Person
    {
        public Person()
        {
            Cards = new List<Card>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public byte Age { get; set; }
        public string Email { get; set; }

        public List<Card> Cards { get; set; }
    }

}
