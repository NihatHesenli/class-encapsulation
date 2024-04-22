using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class DOCTOR:HUMAN
    {
        public string Speciality {  get; set; }
        public string experience;
        private string _experience
        {
            get { return _experience; }
            set
            {
                experience = value;
            }

        }
        public void GetInfo();

            
            
            

    }
}
