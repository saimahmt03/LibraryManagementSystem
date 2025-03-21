using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class AddNewBook
    {
        internal Book NewBook() 
        { 
            Book book = new Book();

            Console.WriteLine("Add Title of The Book: ");
            string title = Console.ReadLine();

            book.Title = title;

            return book;
        }

        internal string ValidateBook(Book book)
        {
            if (string.IsNullOrEmpty(book.Title))
            {
                return "Title of the book should be supply.";
            }
            else if (int.TryParse(book.Title, out int resultTitle))
            {
                return "Title should not be digit.";
            }
            else
            {
                return "Validated.";
            }
        }
    }
}
