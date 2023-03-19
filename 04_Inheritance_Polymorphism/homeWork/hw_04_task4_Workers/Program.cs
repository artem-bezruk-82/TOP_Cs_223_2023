//Тема: Наследование
//Модуль 6

//ДОМАШНЕЕ ЗАДАНИЕ

//Задание 4
//Создать абстрактный базовый класс Worker (работника) с методом Print().
//Создайте четыре производных класса: President, Security, Manager, Engineer.
//Переопределите метод Print() для вывода информации, соответствующей каждому типу работника.

namespace hw_04_task4_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers =
            {
                new Engineer("Ivan", "Petrov", Genders.Man, new DateOnly(1982,11,10))
                ,new Security("Vasily", "Ivanov", Genders.Man, new DateOnly(1972,6,12))
                ,new Manager("Margarita", "Levinzon", Genders.Woman, new DateOnly(1992,7,6))
                ,new Manager("Sara", "Katsenman", Genders.Woman, new DateOnly(1993,8,7))
                ,new Manager("Ksenya", "Ginzburg", Genders.Woman, new DateOnly(1994,9,8))
                ,new Manager("Maria", "Goldberg", Genders.Woman, new DateOnly(1993,10,9))
                ,new Manager("Abram", "Zilbeshtain", Genders.Man, new DateOnly(1969,11,10))
                ,new Manager("Solomon", "Sheckelbaum", Genders.Man, new DateOnly(1972,12,11))
                ,new President("German","Tref",Genders.Man, new DateOnly(1964,2,8))
            };

            foreach(Worker worker in workers) 
            {
                if (worker is null) 
                {
                    continue;
                }
                Console.WriteLine("_______________________________");
                worker.Print();

                switch (worker)
                {
                    case Engineer engineer:
                        engineer.Develop(); 
                        break;
                    case Security security:
                        security.Guard();
                        break;
                    case Manager manager:
                        manager.Manage();
                        break;
                    case President president:
                        president.Represent();
                        break;
                    default:
                        Console.WriteLine($"{worker.Name} is {typeof(Worker).Name} type");
                        break;
                }
            }
        }
    }
}