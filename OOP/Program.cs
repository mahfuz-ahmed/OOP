using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Mahfuz";
            person.lastName = "Ahmed";
            Console.WriteLine(person.FullName());

            Console.ReadLine();
        }
    }
}
