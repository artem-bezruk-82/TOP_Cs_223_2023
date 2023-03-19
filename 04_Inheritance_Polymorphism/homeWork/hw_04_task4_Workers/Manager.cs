using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task4_Workers
{
    public class Manager : Worker
    {
        public Manager(string name, string surname, Genders gender, DateOnly birthDay)
            : base(name, surname, gender, birthDay) { }

        public void Manage()
        {
            Console.WriteLine("Bla, bla, bla!!!!");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surname}; Manager");
        }
    }
}
