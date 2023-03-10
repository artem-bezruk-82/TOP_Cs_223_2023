using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task3_ReadingList
{
    public static class ReadingStatusesEnumExt
    {
        public static void ShowEnum()
        {
            var types = Enum.GetValues(typeof(ReadingStatusesEnum));
            foreach (var type in types)
            {
                Console.WriteLine($"\t{(int)type} - {type}");
            }
        }

        public static ReadingStatusesEnum GetEnumItemConsole()
        {
            ShowEnum();
            int value = ConsoleInputHandling.GetConsoleInputInt("Please chose reading status");
            while (!Enum.IsDefined(typeof(ReadingStatusesEnum), value))
            {
                Console.WriteLine("Value is not defined. Please try again");
                value = ConsoleInputHandling.GetConsoleInputInt("Please chose reading status");
            }
            return (ReadingStatusesEnum)value;
        }
    }
}
