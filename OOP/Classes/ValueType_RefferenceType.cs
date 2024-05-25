using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class ValueType_RefferenceType
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string FullName()
        {
            string fullName = firstName+" "+middleName+" "+lastName;
            return fullName;
        }
    }
}
