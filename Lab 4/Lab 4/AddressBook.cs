using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class AddressBook
    {
        private String ownerName;
        private String info;
        private Contract [] listOfContract;

        public AddressBook()
        {
        }
        public AddressBook(String ownerName, String info)
        {
            this.ownerName = ownerName;
            this.info = info;
            this.listOfContract = new Contract[10];
        }

        public void showAllContractInfo()
        {
            Console.WriteLine("\n--- Address Book Info ---");
            Console.WriteLine("Owner Name: " + ownerName);
            Console.WriteLine("Owner Info: " + info);

            Console.WriteLine("---Contract Info---");
            for (int i = 0; i < listOfContract.Length; i++)
            {

                if (listOfContract[i] != null)    //if certain array index is NOT null, then show the info for that index
                {                         
                    listOfContract[i].showPersonInfo();
                }
            }
        }

        public void addContract(Contract con)
        {
            for (int i = 0; i < listOfContract.Length; i++)
            {
                if (listOfContract[i] == null)
                {
                    listOfContract[i] = con;
                    break;
                }
            }
        }

        public void deleteContract(Contract con)
        {
            for (int i = 0; i < listOfContract.Length; i++)
            {
                if (listOfContract[i] == con)
                {
                    listOfContract[i] = null;
                    break;
                }
            }
        }
    }
}
