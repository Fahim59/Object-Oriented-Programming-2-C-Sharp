using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Library
    {
        private String libName, libAddress;
        private Book[] listOfBooks;
        private int totalBook;

        public Library()
        {
        }

        public Library(String libName, String libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.listOfBooks = new Book[10];
            this.totalBook = 0;
        }

        public void showLibInfo()
        {
            Console.WriteLine("\n--------------------Library Information-------------------");
            Console.WriteLine("\nName of Library: " + libName + "\nAddress: " + libAddress);
            Console.WriteLine("\n----------------------Book Information-------------------");

            for (int i = 0; i < totalBook; i++)
            {
                listOfBooks[i].showInfo();
            }
        }

        public void addNewBook(Book book)
        {
            if (totalBook < listOfBooks.Length)
            {
                listOfBooks[totalBook++] = book;
                Console.WriteLine("\nBook Inserted Successfully...");
            }
            else
            {
                Console.WriteLine("\nSomething Wrong, Book Cannot be Inserted...");
            }
        }

        public void deleteBook(Book book)
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (listOfBooks[i] == book)
                {
                    listOfBooks[i] = listOfBooks[totalBook - 1];
                    totalBook--;
                    break;
                }
            }
        }

        public void addNewBookCopy(Book book, int copy)
        {
            for (int i = 0; i < listOfBooks.Length; i++)
            {
                if (listOfBooks[i] == book)
                {
                    listOfBooks[i].addBookCopy(copy);
                }
            }
        }
    }
}