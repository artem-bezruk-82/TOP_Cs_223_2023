using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task1
{
    public class Money
    {
        private int _rubles;
        public int Rubles 
        {
            get { return _rubles; }
            private set 
            {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException(nameof(Rubles), value, 
                        "can not be less than 0");
                }
                _rubles = value;
            } 
        }

        private int _penny;
        public int Penny 
        {
            get { return _penny; }
            private set 
            {
                if (value < 0 || value > 99) 
                {
                    throw new ArgumentOutOfRangeException(nameof(Penny), value, 
                        "Out of 0...99 range");
                }
                _penny = value;
            }
        }

        public Money(int rubles, int penny) 
        {
            Rubles = rubles;
            Penny = penny;
        }

        public Money(int rubles) : this(rubles, 0) { }


        public static Money Increase(Money left, Money right) 
        {
            int rubles = left.Rubles + right.Rubles;
            byte penny = (byte)(left.Penny + right.Penny);
            if (penny > 99) 
            {
                rubles += penny/100;
                penny %= 100;
            }
            return new Money(rubles, penny);
        }

        public static Money Decrease(Money left, Money right) 
        {
            int rubles = left.Rubles - right.Rubles;
            int penny = left.Penny - right.Penny;
            if (penny < 0) 
            {
                penny += 100;
                rubles--;
            }
            if (rubles < 0) 
            {
                return new Money(0, 0);
            }
            return new Money(rubles, penny);
        }

        public static bool GraterThan(Money left, Money rigth) 
        {
            if (left.Rubles > rigth.Rubles) { return true; }
            if (left.Rubles < rigth.Rubles) { return false; }
            if (left.Penny > rigth.Penny) { return true; }
            return false;
        }

        public static bool LessThan(Money left, Money right)
        {
            return !GraterThan(left, right);
        }

        public static Money operator +(Money left, Money right) 
        {
            return Increase(left,right);
        }

        public static Money operator -(Money left, Money right)
        {
            return Decrease(left, right);
        }

        public static bool operator >(Money left, Money right)
        {
            return GraterThan(left, right);
        }

        public static bool operator <(Money left, Money right) 
        {
            return LessThan(left, right);
        }

        public override string ToString()
        {
            return $"{Rubles},{Penny} rubles";
        }
    }
}
