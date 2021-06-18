using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings_Account s1 = new Savings_Account("Mustafizur Rahman", 111, 5000);

            Current_Account c1 = new Current_Account("Marufuzzaman Rahat", 112, 5000);

            Credit_Account cr1 = new Credit_Account("Faysal Hasan", 113, 5000);

            s1.Deposit(10000);            //10000 is the deposit limit.
            s1.Deposit(10500);           //Limit crossed, cannot deposit.

            s1.Withdraw(15000);        //Can withdraw money until balance is zero.
            s1.Withdraw(500);         //Balance is zero. So, cannot withdraw anymore.

            s1.Show_Info();

            c1.Deposit(5000);            //No limit for deposit, any positive amount can be deposited.

            c1.Withdraw(10000);        //Can withdraw money until balance is zero.
            c1.Withdraw(500);         //Balance is zero. So, cannot withdraw anymore.

            c1.Show_Info();

            cr1.Deposit(5000);           //No limit for deposit, any positive amount can be deposited.

            cr1.Withdraw(10000);       //Can withdraw money until balance is zero.
            cr1.Withdraw(5000);       //Can withdraw money with extra credit limit.
            cr1.Withdraw(6000);      //Limit crossed with extra limit, cannot withdraw money anymore.
            //cr1.Withdraw(15001);
            cr1.Show_Info();
        }
    }
}