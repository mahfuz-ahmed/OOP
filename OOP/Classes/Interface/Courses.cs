using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Interface
{
    public class Courses:IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }

        public string GetInformation()
        {
            return Code + " " + Name + " " + Credit;
        }
    }
}
