using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task2_Shop
{
    public class Address
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        private int _postalCode;
        public int PostalCode 
        {
            get { return _postalCode; } 
            set 
            {
                if (value < 100000 || value > 999999) 
                {
                    throw new ArgumentOutOfRangeException(nameof(PostalCode),
                        message:$"{nameof(PostalCode)} out of 100000...999999");
                }
                _postalCode = value;
            } 
        }
        public string Street { get; set; }
        private int _building;
        public int Building 
        { 
            get { return _building; }
            set 
            {
                if (value < 1) 
                {
                    throw new ArgumentException(message: $"{nameof(Building)} less than 1");
                }
                _building = value;
            } 
        }

        public Address(string country, string region, string city, int postalCode, string street, int building) 
        {
            Country = country;
            Region = region;
            City = city;
            PostalCode = postalCode;
            Street = street;
            Building = building;
        }

        public override string ToString()
        {
            return $"{PostalCode}, {Country}, {Region}, {City}, {Street}, {Building}";
        }
    }
}
