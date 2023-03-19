﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task4_Workers
{
    public class Security : Worker
    {
        public Security(string name, string surname, Genders gender, DateOnly birthDay) 
            : base(name, surname, gender, birthDay) { }

        public void Guard()
        {
            Console.WriteLine("I am solving crossword puzzles!");
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surname}; Security");
        }
    }
}
