using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Constructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Constructor() { }                                    //Default Constructor

        public Constructor(string firstName, string lastName)       //Constructor Perameter
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Constructor(int age)                                 //Constructor Overload
        {
            Age = age;
        }

        public string MyDetails()
        {
            string fullName = FirstName +" "+ LastName;
            return fullName;
        }
    }
}
