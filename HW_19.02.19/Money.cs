using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19._02._19
{
    public class Money : IComparable
    {
        private string[] changeHistory = null;

        public string this[int index]
        {
            get
            {
                return changeHistory[index];
            }
            set
            {
                changeHistory[index] = value;
            }
        }
        public decimal Amount { get; set; }

        public string Unit { get; set; }

        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
            changeHistory = new string[500];
        }
        public static bool operator ==(Money a, Money b)
        {
            return (a.Amount == b.Amount) && (a.Unit == b.Unit);
        }
        public static bool operator !=(Money a, Money b)
        {
            return (a.Amount != b.Amount) || (a.Unit != b.Unit);
        }

        public int CompareTo(object obj)
        {
            if (obj is Money)
            {
                Money a = (Money)obj;
                if (this.Amount > a.Amount)
                    return 1;
                else if (this.Amount < a.Amount)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException();
        }
    }
}

