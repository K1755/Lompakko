using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Card
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Owner { get; set; }

        public override string ToString()
        {
            return Name + ", Numero: " + Number + ", Haltija: " + Owner;
        }
    }
}
