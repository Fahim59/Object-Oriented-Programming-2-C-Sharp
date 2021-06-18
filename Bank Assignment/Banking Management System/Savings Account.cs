using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    class Savings_Account : Account
    {
        //Cannot withdraw if balance is zero and for deposit there is a limit
        public Savings_Account(string accountHolderName, int accountNumber, int balance) : base(accountHolderName, accountNumber, balance)
        {
            
        }

        public override void Deposit(int amount)
        {
            if (amount > 0 && amount == 10000)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " $ Deposited...");

                balance = balance + amount;

                Console.WriteLine("Current Balance is: " + balance);
            }
            else
            {
                Console.WriteLine("\nCan Not Deposit, Either Invalid Amount or Deposit Amount Limit didnot Satisfy...");
            }
        }

        public override void Withdraw(int amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " $ Withdrawn...");

                balance = balance - amount;

                Console.WriteLine("Current Balance is: " + balance);
            }
            else
            {
                Console.WriteLine("\nCannot Withdraw,Invalid Or Insufficient Amount...");
            }
        }

        public override void Show_Info()
        {
            Console.WriteLine("\nAccount Type: Savings Account");
            base.Show_Info();
        }
    }
}