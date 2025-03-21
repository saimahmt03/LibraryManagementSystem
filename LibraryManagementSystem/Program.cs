using LibraryManagementSystem.Model;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Program
    {

        public static void Main()
        {
            //-------After Copilot Modification & Personal Modification also------
            List<string> books = new List<string>();
            List<string> borrowedBooks = new List<string>();

            bool choice = true;

            while (choice)
            {
                Console.WriteLine("What would you like for a book?");
                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("Search");
                Console.WriteLine("Borrow");
                Console.WriteLine("Check In");
                Console.WriteLine("Exit");

                string action = Console.ReadLine();
                action = action.ToUpper();

                if (int.TryParse(action, out int holder))
                {
                    Console.WriteLine("Invalid Choice.");
                    Console.WriteLine("Choice should be between (Add/Remove/Search/Check In/Exit).");
                    Console.WriteLine("Try again.");
                    choice = true;
                }
                else
                {
                    switch (action)
                    {
                        case "ADD":
                            #region Add Book
                            Console.WriteLine("Enter the title of the book to add:");
                            string newBook = Console.ReadLine();
                            books.Add(newBook);
                            break;
                        #endregion
                        case "REMOVE":
                            #region Remove Book
                            Console.WriteLine("Enter the title of the book to remove:");
                            string removeBook = Console.ReadLine();
                            if (books.Contains(removeBook))
                            {
                                books.Remove(removeBook);
                            }
                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            #endregion
                            break;
                        case "SEARCH":
                            #region Search Book
                            Console.WriteLine("Enter the title of the book to search:");
                            string searchBook = Console.ReadLine();
                            if (books.Contains(searchBook))
                            {
                                Console.WriteLine("Book is in the list.");
                            }
                            else
                            {
                                Console.WriteLine("Book not in the list.");
                            }
                            #endregion
                            break;
                        case "BORROW":
                            #region Borrowing and Checking out Book
                            Console.WriteLine("Enter the title of the book to borrow:");
                            string borrowBook = Console.ReadLine();
                            if (books.Contains(borrowBook))
                            {
                                if(borrowedBooks.Count == 0)
                                {
                                    borrowedBooks.Add(borrowBook);
                                    books.Remove(borrowBook);
                                    Console.WriteLine("Book check out.");
                                }
                                else if(borrowedBooks.Count > 3)
                                {
                                    Console.WriteLine("The number of borrowing books is 3 at a time.");
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Book is not available on the list.");
                            }
                            #endregion
                            break;
                        case "CHECK IN":
                            #region Returning and Checking in Book
                            Console.WriteLine("Enter the title of the book to search:");
                            string checkInBook = Console.ReadLine();
                            if (borrowedBooks.Contains(checkInBook))
                            {
                                borrowedBooks.Remove(checkInBook);
                                books.Add(checkInBook);
                                Console.WriteLine("Book return and Check in.");
                            }
                            else
                            {
                                Console.WriteLine("Book check in is not on the list of check out books.");
                            }
                            #endregion
                            break;
                        case "EXIT":
                            #region EXIT
                            choice = false;
                            #endregion
                            break;
                        default:
                            Console.WriteLine("Something goes wrong.");
                            Console.WriteLine("Would you like to try again? y/n");
                            string choosen = Console.ReadLine();
                            choosen = choosen.ToUpper();
                            if (choosen == "Y")
                                choice = true;
                            else
                                choice = false;
                            break;
                    }
                }

                int i = 0;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Available books:");
                foreach (var book in books)
                {
                    i++;
                    Console.WriteLine(i + ". "+book);
                }
                Console.WriteLine("--------------------------");
            }
        }




        //-------------------------------------------------------------------------------------------------------------
        //----Part 1 Activity
        //public static void Main()
        //{
        //    string book1 = "";
        //    string book2 = "";
        //    string book3 = "";
        //    string book4 = "";
        //    string book5 = "";

        //    while (true) 
        //    {
        //        Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
        //        string action = Console.ReadLine();

        //        while (true)
        //        {
        //            if (action == "add")
        //            {
        //                Console.WriteLine("Enter the title of the book to add:");
        //                string newBook = Console.ReadLine();

        //                if (string.IsNullOrEmpty(book1))
        //                {
        //                    book1 = newBook;
        //                }
        //                else if (string.IsNullOrEmpty(book2))
        //                {
        //                    book2 = newBook;
        //                }
        //                else if (string.IsNullOrEmpty(book3))
        //                {
        //                    book3 = newBook;
        //                }
        //                else if (string.IsNullOrEmpty(book4))
        //                {
        //                    book4 = newBook;
        //                }
        //                else if (string.IsNullOrEmpty(book5))
        //                {
        //                    book5 = newBook;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("The library is full. No more books can be added.");
        //                }
        //            }
        //            else if (action == "remove")
        //            {
        //                Console.WriteLine("Enter the title of the book to remove:");
        //                string removeBook = Console.ReadLine();

        //                if (removeBook == book1)
        //                {
        //                    book1 = "";
        //                }
        //                else if (removeBook == book2)
        //                {
        //                    book2 = "";
        //                }
        //                else if (removeBook == book3)
        //                {
        //                    book3 = "";
        //                }
        //                else if (removeBook == book4)
        //                {
        //                    book4 = "";
        //                }
        //                else if (removeBook == book5)
        //                {
        //                    book5 = "";
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Book not found.");
        //                }
        //            }
        //            else if (action == "exit") 
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
        //            }

        //            // Display the list of books
        //            Console.WriteLine("Available books:");
        //            Console.WriteLine(book1);
        //            Console.WriteLine(book2);
        //            Console.WriteLine(book3);
        //            Console.WriteLine(book4);
        //            Console.WriteLine(book5);


        //        }
        //    }
        //}

        
        
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //--Personal
        //public static void Main()
        //{ 
        //    //Objects
        //    List<Book> listOfBook = new List<Book>();
        //    Book book = new Book();

        //    //Services
        //    AddNewBook addNewBook = new AddNewBook();

        //    string result = string.Empty;

        //    int step = 1;
        //    while (step > 0)
        //    {
        //        Console.WriteLine("Choose your desire transaction.");
        //        Console.WriteLine("[1] ADD BOOK BY TITLE.");
        //        Console.WriteLine("[2] REMOVE BOOK BY TITLE.");
        //        Console.WriteLine("[3] DISPLAY THE LIST OF BOOK.");
        //        string choice = Console.ReadLine();

        //        if (int.TryParse(choice, out int holder))
        //        {
        //            int choosen = holder;
        //            switch (choosen)
        //            {
        //                case 1:
        //                    #region Add New Book by Title
        //                    book = addNewBook.NewBook();
        //                    result = addNewBook.ValidateBook(book);
        //                    if (result == "Validated.")
        //                    {
        //                        listOfBook.Add(book);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine(result);
        //                    }
        //                    break;
        //                    #endregion
        //                case 2:
        //                    #region Remove Book by Title on the list
        //                    if (listOfBook.Count == 0)
        //                    {
        //                        Console.WriteLine("Add book first.");
        //                    }
        //                    else
        //                    {
        //                        result = addNewBook.ValidateBook(book);
        //                        if (result == "Validated.")
        //                        {
        //                            listOfBook.Remove(book);
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(result);
        //                        }
        //                    }
        //                    break;
        //                    #endregion
        //                case 3:
        //                    #region Display the List of Book
        //                    if(listOfBook.Count == 0)
        //                    {
        //                        Console.WriteLine("Invalid choice. Choices should be integer only.");
        //                        Console.WriteLine("Do you want to try again Y/N?");
        //                        string choose = Console.ReadLine();
        //                        choose = choose.ToUpper();
        //                        if (choose == "Y")
        //                            step++;
        //                        else
        //                            step = 0;
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("List of Book:");
        //                        for (int i = 0; i < listOfBook.Count; i++)
        //                        {
        //                            book = listOfBook[i];
        //                            Console.WriteLine(book.Title);
        //                        }
        //                    }
        //                    break;
        //                    #endregion
        //                default:
        //                    #region Default
        //                    Console.WriteLine("Invalid choice. Choices should be integer only.");
        //                    Console.WriteLine("Do you want to try again Y/N?");
        //                    string answer = Console.ReadLine();
        //                    answer = answer.ToUpper();
        //                    if (answer == "Y")
        //                        step++;
        //                    else
        //                        step = 0;
        //                    break;
        //                    #endregion
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid choice. Choices should be integer only.");
        //            Console.WriteLine("Do you want to try again Y/N?");
        //            string answer = Console.ReadLine();
        //            answer = answer.ToUpper();
        //            if (answer == "Y")
        //                step++;
        //            else
        //                step = 0;
        //        }
        //    }
        //} 
    }
}