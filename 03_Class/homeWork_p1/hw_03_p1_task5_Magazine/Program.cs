//ДОМАШНЕЕ ЗАДАНИЕ

//Тема: Top level statements. Введение в классы. Обработка исключений
//Модуль 3. Часть 1

//Задание 5
//Создайте класс «Журнал». Необходимо хранить в полях класса:
//название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.

using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace hw_03_p1_task5_Magazine
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Magazine magazine = new Magazine();
            magazine.SetMagazine();
            Console.WriteLine(magazine);

        }
    }
}