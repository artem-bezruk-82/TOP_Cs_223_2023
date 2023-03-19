using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3_Instruments
{
    public abstract class Instrument
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? History { get; set; }

        public Instrument(string name, string? description = null) 
        {
            Name = name;
            Description = description;
        }

        public abstract void Sound();

        public override string ToString()
        {
            return $"{Name} {Description}";
        }
    }
}
