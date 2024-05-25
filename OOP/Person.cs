using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string firstName;   // Class Field/ Property / Atribute
        public string lastName;  // When it contain data that time its called instance variable

        public string FullName()
        {
            string fullName = firstName + " " + lastName ;
            return fullName;
        }

    }
}
