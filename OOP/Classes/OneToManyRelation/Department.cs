using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes 
{ 
    public class Department
    {
        public string Name {  get; set; }
        public string Code { get; set; }
        public List<Course> courses { get; set; }

        string space = " ";
        public void getDepartment()
        {
            string department = Name + space + Code;
            Console.WriteLine("Department:"+space+ department);

        }
        public void getCourse()
        {
            foreach (var course in courses)
            {
                Console.WriteLine("Course Name:"+space+course.Name+space+course.Code+space+course.Credit);
            }
        }
    }
}
