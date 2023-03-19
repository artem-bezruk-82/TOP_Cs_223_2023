using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task1
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void DecreasePrice(Money decreaseValue) 
        {
            if (decreaseValue > Price) 
            {
                throw new ArgumentException(nameof(decreaseValue),
                    $"{nameof(decreaseValue)} must be > {nameof(Price)}");
            }
            Price -= decreaseValue;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }
}
