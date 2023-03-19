using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task2_Devices
{
    public class Teapot : Device
    {
        public static double MaxVolume { get; } = 10.0;
        public static double MinVolume { get; } = 1.0;

        private double _waterVolume;
        public double WaterVolume 
        {
            get 
            {
                return _waterVolume;
            }
            set 
            {
                if (value < MinVolume || value > MaxVolume)
                {
                    throw new ArgumentOutOfRangeException(nameof(WaterVolume), value, 
                        $"Out of {MinVolume}...{MaxVolume} range");
                }
                _waterVolume = value;
            }
        }
        public Teapot(string name, string? description, double waterVolume) : base(name, description) 
        {
            WaterVolume = waterVolume;
        }

        public Teapot(string name, double waterVolume) :
            this(name: name, description: null, waterVolume: waterVolume)
        { }

        public Teapot(string name, string? description = null) : 
            this(name: name, description: description, waterVolume: MinVolume) 
        { }

        public void BoilingWater() 
        {
            Console.WriteLine($"I'm boiling {WaterVolume} litres of water");
        }

        public override void Sound()
        {
            Console.WriteLine("Ssssssss!!!");
        }

        public override string ToString() 
        {
            return $"{base.ToString()} Volume: {WaterVolume};";
        }
    }
}
