using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    // Non Static Class
    public class StaticStudent
    {
        // * Satatic keyword can be applyed classes,methods,property,variable,operator and constructor
        // * Non Static class allowed to declear static member or fields

        public int ID {  get; set; }
        public string Name { get; set; }
        public static int NumberOfStudent {  get; set; }        
    }

    // Static Class
    static class StaticStudentClass
    {
        // * Static Class only contained static field Ex: methods, property etc.
        // * Static Class can not allowed to create an object
        // * Static class is sealed class can not inherit from another class

        public static int ID { get; set; }
        public static string Name { get; set; }
        public static int NumberOfStudent { get; set; }
    }
}
