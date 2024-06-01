using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Inheritance
{
    public class CheckingAccount: BankAcount
    {

        public CheckingAccount(string accountNumber,string customerName, double serviceCharge): base(accountNumber,customerName)   // constructor chaining pass to base class common property value
        {
            //BankAccount = accountNumber;
            //CustomerName = customerName;
            ServiceCharge = serviceCharge;
        }

        public double ServiceCharge { get; set; }
    }
}
