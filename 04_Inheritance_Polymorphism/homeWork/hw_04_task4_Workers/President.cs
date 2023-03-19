using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task4_Workers
{
    public class President : Worker
    {
        public President(string name, string surname, Genders gender, DateOnly birthDay)
            : base(name, surname, gender, birthDay) { }

        public void Represent()
        {
            Console.WriteLine("I'm showing up my face at the right places!");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surname}; President");
        }
    }
}
