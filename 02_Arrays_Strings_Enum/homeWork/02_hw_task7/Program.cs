//Тема: Массивы и строки
//Модуль 2

//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 7
//Создайте приложение, проверяющее текст на недопустимые слова.
//Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
//По итогам работы приложения необходимо показать статистику действий. 

namespace _02_hw_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "To be, or not to be, that is the question," +
                "\r\nWhether 'tis nobler in the mind to suffer" +
                "\r\nThe slings and arrows of outrageous fortune," +
                "\r\nOr to take arms against a sea of troubles," +
                "\r\nAnd by opposing end them? To die: to sleep;" +
                "\r\nNo more; and by a sleep to say we end" +
                "\r\nThe heart-ache and the thousand natural shocks" +
                "\r\nThat flesh is heir to, 'tis a consummation" +
                "\r\nDevoutly to be wish'd. To die, to sleep";

            string unacceptableWord = "die";

            //char[] inputChars = inputText.ToCharArray();

            string replacement = string.Empty;

            for (int i = 0; i < unacceptableWord.Length; i++)
            {
                replacement += '*';
            }

            string outputText = inputText.Replace(unacceptableWord,replacement);

            Console.WriteLine(outputText);
        }
    }
}