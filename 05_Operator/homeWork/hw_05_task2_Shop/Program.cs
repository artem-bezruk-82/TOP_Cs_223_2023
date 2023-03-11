//Тема: Перегрузка операторов. Индексаторы и свойства
//Модуль 5
//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 2
//Ранее в одном из практических заданий вы создавали класс «Магазин».
//Добавьте к уже созданному классу информацию о площади магазина.
//Выполните перегрузку + (для увеличения площади магазина на указанную величину),
//— (для уменьшения площади магазина на указанную величину),
//== (проверка на равенство площадей магазинов),
//< и > (проверка на меньше или больше площади магазина),
//!= и Equals.

namespace hw_05_task2_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop nike = new Shop(
                new Address("Russia", "Voronezh region", "Voronezh", 394000, "Plekhanovskaya", 35),
                "Nike",
                "71234567890",
                150
                )
            {
                Description = "Sports ware",
                Email = new System.Net.Mail.MailAddress("ru.vrn@nike.com")
            };

            Shop adidas = new Shop(
                new Address("Russia", "Voronezh region", "Voronezh", 394000, "Lenina", 17),
                "Adidas",
                "73216548709",
                200
                )
            {
                Description = "Sports ware",
                Email = new System.Net.Mail.MailAddress("ru.vrn@adidas.com")
            };

            Console.WriteLine(nike);
            Console.WriteLine(adidas);

            PrintComparisonConsole(nike, adidas);
            PrintComparisonConsole(adidas, nike);

            adidas -= 20;
            nike += 30;

            PrintComparisonConsole(adidas, nike);
        }

        public static void PrintComparisonConsole(Shop shopA, Shop shopB)
        {
            if (shopA == shopB)
            {
                Console.WriteLine($"'{shopA.Name}' and '{shopB.Name}' have equal areas");
            }
            else
            {
                if (shopA > shopB)
                {
                    Console.WriteLine($"'{shopA.Name}' is bigger than '{shopB.Name}'");
                }
                else
                {
                    Console.WriteLine($"'{shopA.Name}' is smaller than '{shopB.Name}'");
                }
            }
        }
    }
}