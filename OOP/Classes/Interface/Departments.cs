using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Interface
{
    public class Departments: IInformation
    {
        public Departments() 
        {
            Students = new List<Student>();
            Courses = new List<Courses>();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        List<Courses> Courses { get; set; }
        List<Student> Students { get; set; }

        public string GetInformation()
        {
            return Code + " " + Name ;
        }
    }
}
