using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Encapsulation
    {

        // Constructor
        public Encapsulation(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private string _firstName;                              // class field
        private string _lastName;
        private string _gender;


        public string FirstName                                // Property Declear
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

        public string FullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        // Short Hand / Auto Property

        public string FatherName { set; get; }              // No need to declear field
        public string MotherName { private set; get; }      // If you want to private property you can do it 
    }
}
