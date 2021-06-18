using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Contract
    {
        private String personName, personId, mobileNumber;
        private int age;
        private char gender;

        public Contract()
        {
        }

        public Contract(String personName,String personId,String mobileNumber,int age,char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.mobileNumber = mobileNumber;
            this.age = age;
            this.gender = gender;
        }

        public void showPersonInfo()
        {
            Console.WriteLine("\n--- Person Info ---");
            Console.WriteLine("Person Name: " + personName);
            Console.WriteLine("Person Id: " + personId);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Mobile Number: " + mobileNumber);
        }

        public void detectMobileOperator()
        {
            if(mobileNumber[5] == '1')
          {
			Console.WriteLine("\nMobile Operator is Citycell");
		  }
            else if(mobileNumber[5] == '5')
          {
			Console.WriteLine("\nMobile Operator is Teletalk");
		  }
		    else if(mobileNumber[5] =='6')
          {
			Console.WriteLine("\nMobile Operator is Airtel");
		  }
            else if(mobileNumber[5] == '7')
          {
			Console.WriteLine("\nMobile Operator is Grameenphone");
		  }
            else if(mobileNumber[5] == '9')
          {
			Console.WriteLine("\nMobile Operator is Banglalink");
		  }
		    else
          {
              Console.WriteLine("\nInvalid Number");
		  }
        }
    }
}
