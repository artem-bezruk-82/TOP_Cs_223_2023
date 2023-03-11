using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_task2_Shop
{
    public class Shop
    {
        public Address Address { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public MailAddress? Email { get; set; }

        private string? _phone;

        public string? Phone
        {
            get { return _phone; }
            set
            {
                if (value?.Length != 11)
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

        private double _area;
        public double Area
        {
            get { return _area; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: $"{nameof(Area)} less than 0");
                }
                _area = value;
            }
        }

        public Shop(Address address, string name, string phone, double area)
        {
            Address = address;
            Name = name;
            Phone = phone;
            Area = area;
        }

        public static Shop IncreaseArea(Shop shop, double area)
        {
            area = Math.Abs(area);
            shop.Area += area;
            return shop;
        }

        public static Shop operator +(Shop shop, double area)
        {
            return IncreaseArea(shop, area);
        }

        public static Shop DecreaseArea(Shop shop, double area)
        {
            area = Math.Abs(area);
            if (area <= shop.Area)
            {
                shop.Area -= area;
            }
            return shop;
        }

        public static Shop operator -(Shop shop, double area)
        {
            return DecreaseArea(shop, area);
        }

        public static bool CompareAreas(Shop shopLeft, Shop shopRight)
        {
            return shopLeft.Area > shopRight.Area;
        }

        public static bool operator >(Shop shopLeft, Shop shopRight)
        {
            return CompareAreas(shopLeft, shopRight);
        }

        public static bool operator <(Shop shopLeft, Shop shopRight)
        {
            return !CompareAreas(shopLeft, shopRight);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Shop shopObj)
            {
                return this.Area == shopObj.Area;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        public static bool operator ==(Shop leftShop, Shop rightShop)
        {
            return leftShop.Equals(rightShop);
        }

        public static bool operator !=(Shop leftShop, Shop rightShop)
        {
            return !leftShop.Equals(rightShop);
        }

        public override string ToString()
        {
            return $"'{Name}'\nAddress: {Address}\n{Description}\ne-mail: {Email}\nPhone: {Phone}";
        }
    }
}
