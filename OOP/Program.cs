using OOP.Classes;
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
            string fullName;
            // Object
            Console.WriteLine("...Object Concept...");

            Person person = new Person();                                                // person is a refference in the  Person Type
            person.firstName = "Md.";
            person.middleName = "Mahfuz";
            person.lastName = "Ahmed";
            fullName = person.FullName();
            Console.WriteLine("My Name is "+fullName);
            Console.WriteLine();

            //Refference Type / User Define Type
            Console.WriteLine("...Refference Type / User Define Type / Non-primitive...");

            ValueType_RefferenceType refferenceType1 = new ValueType_RefferenceType();   // Create New instance or empty object in the memory
            refferenceType1.firstName = "Abdul";                                         // Initializing value in the empty object
            refferenceType1.middleName = "Rahman";
            refferenceType1.lastName = "Shohag";
            fullName = refferenceType1.FullName();
            Console.WriteLine(fullName);
            Console.WriteLine();

            ValueType_RefferenceType refferenceType2 = new ValueType_RefferenceType();   // Create New instance or empty object in the memory
            refferenceType2.firstName = "Md.";                                           // Initializing value in the empty object
            refferenceType2.middleName = "Mohidul";
            refferenceType2.lastName = "Islam";
            fullName = refferenceType2.FullName();
            Console.WriteLine(fullName);
            Console.WriteLine();

            ValueType_RefferenceType refferenceType3 = refferenceType1;                 // This refference indicate to refferenceType1 Object

            refferenceType3.lastName = "Changed";                                       // LastName changed in the refferenceType1 object

            fullName = refferenceType1.FullName();                                      // Here Changed the value in the refferenceType1 Object
            Console.WriteLine(fullName);
            fullName = refferenceType3.FullName();                                      // Those refference indicate to the same object thats whay, if change any refferences changed to both
            Console.WriteLine(fullName);
            Console.WriteLine();

            //Value Type 
            Console.WriteLine("...Value Type / Premitive Type...");
            int firstNumber = 200;
            int secondNumber = firstNumber;                                             // Create a new memory location for second number, so if change to firsNumber not empact to secondNumber
            firstNumber = 500;

            Console.WriteLine("Second Number = "+secondNumber);
            Console.WriteLine("After Change firstNumber = "+firstNumber);


            //Encapsulation / Property
            Console.WriteLine("...Encapsulation...");
            Encapsulation encapsulation = new Encapsulation("mahfuz","ahmed");          // Calling by constructor
            //encapsulation.FirstName = "Mahfuz";
            encapsulation.FatherName = "Md.Nobis Uddin";
            string motherName = encapsulation.MotherName;                               // You can not set motherName here, just you can get motherName
            Console.WriteLine("My Name: "+ encapsulation.FirstName);
            Console.WriteLine("Father Name: "+encapsulation.FatherName);


            Constructor constructor = new Constructor("Md.","Ahmed");
            fullName = constructor.MyDetails();
            Console.WriteLine(fullName);

            Console.ReadLine(); 
        }
    }
}
