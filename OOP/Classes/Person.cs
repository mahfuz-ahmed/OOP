    using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Person
    {
        public string firstName;                        // Class Field/ Property / Atribute
        public string middleName;
        public string lastName;                         // When it contain data that time its called instance variable
        public Information information  { get; set; }   // AssociationRelationShip

        public string FullName()
        {
            string fullName = firstName + " "+ middleName +" "+ lastName ;
            return fullName;
        }
        
        public string PersonDetails()
        {
            string fullName = FullName();
            string details = fullName + " " +information.Village+" "+ information.Thana + " " + information.District;
            return details;
        }

    }
}
