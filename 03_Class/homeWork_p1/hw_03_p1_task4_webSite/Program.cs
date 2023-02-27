//ДОМАШНЕЕ ЗАДАНИЕ
//Тема: Top level statements. Введение в классы. Обработка исключений
//Модуль 3. Часть 1

//Задание 4
//Создайте класс «Веб-сайт».
//Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта.
//Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса. 

using System.Net;

namespace hw_03_p1_task4_webSite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WebSite metanit = new WebSite()
            {
                Name = "Metanit",
                Uri = new Uri("https://metanit.com/"),
                IPaddress = IPAddress.Parse("77.222.61.70"),
                Description = "Site about programming"
            };

            Console.WriteLine(metanit);

        }
    }
}