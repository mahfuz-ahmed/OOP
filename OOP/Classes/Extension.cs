using OOP.Classes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    static class Extension
    {
        // Must be have static class and method for extension
        // must be declear this keyword before first perameter

        public static string getInfo(this Student student)
        {
            return student.Name+" "+ student.Email+" "+student.Roll;
        } 
    }
}
