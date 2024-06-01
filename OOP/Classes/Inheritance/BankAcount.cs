using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Inheritance
{
    public class BankAcount
    {
        public string BankAccount {  get; set; }
        public string CustomerName {  get; set; }
        public double Balance {  get; private set; }       
        public string Deposit(double amount)
        {
            SavingsAccount account = new SavingsAccount();
            double interest = account.InterestAmount;

            Balance += amount+interest;
            return "Successfully amount added";
        }
        public string Withdraw(double amount)
        {
            Balance -= amount;
            return "Successfully amount withdraw";
        }

    }
}
