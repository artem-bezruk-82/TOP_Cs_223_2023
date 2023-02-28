using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_p1_task5_Magazine
{
    internal static class MagazineExt
    {
        public static void SetMagazine(this Magazine magazine) 
        {
            Console.WriteLine($"Please enter {nameof(magazine)} name");
            magazine.Name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine($"Please enter {nameof(magazine)} description");
            magazine.Description = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please enter established date, using DD.MM.YYYY format");
            DateOnly date = DateOnly.Parse(Console.ReadLine() ?? string.Empty);

            magazine.Phone = $"{GetConsoleInput("Please enter 11-digits phone")}";

            Console.WriteLine("Please enter e-mail address");
            magazine.Email = new System.Net.Mail.MailAddress(Console.ReadLine() ?? string.Empty);

        }

        private static Int64 GetConsoleInput(string requestText)
        {
            Int64? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = Int64.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"{exc.Message} Please enter integer value");
                }
            }
            return (Int64)value;
        }
    }
}
