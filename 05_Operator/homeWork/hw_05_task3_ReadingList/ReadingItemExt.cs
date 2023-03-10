using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class ReadingItemExt
    {
        public static ReadingItem CreateReadingItemConsole() 
        {
            Book book = new Book();
            book.SetBookConsole();
            return new ReadingItem(book);
        }

        public static void SetReadingRateConsole(this ReadingItem readingItem) 
        {
            Console.WriteLine($"Current rate: {readingItem.Rate}");
            try
            {
                readingItem.Rate = ConsoleInputHandling.GetConsoleInputInt($"Please enter your rate");
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }
            Console.WriteLine($"New rate: {readingItem.Rate}");
        }

        public static void SetReadingStatusConsole(this ReadingItem readingItem) 
        {
            Console.WriteLine($"Current reading status: {readingItem.Status}");
            readingItem.Status = ReadingStatusesEnumExt.GetEnumItemConsole();
            Console.WriteLine($"New reading status: {readingItem.Status}");
        }

        public static void SetReadingGenreConsole(this ReadingItem readingItem)
        {
            Console.WriteLine($"Current genre: {readingItem.Genre}");
            readingItem.Genre = ReadingGenresEnumExt.GetEnumItemConsole();
            Console.WriteLine($"New genre: {readingItem.Genre}");
        }

        public static void SetBookmarkConsole(this ReadingItem readingItem) 
        {
            try
            {
                readingItem.BookmarkPage = 
                    ConsoleInputHandling.GetConsoleInputInt($"Please st bookmark of page within" +
                    $" 1...{readingItem.Book?.Pages} page");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public static void Menu(this ReadingItem readingItem) 
        {
            Console.WriteLine(readingItem);
            string[] menuItems =
{
                "READING LIST MENU > READING ITEM MENU\n0 - Exit",
                "\t1 - Set reading status",
                "\t2 - Set reading genre",
                "\t3 - Set bookmark page",
                "\t4 - Set reading rate"
            };

            int? menuItem = null;
            while (menuItem != 0)
            {
                foreach (string item in menuItems)
                {
                    Console.WriteLine(item);
                }
                menuItem = ConsoleInputHandling.GetConsoleInputInt("Please chose menu item");
                switch (menuItem)
                {
                    case 1:
                        readingItem.SetReadingStatusConsole();
                        break;
                    case 2:
                        readingItem.SetReadingGenreConsole();
                        break;
                    case 3:
                        readingItem.SetBookmarkConsole();
                        break;
                    case 4:
                        readingItem.SetReadingRateConsole();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
