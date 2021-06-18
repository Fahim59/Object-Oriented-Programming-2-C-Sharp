using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    abstract class Account
    {
        protected string accountHolderName;
        protected int accountNumber;
        protected int balance;

        public Account() { }

        public Account(string accountHolderName, int accountNumber, int balance)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Account Holder Name.");
                    return;
                }
                this.accountHolderName = value;
            }
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                this.accountNumber = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

        public virtual void Show_Info()
        {
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Available Balance: " + balance);
        }
    }
}