using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
   public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public ushort CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CardHolder { get; set; }
      
    }
}
