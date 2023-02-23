//Тема: Массивы и строки
//Модуль 2

//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 3
//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
//Кроме механизма шифровки, реализуйте механизм расшифрования.

namespace hw_02_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Today is a good day for walking. I will try to walk near the sea.";

            Console.WriteLine(input);

            int caesarShift = 3;

            string encripted = GetCaesarEncriptedString(input,caesarShift);
            Console.WriteLine(encripted);

            string decripted = GetCaesarDecriptedString(encripted, caesarShift);
            Console.WriteLine(decripted);
        }

        static string GetCaesarDecriptedString(string input, int caesarShift)
        {
            int upperCaseStartRange = 65;
            int upperCaseEndRange = 90;
            int lowerCaseStartRange = 97;
            int lowerCaseEndRange = 122;

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int charCode = input[i];
                if (charCode >= upperCaseStartRange && charCode <= upperCaseEndRange)
                {
                    if (charCode - caesarShift < upperCaseStartRange)
                    {
                        output += $"{(char)(upperCaseEndRange - (upperCaseStartRange - (charCode - caesarShift) - 1))}";
                    }
                    else
                    {
                        output += $"{(char)(charCode - caesarShift)}";
                    }
                }
                else if (charCode >= lowerCaseStartRange && charCode <= lowerCaseEndRange)
                {
                    if (charCode - caesarShift < lowerCaseStartRange)
                    {
                        output += $"{(char)(lowerCaseEndRange - (lowerCaseStartRange - (charCode - caesarShift) - 1))}";
                    }
                    else
                    {
                        output += $"{(char)(charCode - caesarShift)}";
                    }
                }
                else
                {
                    output += input[i];
                }
            }

            return output;
        }

        static string GetCaesarEncriptedString(string input, int caesarShift) 
        {
            int upperCaseStartRange = 65;
            int upperCaseEndRange = 90;
            int lowerCaseStartRange = 97;
            int lowerCaseEndRange = 122;

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int charCode = input[i];
                if (charCode >= upperCaseStartRange && charCode <= upperCaseEndRange)
                {
                    if (charCode + caesarShift > upperCaseEndRange)
                    {
                        output += $"{(char)(upperCaseStartRange - (upperCaseEndRange - charCode - caesarShift))}";
                    }
                    else
                    {
                        output += $"{(char)(charCode + caesarShift)}";
                    }
                }
                else if (charCode >= lowerCaseStartRange && charCode <= lowerCaseEndRange)
                {
                    if (charCode + caesarShift > lowerCaseEndRange)
                    {
                        output += $"{(char)(lowerCaseStartRange - (lowerCaseEndRange - charCode - caesarShift) - 1)}";
                    }
                    else
                    {
                        output += $"{(char)(charCode + caesarShift)}";
                    }
                }
                else
                {
                    output += input[i];
                }
            }

            return output;
        }
    }
}