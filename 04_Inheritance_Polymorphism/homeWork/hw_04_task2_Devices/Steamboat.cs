using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task2_Devices
{
    public class Steamboat : Device
    {
        public static int MinPassengers { get; set; } = 10;
        public static int MaxPassengers { get; set; } = 1000;

        private int _passengers;

        public int Passengers 
        {
            get {  return _passengers; } 
            set 
            {
                if (value < MinPassengers || value > MaxPassengers) 
                {
                    throw new ArgumentOutOfRangeException(nameof(Passengers), value, 
                        $"Out of {MinPassengers}...{MaxPassengers} range");
                }
                _passengers = value; 
            } 
        }

        public Steamboat(string name, string? description, int passengers) : base(name, description) 
        {
            Passengers = passengers;
        }

        public Steamboat(string name, string description) : this(name, description, MinPassengers) { }

        public Steamboat(string name, int passengers) : this(name, null, passengers) { }

        public void Shipping() 
        {
            Console.WriteLine($"I'm carrying {Passengers} passengers");
        }

        public override void Sound()
        {
            Console.WriteLine("Uuuuuu!!!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Passengers: {Passengers}";
        }
    }
}
