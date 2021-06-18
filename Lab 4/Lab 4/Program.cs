using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("Object Oriented Programming 2", "Programming Language", "Micheal Jhon", "b-001", 10);
            Book b2 = new Book();

            b2.setBookName("Object Oriented Programming 1");
            b2.setBookType("Programming Language");
            b2.setbookAuthor("Micheal Jhon");
            b2.setBookId("b-002");
            b2.setBookCopy(20);

            b1.showInfo();
            b1.addBookCopy(5);
            
            b2.showInfo();
            b2.addBookCopy(5);

            Book.showTotalBookInfo();

            Contract c = new Contract("Mustafizur Rahman", "P-001", "+8801686026037", 25, 'M');
            c.showPersonInfo();
            c.detectMobileOperator();

            Mobile m = new Mobile("Mustafizur Rahman", "+8801686026037", "Airtel", 50, false);
            m.showInfo();
            m.recharge(20);
            m.callSomeone(45.75);

            Library l = new Library("Modern Library", "48-2, Bashabo, Dhaka");

            Book b10 = new Book("Data Structure","Jahid Uddin Ahmed","101-A","Education",10);
		    Book b20 = new Book("Algorithm","Manzurul Hasan","102-B","Education",15);
		    Book b30 = new Book("Java","Mohaimen Noor","103-C","Education",5);

            l.addNewBook(b10);
            l.addNewBook(b20);
            l.addNewBook(b30);

            l.showLibInfo();

            l.deleteBook(b10);

            l.showLibInfo();

            l.addNewBookCopy(b20, 5);

            l.showLibInfo();

            AddressBook a = new AddressBook("Fahim Shahriar", "Personal Contract");

            Contract c1 = new Contract("Abir", "11", "01686026037", 26, 'M');
            Contract c2 = new Contract("Ahana", "12", "01686026037", 22, 'F');
            Contract c3 = new Contract("Babul", "13", "01686026037", 28, 'M');
            Contract c4 = new Contract("Bubli", "14", "01686026037", 34, 'F');

            a.addContract(c1);
            a.addContract(c2);
            a.addContract(c3);
            a.addContract(c4);

            a.showAllContractInfo();

            a.deleteContract(c4);

            a.showAllContractInfo();
        }
    }
}
