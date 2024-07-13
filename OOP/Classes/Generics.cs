using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Generics<T>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public T IsAdmin { get; set; }
    }
}
