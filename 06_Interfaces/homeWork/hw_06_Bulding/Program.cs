//Модуль #6
//Тема: Интерфейсы

//Домашнее задание

//Задание
//Реализовать программу “Строительство дома”

//Классы:
//House(Дом), Basement(Фундамент), Walls(Стены), Door(Дверь), Window(Окно), Roof(Крыша);
//Team(Бригада строителей), Worker(Строитель), TeamLeader(Бригадир).
//Интерфейсы: IWorker, IPart.
//Все части дома должны реализовать интерфейс IPart(Часть дома)
//для рабочих и бригадира предоставляется базовый интерфейс IWorker (Рабочий).
//Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента.
//Каждый строитель не знает заранее, на чём завершился предыдущий этап строительства, поэтому он “проверяет”,
//что уже построено и продолжает работу.
//Если в игру вступает бригадир (TeamLeader), он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена.
//В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” 

using hw_06_Bulding.Builders;

namespace hw_06_Bulding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team(new TeamLeader("Misha Ivanov"));
            team.Add(new СementPourer("Vasya Petrov"));
            team.Add(new Bricklayer("Petya Valiliev"));
            team.Add(new Roofer("Gena Sidorov"));
            team.Add(new DoorInstaller("Kolya Inanov"));
            team.Add(new WindowInstaller("Vanya Muhin"));

            try
            {
                team.BuildHouse(house);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}
