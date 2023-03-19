using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task4_Workers
{
    public abstract class Worker
    {
        public static int MaxAgeMen { get; } = 65;
        public static int MaxAgeWomen { get; } = 60;
        public static int MinAge { get; } = 18;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Genders Gender { get; set; }

        private DateOnly _birthDay;
        public DateOnly BirthDay 
        {
            get { return _birthDay; }
            set 
            {
                int age = GetAge(value);
                if (age < MinAge || age >= MaxAgeMen) 
                {
                    throw new ArgumentOutOfRangeException(nameof(BirthDay), value, 
                        $"Age is out of {MinAge}...{MaxAgeMen} range");
                }

                if (Gender == Genders.Woman && age >= MaxAgeWomen)
                {
                    throw new ArgumentOutOfRangeException(nameof(BirthDay), value,
                        $"{MaxAgeWomen} years gge limit for women exceeded");
                }
                _birthDay = value;
            }
        }

        public Worker(string name, string surname, Genders gender, DateOnly birthDay)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            BirthDay = birthDay;
        }

        public int GetAge() 
        {
            return GetAge(BirthDay);
        }

        public static int GetAge(DateOnly BirthDate) 
        {
            int age = 0;
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);

            if (dateNow < BirthDate)
            {
                return -1;
            }

            if (BirthDate.Year < dateNow.Year)
            {
                age = dateNow.Year - BirthDate.Year;
            }

            if (BirthDate.Month < dateNow.Month)
            {
                return age;
            }
            else if (BirthDate.Month > dateNow.Month)
            {
                return age - 1;
            }
            else if (BirthDate.Day > dateNow.Day)
            {
                return age - 1;
            }
            else
            {
                return age;
            }
        }

        public abstract void Print();

        public override string ToString()
        {
            return $"{Name} {Surname}, BirthDay: {BirthDay.ToShortDateString()}";
        }
    }
}
