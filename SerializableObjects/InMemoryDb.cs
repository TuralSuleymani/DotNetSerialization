using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
   public class InMemoryDb
    {
        public List<Person> People { get; set; }
        public List<Card> Cards { get; set; }
        public InMemoryDb()
        {
            #region initialize datas

            Cards = new List<Card>
            {
                new Card
                {
                     Id  =1,
                      CardHolder = "MR. IZUKU MIDORIYA",
                       CVC  = 456,
                        ExpireDate  = DateTime.Now.AddYears(2),
                          Number = "1234-1234-1234"

                },
                 new Card
                {
                     Id  =2,
                      CardHolder = "MR. IZUKU MIDORIYA",
                       CVC  = 233,
                        ExpireDate  = DateTime.Now.AddYears(2),
                          Number = "1234-1234-1234"

                },
                  new Card
                {
                     Id  =3,
                      CardHolder = "MR. SHOTO TODOROKI",
                       CVC  = 788,
                        ExpireDate  = DateTime.Now.AddYears(2),
                          Number = "1999-1999-1999-1993"

                }
            };

            People = new List<Person>
            {
                new Person
                {
                      Id = 1,
                      Age = 34,
                      Email = "izuku@gmail.com",
                      Name ="Izuku",
                      Surname = "Midoriya",
                       Cards = new  List<Card>
                       {
                           Cards[0],Cards[1]
                       }
                       
                },
                  new Person
                {
                      Id = 2,
                      Age = 24,
                      Email = "katsumi@gmail.com",
                      Name ="Katsumi",
                      Surname = "Bakugo"
                },
                   new Person
                {
                      Id = 3,
                      Age = 34,
                      Email = "shoto@gmail.com",
                      Name ="Shoto",
                      Surname = "Todoroki",
                       Cards = new List<Card>
                       {
                            Cards[2]
                       }
                }
            };

         
            #endregion
        }

    }
}
