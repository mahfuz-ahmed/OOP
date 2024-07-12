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
            Assigning assign = new Assigning();
            assign.Person();
            assign.Constructor();
            assign.ValueAndRefferenceType();
            assign.Encapsulation();
            assign.AssociationRelationShip();
            assign.DepartmentRelationShip();
            assign.BankingSystem();
            assign.Interface();
            assign.DynamicDataType();
            assign.AnonymousType();
            Console.ReadLine(); 
        }
    }
}
