using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Mobile
    {
        private String mobileOwnerName, mobileNumber, mobileOsName;
        private double mobileBalance;
        private Boolean lockk;

        public Mobile()
        {
        }

        public Mobile(String mobileOwnerName, String mobileNumber, String mobileOsName, double mobileBalance, Boolean lockk)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.mobileOsName = mobileOsName;
            this.mobileBalance = mobileBalance;
            this.lockk = lockk;
        }

        public void showInfo()
        {
            if (lockk == false)
            {
                Console.WriteLine("\n--- Mobile Info ---");
                Console.WriteLine("Mobile Owner Name: " + mobileOwnerName);
                Console.WriteLine("Mobile Number: " + mobileNumber);
                Console.WriteLine("Mobile Balance: " + mobileBalance);
                Console.WriteLine("Mobile OS Name: " + mobileOsName);
                Console.WriteLine("Lock Status :" + lockk);
            }
            else
            {
                Console.WriteLine("\nMobile is locked. Unlock it first...");
            }
        }

        public void recharge(int amount)
        {
            if (lockk == false)
            {
                Console.WriteLine("\nPrevious Balance: "+mobileBalance);

                mobileBalance += amount;

                Console.WriteLine("Current Balance: " + mobileBalance);
            }
            else
            {
                Console.WriteLine("\nMobile is locked. Unlock it first...");
            }
        }

        public void callSomeone(double timeDuration)
        {
            if (lockk == false && mobileBalance >= timeDuration*1)
            {
                Console.WriteLine("\nCall duration was " + timeDuration + " minutes and Cost is " + timeDuration * 1 + " taka");
                mobileBalance = mobileBalance - (timeDuration * 1);
                Console.WriteLine("Current Balance: " + mobileBalance);
            }
            else if (lockk == false && mobileBalance < timeDuration * 1)
            {
                Console.WriteLine("\nInsifficient Balance...");
            }
            else
            {
                Console.WriteLine("\nMobile is locked. Unlock it first...");
            }
        }
    }
}
