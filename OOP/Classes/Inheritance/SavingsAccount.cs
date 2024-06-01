using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Inheritance
{
    public class SavingsAccount:BankAcount
    {
        public double InterestAmount { get; set; }
        
        public double Totalbalance()
        {
            return Balance + InterestAmount;
        }
    }
}
