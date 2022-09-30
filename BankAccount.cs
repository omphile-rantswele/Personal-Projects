using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankAccountLibrary
{
    public class BankAccount : IBankAccount
    {
        private double balance;


        public BankAccount(double amount)
        {
            balance = amount;
        }


        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("The amount has been deposited.");


        }


        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("The amount has been withdrawed.");
            }
        }


        public void DisplayCurrentBalance()
        {
            Console.WriteLine("The current balance of the account is: {0}", balance);
        }
    }
}
