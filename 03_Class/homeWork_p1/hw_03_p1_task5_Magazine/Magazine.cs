using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_p1_task5_Magazine
{
    internal class Magazine
    {
        public string Name { get; set; }
        public DateOnly EstDate { get; set; }
        public string Description { get; set; }
        public MailAddress Email { get; set; }

        private string _phone;

        public string Phone 
        {
            get { return _phone; }
            set 
            {
               if (value.Length != 11) 
                {
                    throw new ArgumentOutOfRangeException(value,message: "Telephon number must contain 11 digits");
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

        public override string ToString()
        {
            return $"Name: {Name}; Year: {EstDate.Year}; Description: {Description}; e-mail{Email}; " +
                $"Phone: {Phone}";
        }
    }
}
