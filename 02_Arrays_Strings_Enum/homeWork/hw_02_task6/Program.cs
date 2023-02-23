//Тема: Массивы и строки
//Модуль 2

//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea».
//Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea».

using System.Text;

namespace hw_02_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "today is a good day for walking. i will try to walk near the sea.";

            Console.WriteLine(inputText);

            string outputText = string.Empty;
            string[] sentetces = inputText.Trim().Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentetces.Length; i++)
            {
                StringBuilder sb = new StringBuilder(sentetces[i].Trim());
                sb[0] = char.ToUpper(sb[0]);
                outputText += $"{sb}. ";
            }

            Console.WriteLine(outputText.Trim());
        }
    }
}