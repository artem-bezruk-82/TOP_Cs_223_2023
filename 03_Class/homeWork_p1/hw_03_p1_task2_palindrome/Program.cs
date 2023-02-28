//ДОМАШНЕЕ ЗАДАНИЕ
//Тема: Top level statements. Введение в классы. Обработка исключений
//Модуль 3. Часть 1

//Задание 2
//Напишите метод, который проверяет является ли переданное число «палиндромом».
//Число передаётся в качестве параметра.
//Если число палиндром нужно вернуть из метода true, иначе false.

using System.Text;

namespace hw_03_p1_task2_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? valueInt = null;

            do
            {
                valueInt = GetConsoleInput("Please enter at least 2-digits value");
                if (valueInt < 10)
                {
                    Console.WriteLine("You have entered out of range value. Please try again.");
                }
            } while (valueInt < 10);

            Console.WriteLine(valueInt + (IsPalindrome(valueInt) ? " is" : " is not") + " palindrome");
        }

        static bool IsPalindrome(int? value) 
        {
            if (value is null) 
            {
                return false;
            }
            string valueStr = $"{value}";
            StringBuilder valueSB = new StringBuilder(valueStr);

            for (int i = 0; i < valueSB.Length / 2; i++)
            {
                (valueSB[i], valueSB[valueSB.Length - i - 1]) = (valueSB[valueSB.Length - i - 1], valueSB[i]);
            }

            return valueStr == valueSB.ToString() ? true : false;
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

                    Console.WriteLine($"{exc.Message} Please enter integer value");
                }
            }
            return (int)value;
        }
    }
}