using OOP.Classes.Inheritance;
using OOP.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Assigning
    {
        string fullName = string.Empty;

        public void Person()
        {
            Console.WriteLine("...Object Concept...");

            Person person = new Person();                                                // person is a refference in the  Person Type
            person.firstName = "Md.";
            person.middleName = "Mahfuz";
            //if(person.firstName.Length < 12)
            //{
            //    return;
            //}
            person.lastName = "Ahmed";
            fullName = person.FullName();
            Console.WriteLine("My Name is " + fullName);
            Console.WriteLine();

            //Refference Type / User Define Type
            Console.WriteLine("...Refference Type / User Define Type / Non-primitive...");
        }
        public void Constructor()
        {
            Constructor constructor = new Constructor("Md.", "Ahmed", "mahfuz@gmial.com");
            Constructor constructor1 = new Constructor("mahfuz@gmail.com");                 //Over Load Constructor
            fullName = constructor.MyDetails();
            Console.WriteLine(fullName);

            Constructor constructor2 = new Constructor();                                   // Call Default Constructor
            constructor2.FirstName = "Mahfuz";
            constructor2.LastName = "Default Constractor";
            fullName = constructor2.MyDetails();
            Console.WriteLine(fullName);
        }
        public void ValueAndRefferenceType()
        {
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

            Console.WriteLine("Second Number = " + secondNumber);
            Console.WriteLine("After Change firstNumber = " + firstNumber);
        }
        public void Encapsulation()
        {
            //Encapsulation / Property
            Console.WriteLine("...Encapsulation...");
            Encapsulation encapsulation = new Encapsulation("mahfuz", "ahmed");          // Calling by constructor
            //encapsulation.FirstName = "Mahfuz";
            encapsulation.FatherName = "Md.Nobis Uddin";
            string motherName = encapsulation.MotherName;                               // You can not set motherName here, just you can get motherName because setter is private
            Console.WriteLine("My Name: " + encapsulation.FirstName);
            Console.WriteLine("Father Name: " + encapsulation.FatherName);
        }
        public void AssociationRelationShip()
        {

            Information information = new Information();
            information.Village = "KodailKati";
            information.Thana = "Gangni";
            information.District = "Meherpur";
            information.NID = "12234566";

            Person person = new Person();
            person.firstName = "Md.";
            person.middleName = "Mahfuz";
            person.lastName = "Ahmed";
            person.information = information;

            Information information2 = information;         // Point to information refference
            Console.WriteLine(information2.Village);
            //Console.WriteLine(person.information.Thana);
            Console.WriteLine(person.PersonDetails());
        }
        public void DepartmentRelationShip()
        {
            Console.WriteLine();
            Console.WriteLine("Department and Courses");
            List<Course> courses = new List<Course>();

            Course course = new Course();
            course.Name = "Data Structure";
            course.Code = "DS-1";
            course.Credit = "3";
            courses.Add(course);

            Course course1 = new Course();
            course1.Name = "Algorithm";
            course1.Code = "Alg-1";
            course1.Credit = "3";
            courses.Add(course1);

            Department department = new Department();
            department.Name = "Computer Science and Engineering";
            department.Code = "CSE";
            department.courses = courses;

            department.getDepartment();
            department.getCourse();

        }
        public void BankingSystem()
        {
            Console.WriteLine();

            Console.WriteLine("Saving Account");

            SavingsAccount savingsAccount = new SavingsAccount("MH-12334","MahfuzAhmed",1000);
            //savingsAccount.BankAccount = "Mh-123455";
            //savingsAccount.CustomerName = "Mahfuz Ahmed";
            //savingsAccount.InterestAmount = 500;
            savingsAccount.Deposit(5000);
            Console.WriteLine(savingsAccount.Withdraw(1500));

            Console.WriteLine("Chgecking Account, No limit to withdrow mony");
            CheckingAccount checkingAccount = new CheckingAccount("MH-122333","Najmus Sakib",500);
            //checkingAccount.BankAccount = "Mh-45667889";
            //checkingAccount.ServiceCharge = 300;
            //checkingAccount.Deposit(1000);
            //Console.WriteLine(checkingAccount.Withdraw(5000));

            BankAcount bankAcount = new BankAcount();
            bankAcount.BankAccount = "1234-MH";
            bankAcount.CustomerName = "Sakib";
            bankAcount.Deposit(700);

            List<BankAcount> bankAcounts = new List<BankAcount>();   
            bankAcounts.Add(bankAcount);
            bankAcounts.Add(checkingAccount);
            bankAcounts.Add(savingsAccount);

            foreach (BankAcount acount in bankAcounts)   // Runtime Polymorphism // When get data from bankAcounts acount can deside its which type, savings/ Checking or Bank Account
            {
                acount.Withdraw(200);
            }

        }
        public void Interface()
        {
            string information;
            Student student = new Student();
            student.RegNo = "122222";
            information = student.GetInformation();
            Console.WriteLine(information);

            Courses courses = new Courses();
            information = courses.GetInformation();

            Departments departments = new Departments();
            information = departments.GetInformation();
        }

    }
}
