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
        public int Age { get; set; }
        public Constructor() { }

        public Constructor(string firstName)
        {
            FirstName = firstName;
        }
        public Constructor(int age)
        {
            Age = age;
        }

        public void MyDetails()
        {
            string firstName = FirstName;
            int age = Age;
            Console.WriteLine(age);
        }
    }
}
