using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class BooksTypesEnumExt
    {
        public static void ShowEnum()
        {
            var types = Enum.GetValues(typeof(BookTypesEnum));
            foreach (var type in types)
            {
                Console.WriteLine($"\t{(int)type} - {type}");
            }
        }

        public static BookTypesEnum GetEnumItemConsole()
        {
            ShowEnum();
            int value = ConsoleInputHandling.GetConsoleInputInt("Please chose book type");
            while (!Enum.IsDefined(typeof(BookTypesEnum), value))
            {
                Console.WriteLine("Value is not defined. Please try again");
                value = ConsoleInputHandling.GetConsoleInputInt("Please chose book type");
            }
            return (BookTypesEnum)value;
        }
    }
}
