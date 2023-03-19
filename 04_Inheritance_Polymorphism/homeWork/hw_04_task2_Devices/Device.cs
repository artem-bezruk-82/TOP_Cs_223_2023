using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task2_Devices
{
    public abstract class Device
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public Device(string name, string? description) 
        {
            Name = name;
            Description = description;
        }

        public Device(string name) : this(name, null) { }

        public abstract void Sound();

        public void Show() 
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine(Description);
        }

        public override string ToString()
        {
            return $"Name: {Name}; Description: {Description}; ";
        }
    }
}
