using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Book
    {
        private String bookName, bookType, bookAuthor, bookId;
        private int bookCopy;
        private static int bookCounter;

        public Book()
        {
            bookCounter++;
        }
        public Book(String bookName, String bookType, String bookAuthor, String bookId, int bookCopy)
        {
            this.bookName = bookName;
            this.bookType = bookType;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookCopy = bookCopy;
            bookCounter++;
        }

        public void setBookName(String bookName)
        {
            this.bookName = bookName;
        }
        public void setBookType(String bookType)
        {
            this.bookType = bookType;
        }
        public void setbookAuthor(String bookAuthor)
        {
            this.bookAuthor = bookAuthor;
        }
        public void setBookId(String bookId)
        {
            this.bookId = bookId;
        }
        public void setBookCopy(int bookCopy)
        {
            this.bookCopy = bookCopy;
        }

        public void showInfo()
        {
            Console.WriteLine("\n--- Book Info ---");
            Console.WriteLine("Book Name: "+bookName);
            Console.WriteLine("Book Id: " + bookId);
            Console.WriteLine("Book Type: " + bookType);
            Console.WriteLine("Book Author: " + bookAuthor);
            Console.WriteLine("Book Copy: " + bookCopy);
        }

        public void addBookCopy(int x)
        {
            Console.WriteLine("\nPrevious Book Copy: " + bookCopy);
            bookCopy += x;
            Console.WriteLine("Current Book Copy: " + bookCopy);
        }

        public static void showTotalBookInfo()
        {
		    Console.WriteLine("\nTotal Book Objects: " +bookCounter);
	    }
    }
}
