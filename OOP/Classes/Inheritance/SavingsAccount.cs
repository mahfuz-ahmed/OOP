﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Inheritance
{
    public class SavingsAccount:BankAcount
    {
        public double InterestAmount { get; set; }

        public override string Withdraw(double amount)  // When Call from saving account instance, at this time call this withdraw override method, not call to BankAccount withdraw method
        {                                               
            if(Balance>= amount)
            {
               return base.Withdraw(amount);
            }
            return "Insufficient Balance, Your Current Balance: " + Balance + "Tk, Your Withdraw Amount:" + amount + "Tk";
        }
    }
}
