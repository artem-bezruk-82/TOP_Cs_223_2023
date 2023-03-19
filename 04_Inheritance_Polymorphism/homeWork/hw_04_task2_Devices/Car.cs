using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task2_Devices
{
    public class Car : Device
    {

        public static int MaxSpeed { get; } = 200;
        public static int MinSpeed { get; } = 0;
        private int _speed;
        public int Speed 
        {
            get { return _speed; }
            set 
            {
                if (value < MinSpeed || value > MaxSpeed) 
                {
                    throw new ArgumentOutOfRangeException(nameof(Speed), value,
                        $"Out of {MinSpeed}...{MaxSpeed} range");
                }
                _speed = value;
            } 
        }

        public Car(string name, string? description, int speed) : base(name, description)
        {
            Speed = speed;
        }

        public Car(string name, string description) : this(name, description, MinSpeed) { }

        public Car(string name, int speed) : this(name, null, speed) { }

        public void Moving() 
        {
            Console.WriteLine($"I'm moving at speed of {Speed}");
        }

        public override void Sound()
        {
            Console.WriteLine("Rrrrrrr!!!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Speed: {Speed}";
        }
    }
}
