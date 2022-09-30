using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankAccountLibrary
{
    public abstract class IBankAccount
    {
        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
    }
}