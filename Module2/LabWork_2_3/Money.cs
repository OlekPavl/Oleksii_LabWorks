using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_3
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    }
    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public double Amount { get; set; }
        public CurrencyTypes? CurrencyType { get; set; }

        // 3) declare parameter constructor for properties initialization
        public Money(double amount, CurrencyTypes? type = null)
        {
            this.Amount = amount;
            this.CurrencyType = type;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money obj1, Money obj2)
        {
            return new Money(obj1.Amount + obj2.Amount, obj1.CurrencyType);
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money obj)
        {
            return new Money(--obj.Amount, obj.CurrencyType);
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money obj, int x = 3)
        {
            return new Money(obj.Amount * x, obj.CurrencyType);
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money obj1, Money obj2)
        {
            return obj1.Amount > obj2.Amount;
        }
        public static bool operator <(Money obj1, Money obj2)
        {
            return obj1.Amount < obj2.Amount;
        }
        public static bool operator >(Money obj1, string str)
        {
            return obj1.Amount > Convert.ToDouble(str);
        }
        public static bool operator <(Money obj1, string str)
        {
            return obj1.Amount < Convert.ToDouble(str);
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money obj)
        {
            return obj.CurrencyType == CurrencyTypes.EU || obj.CurrencyType == CurrencyTypes.UAH || obj.CurrencyType == CurrencyTypes.USD;
        }
        public static bool operator false(Money obj)
        {
            return obj.CurrencyType != CurrencyTypes.EU && obj.CurrencyType != CurrencyTypes.UAH && obj.CurrencyType != CurrencyTypes.USD;
        }

        // 9) declare overloading of implicit / explicit conversion  to convert Money to double, string and vice versa
        public static implicit operator Money(double obj)
        {
            return new Money(obj);
        }
        public static implicit operator Money(string obj)
        {
            return new Money(Convert.ToDouble(obj));
        }
        public static explicit operator double(Money obj)
        {
            return obj.Amount;
        }
        public static explicit operator string(Money obj)
        {
            return Convert.ToString(obj.Amount);
        }
    }
}
