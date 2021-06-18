using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Account
    {
        private String accName, acId;
        private int balance;

        public Account(String accName, String acId, int balance)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
        }

        public void setAccName(String accName)
        {
            this.accName = accName;
        }
        public void setAcId(String acId)
        {
            this.acId = acId;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public String getAccName()
        {
            return this.accName;
        }
        public String getAcId()
        {
            return this.acId;
        }
        public int getBalance()
        {
            return this.balance;
        }

        public void showInfo()
        {
            Console.WriteLine("\n---Account Info---");
            Console.WriteLine("Account Holder Name: " + accName);
            Console.WriteLine("Account Id: " + acId);
            Console.WriteLine("Balance: " + balance);
            //Console.ReadLine();
        }

        public void deposit(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " Deposited");

                balance += amount;

                Console.WriteLine("\nCurrent Balance is: " + balance);
            }
            else
            {
                Console.WriteLine("\nSomething wrong, Can not deposit money...");
                //Console.ReadLine();
            }
        }

        public void withdraw(int amount)
        {
            if (amount > 0 && balance > amount)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " Withdrawn");

                balance -= amount;

                Console.WriteLine("\nCurrent Balance is: " + balance);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nSomething wrong, Can not withdraw money...");
                //Console.ReadLine();
            }
            
        }

        public void transfer(int amount, Account receiver)
        {
            if (amount > 0 && balance > amount)
            {
                Console.WriteLine("\nPrevious Balance was: " + balance);
                Console.WriteLine(+amount + " Transfered");

                balance -= amount;
                receiver.balance = receiver.balance + amount;

                Console.WriteLine("\nCurrent Balance is: " + balance);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nCan Not Transfer,Invalid Or Insufficient Amount...");
                //Console.ReadLine();
            }
        }
    }
}
