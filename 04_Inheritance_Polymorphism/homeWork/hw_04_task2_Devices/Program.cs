//ДОМАШНЕЕ ЗАДАНИЕ

//Тема: Наследование
//Модуль 6

//Задание 2
//Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход».
//С помощью конструктора установить имя каждого устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//Sound — издает звук устройства (пишем текстом в консоль);
//Show — отображает название устройства;
//Desc — отображает описание устройства.


namespace hw_04_task2_Devices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] devices =
            {
                new Teapot(name: "tp1", description: "mini pot", waterVolume: 2),
                new Teapot(name: "tp2", description: "middle pot", waterVolume: 4),
                new Teapot(name: "tp3", description: "large pot", waterVolume: 6),
                null,
                new MicrowaveOwen("mo1", "low-powered owen",  350),
                new MicrowaveOwen("mo2", "middle-powered owen",  650),
                new MicrowaveOwen("mo3", "high-power owen",  850),
                new Car("Car1", "slow car", 60),
                new Car("Car2", "fast car", 180),
                new Steamboat("sb1", "little staemboat", 50),
                new Steamboat("sb2", "huge staemboat", 900)
            };

            foreach (Device device in devices) 
            {
                if (device is null)
                {
                    continue;
                }
                Console.WriteLine("---------------------------------------------------------");
                device.Show();
                device.Desc();
                device.Sound();

                switch (device)
                {
                    case Teapot teapot:
                        teapot.BoilingWater(); 
                        break;
                    case MicrowaveOwen owen:
                        owen.WarmingUpFood();
                        break;
                    case Car car:
                        car.Moving();
                        break;
                    case Steamboat boat:
                        boat.Shipping();
                        break;
                    default:
                        Console.WriteLine($"The device named {device.Name} is a {device.GetType().Name}.");
                        break;
                }
            }
        }
    }
}