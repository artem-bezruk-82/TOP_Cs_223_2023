using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task2_Devices
{
    public class MicrowaveOwen : Device
    {
        public static int MaxPower { get; } = 950;
        public static int MinPower { get; } = 250;
        private int _power;
        public int Power 
        { 
            get { return _power; }
            set 
            {
                if (value < MinPower || value > MaxPower) 
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Power),value, $"Out of {MinPower}...{MaxPower} range");
                }
                _power = value;
            } 
        }

        public MicrowaveOwen(string name, string? desription, int power) : 
            base(name: name, description: desription)
        {
            Power = power;
        }

        public MicrowaveOwen(string name, string? description = null) :
            this(name: name, description, MinPower)
        { }

        public MicrowaveOwen(string name, int power) : 
            this(name: name, desription: null, power: power)
        { }

        public void WarmingUpFood() 
        {
            Console.WriteLine($"I'm warming up food with {Power}W energy");
        }

        public override void Sound()
        {
            Console.WriteLine("Mmmmmmm!!!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Power: {Power}";
        }
    }
}
