using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task4_Workers
{
    public class Engineer: Worker
    {
        public Engineer(string name, string surname, Genders gender, DateOnly birthDay) 
            : base(name, surname, gender, birthDay) { }

        public void Develop() 
        {
            Console.WriteLine("I'm developing software!");
        }

        public override void Print()
        {
            //Console.WriteLine($"{Name} {Surname}; Engineer");
            Console.WriteLine($"{base.ToString()} Engineer");
        }
    }
}
