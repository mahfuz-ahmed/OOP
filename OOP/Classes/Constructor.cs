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
        public string Email { get; set; }

        public Constructor(string firstName, string lastName, string email):this(email)       //Constructor Perameter  //Constructor Chaining
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Constructor(string email) : this()                                //Constructor Overload  //Constructor Chaining
        {
            Email = email;
        }
        public Constructor() { }                                           //Default Constructor

        public string MyDetails()
        {
            string fullName = FirstName +" "+ LastName +" "+ Email;
            return fullName;
        }
    }
}
