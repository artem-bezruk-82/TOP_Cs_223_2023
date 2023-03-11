using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class ReadingListExt
    {
        public static void PrintConsole(this ReadingList readingList) 
        {
            for (int i = 0; i < readingList.Length; i++)
            {
                Console.WriteLine($"\t{i + 1} - {readingList[i]}");
            }
        }

        public static int ChoseItemIndex(this ReadingList readingList)
        {
            Console.WriteLine("0 - Exit");
            readingList.PrintConsole();
            int index = -1;
            while (index < 0 || index > readingList.Length)
            {
                index = ConsoleInputHandling.GetConsoleInputInt($"Please chose index within 1...{readingList.Length} range");
                if (index == 0)
                {
                    return -1;
                }
            }
            return index - 1;
        }

        public static ReadingItem? SearchByBookTitle(this ReadingList readingList) 
        {

            string? bookTitle = null;
            while (bookTitle == null)
            {
                Console.WriteLine("Please eter book Title");
                bookTitle = Console.ReadLine();
            }
            return readingList[bookTitle];
        }

        public static void Menu(this ReadingList readingList)
        {
            string[] menuItems =
            {
                "READING LIST MENU\n0 - Exit",
                "\t1 - Show reading items",
                "\t2 - Add reading item",
                "\t3 - Select reading item by index",
                "\t4 - Select reading item by book title",
                "\t5 - Delete reading item"
            };

            int? menuItem = null;
            while (menuItem != 0) 
            {
                foreach (string item in menuItems)
                {
                    Console.WriteLine(item);
                }
                menuItem = ConsoleInputHandling.GetConsoleInputInt("Please chose menu item");
                try
                {
                    switch (menuItem)
                    {
                        case 1:
                            PrintConsole(readingList);
                            break;
                        case 2:
                            readingList.AddReadingItem(ReadingItemExt.CreateReadingItemConsole());
                            break;
                        case 3:
                            {
                                int index = readingList.ChoseItemIndex();
                                if (index >= 0)
                                {
                                    readingList[index].Menu();
                                }
                                break;
                            }
                        case 4:
                            {
                                ReadingItem? readingItem = readingList.SearchByBookTitle();
                                if (readingItem != null)
                                {
                                    readingItem.Menu();
                                }
                                else
                                {
                                    Console.WriteLine("No such book found");
                                }
                                break;
                            }

                        case 5:
                            {
                                ReadingItem? readingItem = readingList[readingList.ChoseItemIndex()];
                                readingList.DeleteReadingItem(readingItem);
                                break;
                            }

                        default:
                            break;
                    }
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
            }

        }
    }
}
