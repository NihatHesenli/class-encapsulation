using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class HUMAN
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string gender { get; set; }
        public byte Age;
        private byte _age
        {
            get { return _age; }
            set
            {
                if (_age >= 18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("18 yasdan asagidir");

                }


            }

              }    }   } 

