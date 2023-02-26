//ДОМАШНЕЕ ЗАДАНИЕ
//Модуль 3. Часть 1
//Тема: Top level statements. Введение в классы. Обработка исключений

//Задание 1
//Напишите метод, который отображает квадрат из некоторого символа.
//Метод принимает в качестве параметров: длину стороны квадрата, символ.


namespace hw_03_p1_task1_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int side = GetConsoleInput($"Please enter square side ({typeof(int)}) value");
            Console.WriteLine("Please define symbol you would like the square to be printed with");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            PrintSquareConsole(side, symbol);
        }

        static void PrintSquareConsole(int side, char symbol) 
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        static int GetConsoleInput(string requestText)
        {
            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} value");
                }
            }
            return (int)value;
        }
    }
}