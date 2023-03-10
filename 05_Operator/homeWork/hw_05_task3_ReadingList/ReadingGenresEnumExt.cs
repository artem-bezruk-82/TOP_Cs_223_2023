using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class ReadingGenresEnumExt
    {
        public static void ShowEnum()
        {
            var types = Enum.GetValues(typeof(ReadingGenresEnum));
            foreach (var type in types)
            {
                Console.WriteLine($"\t{(int)type} - {type}");
            }
        }

        public static ReadingGenresEnum GetEnumItemConsole()
        {
            ShowEnum();
            int value = ConsoleInputHandling.GetConsoleInputInt("Please chose reading genre");
            while (!Enum.IsDefined(typeof(ReadingGenresEnum), value))
            {
                Console.WriteLine("Value is not defined. Please try again");
                value = ConsoleInputHandling.GetConsoleInputInt("Please chose reading genre");
            }
            return (ReadingGenresEnum)value;
        }
    }
}
