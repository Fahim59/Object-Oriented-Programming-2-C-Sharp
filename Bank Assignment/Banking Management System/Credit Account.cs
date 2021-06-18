using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
	class Credit_Account : Account
	{
		//There is an extra credit limit for withdraw and for deposit there no limit
		int creditLimit = 5000;
		public Credit_Account(string accountHolderName, int accountNumber, int balance) : base(accountHolderName, accountNumber, balance)
		{
			
		}
		public override void Deposit(int amount)
		{
			if (amount > 0)
			{
				Console.WriteLine("\nPrevious Balance was: " + balance);
				Console.WriteLine(+amount + " $ Deposited...");

				balance = balance + amount;

				Console.WriteLine("Current Balance is: " + balance);
			}
			else
			{
				Console.WriteLine("\nCan Not Deposit...");
			}
		}

		/*public override void Withdraw(int amount)
		{
			if(amount < 0)
			{
				Console.WriteLine("\nCannot Withdraw,Invalid Or Insufficient Amount...");
			}
			else if(this.balance >= amount)
			{
				Console.WriteLine("\nPrevious Balance was: " + balance);
				Console.WriteLine(+amount + " $ Withdrawn...");

				this.balance = (this.balance - amount);

				Console.WriteLine("\nAvailable balance: " + this.balance);
				Console.WriteLine("\nExtra Limit: " + creditLimit);
			}
			else
			{
				int x = amount - this.balance;

				if (x <= this.creditLimit)
				{
					this.balance = 0;
					this.creditLimit -= x;
					Console.WriteLine("\nAvailable Balance: " + balance);
					Console.WriteLine("\nRemaining extra limit: " + creditLimit);
				}
				else
				{
					Console.WriteLine("\nSorry, this withdrawal would exceed the overdraft limit");
				}
			}
		}*/

		public override void Withdraw(int amount)
		{
			if(amount<0)
			{
				Console.WriteLine("\nSorry, you can not withdraw a negative amount.");
			}
			else if(this.balance - amount < -creditLimit)
			{
				Console.WriteLine("\nSorry, this withdrawal would exceed the credit limit");
			}
			else
			{
				this.balance = (this.balance - amount);
				Console.WriteLine("\n" +amount + " $ Withdrawn...");
				Console.WriteLine("\nAvailable Balance: " + balance);
			}
		}

		public override void Show_Info()
		{
			Console.WriteLine("\nAccount Type: Credit Account");
			base.Show_Info();
		}
	}
}