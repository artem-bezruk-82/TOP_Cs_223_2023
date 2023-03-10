using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class BookExt
    {
        public static void SetBookConsole(this Book book) 
        {
            SetAuthorConsole(book);
            SetTitleConsole(book);
            SetBookTypeConsole(book);
            SetPagesConsole(book);
            SetRaleaseYearConsole(book);
        }

        public static void SetAuthorConsole(this Book book)
        {
            while (book.Author == null || book.Author == string.Empty) 
            {
                Console.WriteLine($"Please enter {nameof(book.Author)}");
                book.Author = Console.ReadLine();
            }
        }

        public static void SetTitleConsole(this Book book)
        {
            while (book.Title == null || book.Title == string.Empty)
            {
                Console.WriteLine($"Please enter {nameof(book.Title)}");
                book.Title = Console.ReadLine();
            }
        }

        public static void SetBookTypeConsole(this Book book) 
        {
            book.BookType = BooksTypesEnumExt.GetEnumItemConsole();
        }

        public static void SetPagesConsole(this Book book) 
        {
            while (book.Pages == null) 
            {
                try
                {
                    book.Pages = ConsoleInputHandling.GetConsoleInputInt("Please enter number of pages");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        public static void SetRaleaseYearConsole(this Book book) 
        {
            int year = ConsoleInputHandling.GetConsoleInputInt("Please enter book release year");
            try
            {
                book.ReleaseDate = new DateOnly(year, 1, 1);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}
