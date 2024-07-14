using OOP.Classes.Inheritance;
using OOP.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

            SavingsAccount savingsAccount = new SavingsAccount("MH-12334", "MahfuzAhmed", 1000);
            //savingsAccount.BankAccount = "Mh-123455";
            //savingsAccount.CustomerName = "Mahfuz Ahmed";
            //savingsAccount.InterestAmount = 500;
            savingsAccount.Deposit(5000);
            Console.WriteLine(savingsAccount.Withdraw(1500));

            Console.WriteLine("Chgecking Account, No limit to withdrow mony");
            CheckingAccount checkingAccount = new CheckingAccount("MH-122333", "Najmus Sakib", 500);
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

            Student student2 = new Student();
            student.RegNo = "122222";
            information = student.GetInformation();
            Console.WriteLine(information);

            Courses courses = new Courses();
            information = courses.GetInformation();

            Departments departments = new Departments();
            information = departments.GetInformation();
        }
        public void StudentCollection()
        {
            string information;
            Student student = new Student();
            student.RegNo = "122222";
            information = student.GetInformation();
            Console.WriteLine(information);

            Student student2 = new Student();
            student.RegNo = "122222";
            information = student.GetInformation();
            Console.WriteLine(information);

            List<Student> studentList = new List<Student>()
            {
                student, student2
            };
            studentList.Add(student2);
            studentList.Add(student);
        }
        public void VarKeyWord()
        {
            var name = "Mahfuz Ahemd"; //string
            var id = 112244; // int
            var IsAdmin = true; //boolean

            // Var vs Dynamic
            // * Var is static type Dynamic is dynamic type
            // * Var is compiler type Dynamic is run type 
            // * Must be innitialize value When declear Var Dynamic type no need to assign value in the declaration time.

        }
        public void DynamicDataType()
        {
            dynamic dynamicVariable = 1; // dynamic data type is run time data type. its work like obejct. dynamic keyword is this syntex.
            Console.WriteLine(dynamicVariable + " Type is " + dynamicVariable.GetType());
            dynamicVariable = "Mahfuz Ahmed"; // Thats possible first assign int and second time assign string type.
            Console.WriteLine(dynamicVariable + " Type is " + dynamicVariable.GetType());
            dynamicVariable = true;
            Console.WriteLine(dynamicVariable + " Type is " + dynamicVariable.GetType());

            dynamicVariable = new Student();   // its possible to refer object in the dynamicVariable referance
            dynamicVariable.Email = "mahfuz@gmail.com"; // if you refer any specific object must be match to propertyName and type

            // Here is dynamic object create no need to match property name and type you can declear property name and type for your need

            dynamicVariable = new ExpandoObject();
            dynamicVariable.Name = "Mahfuz Ahmed";
            dynamicVariable.ID = 171336;
            dynamicVariable.IsAdmin = true;

            Console.WriteLine(dynamicVariable.Name + " " + dynamicVariable.IsAdmin);

        }
        public void AnonymousType()
        {
            // * it's derrived from System.object Class
            // * It can contain read only property
            // * Its a referance type
            // * VS inteligency supported 

            // * Limitation....
            // * can not initialize a null value
            // * does not declear class member such as methods

            var anonyMosuTypeStudent = new
            {
                Name = "Mahfuz Ahmed",
                Id = 171,
                IsAdmin = true,
            };
            Console.WriteLine(anonyMosuTypeStudent.Name);

            // AnonymousList
            // * Must be follow declear property sequence and data type
            var anonymousStudentList = new[]
            {
                new{Name="Mahfuz",Id=12354,IsAdmin=true},
                new{Name="Mahfuz",Id=12354,IsAdmin=true},
            };

            foreach (var anonymousStudent in anonymousStudentList)
            {
                Console.WriteLine(anonymousStudent.Name);
                Console.WriteLine(anonymousStudent.Id);
                Console.WriteLine(anonymousStudent.IsAdmin);
            }

        }
        public void Enum()
        {
            // * Enumaration (enums) is a strongly Typed constants
            // * enums make code more readable and understandable
            // * Its Can be defined using the enum keyword

            Console.WriteLine((int)Enumeration.Approved);
            Console.WriteLine((int)Enumeration.Pending);
            Console.WriteLine((int)Enumeration.Delayed);

            var approvedStatus = 0;

            if (approvedStatus == (int)Enumeration.Approved)
            {
                Console.WriteLine("File Approved Completed");
            }

        }
        public void StaticAssign()
        {
            //Non Static Class

            StaticStudent.NumberOfStudent = 10;    // Static field is the class level field when declear class show there static field 
            StaticStudent staticStudent = new StaticStudent();
            staticStudent.Name = "Mahfuz";
            staticStudent.ID = 1;
            //staticStudent.NumberOfStudent = 10;  // you can't assign static field by create an instance.

            //Static Class Can't Crate Object
            StaticStudentClass.Name = "Mahfuz Ahmed";
            StaticStudentClass.ID = 1;
            StaticStudentClass.NumberOfStudent = 10;
        }
        public void GenericType()
        {
            // * IsAdmin is generic type. Its support multiple data type when call must be declear what kind of type you want
            Generics<int> generics = new Generics<int>();
            generics.ID = 1010;
            generics.Name = "Mahfuz Ahmd";
            generics.IsAdmin = 1;

            var generics1 = new Generics<string>()
            {
                ID = 1010,
                Name = "Mahfuz Ahmed",
                IsAdmin = "True-String",
            };

            var generics2 = new Generics<bool>()
            {
                ID = 1010,
                Name = "Mahfuz Ahmed",
                IsAdmin = true,

            };

            GenericTypePrint(generics);
            GenericTypePrint(generics1);
            GenericTypePrint(generics2);

            //Console.WriteLine(generics.ID +" "+ generics.Name+" "+ generics.IsAdmin);
            //Console.WriteLine(generics1.ID +" "+ generics1.Name+" "+ generics1.IsAdmin);
            //Console.WriteLine(generics2.ID +" "+ generics2.Name+" "+ generics2.IsAdmin);

        }
        public void GenericTypePrint<T>(Generics<T> generics)
        {
            // * recive multyple data type in this method
            Console.WriteLine(generics.ID + " " + generics.Name + " " + generics.IsAdmin);
        }
        public void DelegatesAssign()
        {
            // * Delegates can pass method as parameter
            // * It's Use to call back method

            //....Define Delegates.....//
            // * Set a targed method
            // * Invoke delegate
            // * Delegate method and targed Method have same type of parameter

            //...Type Of Delegates...//
            // * Single Delegate
            // * Multicast Delegate
            // * Generic Delegate

            DelegateCalculator calculator = AddMethod;  // Sigle Delegate
            InvokeDelegates(calculator,12,12);

            DelegateCalculator calculator1 = SubMethod;
            InvokeDelegates(calculator1,12,12);
            //var result = calculator.Invoke(12, 12);
            //Console.WriteLine("Delegate Method Result: "+result);
        }

        public delegate int DelegateCalculator(int firstNumber, int secondNumber);
        public int AddMethod(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public int SubMethod(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public void InvokeDelegates(DelegateCalculator calculator,int fName, int sName)
        {
            int result = calculator.Invoke(fName, sName);
            Console.WriteLine("Delegate Method Result: " + result);

        }
        public void Extension()
        {
            Student student = new Student();
            student.Name = "Mahfuz Ahmed";
            student.Email = "mahfuz@gmail.com";
            student.Roll = "1234";

            var info = student.getInfo();
            Console.WriteLine("Extension Person Class: "+info);
        }
    }
}
