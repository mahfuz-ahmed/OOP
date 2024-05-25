using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Encapsulation
    {
        private string _firstName;
        private string _lastName;
        private string _gender;

        public string FirstName                                    // Property Declear
        {
            set 
            {
                if(value.Length >= 3)
                {
                    _firstName = value;
                }
            }
            get { return _firstName; }
        }

        public string LastName
        {
            set { _lastName = value; }
            get { return _lastName; }
        }

        public string Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        // Short Hand

        public string FatherName { set; get; }
        public string MotherName { set; get; }
    }
}
