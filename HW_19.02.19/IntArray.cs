using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19._02._19
{
    class IntArray
    {
        int[] str;

        public IntArray()
        {
            this.str = new int[0];
        }
        public IntArray(int size)
        {
            this.str = new int[size];
        }

        public int this[int index]
        {
            get
            {
                int res = int.MinValue;
                try
                {
                    res = this.str[index];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error");
                }
                return res;
            }
            set
            {
                if (index > -1 && index < this.str.Length)
                    this.str[index] = value;
            }
        }

        public int Count
        {
            get { return this.str.Length; }
        }

        public void Print()
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

        }

        public static IntArray operator *(IntArray a, IntArray b)
        {
            IntArray res = new IntArray();
            if (a.Count == b.Count)
            {
                res = new IntArray(a.Count);
                for (int i = 0; i < res.Count; i++)
                {
                    res[i] = a[i] * b[i];

                }
            }
            else
            {
                Console.WriteLine("У массивов разное количество элементов");
            }
            return res;
        }

        public static bool operator ==(IntArray a, IntArray b)
        {
            return (a.str == b.str);
        }

        public static bool operator !=(IntArray a, IntArray b)
        {
            return (a.str != b.str);
        }
        public static bool operator <=(IntArray a, IntArray b)
        {
            return (a.str.Sum() <= b.str.Sum());
        }
        public static bool operator >=(IntArray a, IntArray b)
        {
            return (a.str.Sum() >= b.str.Sum());
        }

        public static IntArray operator +(IntArray a, IntArray b)
        {

            IntArray res = new IntArray();
            if (a.Count == b.Count)
            {
                res = new IntArray(a.Count);
                for (int i = 0; i < res.Count; i++)
                {
                    res[i] = a[i] + b[i];

                }
            }
            else
            {
                Console.WriteLine("У массивов разное количество элементов");
            }
            return res;

        }

    }
}
