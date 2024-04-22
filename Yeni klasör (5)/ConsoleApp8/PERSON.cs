using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class PERSON
    {
        public string name {  get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public PERSON (string name, string Surname, byte Age)
        {
            this.name = name;
            this.Surname = Surname;
            this.Age = Age;
        }

    }
}
