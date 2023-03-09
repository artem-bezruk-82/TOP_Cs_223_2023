using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task1_magazine
{
    internal class Magazine
    {
        public string? Name { get; set; }
        public DateOnly EstDate { get; set; }
        public string? Description { get; set; }
        public MailAddress? Email { get; set; }

        private string? _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentOutOfRangeException(value, message: "Telephon number must contain 11 digits");
                }

                Int64 number;

                if (Int64.TryParse(value, out number))
                {
                    _phone = $"+{value}";
                }
                else
                {
                    throw new ArgumentException("It is not a number");
                }
            }
        }

        private int _numOfEmployees;
        public int NumOfEmployees 
        {
            get { return _numOfEmployees; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        message: $"Number of employees can not be defined by less than zero value");
                }
                else 
                {
                    _numOfEmployees = value;
                }
            }
        }


        public static Magazine IncreaseEmployees(Magazine magazineObj, int numOfEmployees) 
        {
            if (numOfEmployees < 0)
            {
                numOfEmployees = Math.Abs(numOfEmployees);
            }
            magazineObj.NumOfEmployees += numOfEmployees;
            return magazineObj;
        }

        public static Magazine operator +(Magazine magazineObj, int numOfEmployees) 
        {
            return IncreaseEmployees(magazineObj, numOfEmployees);
        }

        public static Magazine DecreaseEmployees(Magazine magazineObj, int numOfEmployees)
        {
            if (numOfEmployees < 0) 
            {
                numOfEmployees = Math.Abs(numOfEmployees);
            }
            if (numOfEmployees > magazineObj.NumOfEmployees) 
            {
                return magazineObj;
            }
            magazineObj.NumOfEmployees -= numOfEmployees;
            return magazineObj;
        }

        public static Magazine operator -(Magazine magazineObj, int numOfEmployees)
        {
            return DecreaseEmployees(magazineObj, numOfEmployees);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Magazine magazineObj) 
            {
                return this.NumOfEmployees == magazineObj.NumOfEmployees;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        public static bool operator ==(Magazine obj1, Magazine obj2) 
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Magazine obj1, Magazine obj2)
        {
            return !obj1.Equals(obj2);
        }

        public static bool CompareEmployees(Magazine obj1, Magazine obj2)
        {
            return obj1.NumOfEmployees > obj2.NumOfEmployees;
        }

        public static bool operator >(Magazine obj1, Magazine obj2) 
        {
            return CompareEmployees(obj1, obj2);
        }

        public static bool operator <(Magazine obj1, Magazine obj2)
        {
            return !CompareEmployees(obj1, obj2);
        }

        public override string ToString()
        {
            return $"Name: {Name}; Year: {EstDate.Year}; Description: {Description}; e-mail{Email}; " +
                $"Phone: {Phone}, Employees: {NumOfEmployees}";
        }
    }
}
