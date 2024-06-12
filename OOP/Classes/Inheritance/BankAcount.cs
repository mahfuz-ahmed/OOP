using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Inheritance
{
    public class BankAcount :AcountTransfer
    {
        public BankAcount(string accountNumber, string customerName) : this() 
        {
            BankAccount = accountNumber;
            CustomerName = customerName;
        }
        public BankAcount() 
        {
            Balance = 0;
        }
        public string BankAccount {  get; set; }
        public string CustomerName {  get; set; }
        public double Balance {  get; private set; }       
        public string Deposit(double amount)
        {
            Balance += amount;
            return "Successfully amount added";
        }
        public virtual string Withdraw(double amount) 
        {
            Balance -= amount;
            return "Success Fully WithDraw: " +amount+"Tk, Your Current Balance: "+ Balance +"Tk";
        }

        // must be override abstruct Transfer method body in this method because inherit abstruct class
        public override void Transfer(string from, string to, double amount, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
    public abstract class AcountTransfer
    {
        public abstract void Transfer(string from, string to, double amount, DateTime date);

    }
}
