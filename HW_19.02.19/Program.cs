using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19._02._19
{
    public class Program
    {
        int[] arr = { 1, 2, 3, 4 };
        int[] arr1 = { 1, 1, 1, 1 };

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Box a = new Box(25, 20, 40);
                Box b = new Box(20, 20, 40);

                Console.WriteLine(a == b);
                Console.WriteLine(a != b);
                Console.WriteLine(a.Equals(b));
            }
            else if (number == 2)
            {
                Program p = new Program();
                Program p1 = new Program();

                if (p > p1)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);

                }
            }
            else if (number == 3)
            {
                Money m = new Money(100, "USD");
                Money m1 = new Money(200, "USD");

                if (m == m1)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);

                if (m != m1)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);
            }
            else if (number == 4)
            {
                IntArray arr = new IntArray(5);
                IntArray arr1 = new IntArray(5);

                Random rnd = new Random();
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[i] = rnd.Next(1, 10);
                }
                for (int i = 0; i < arr1.Count; i++)
                {
                    arr1[i] = rnd.Next(1, 10);
                }

                arr.Print();
                arr1.Print();

                IntArray arr2 = arr * arr1;
                arr2.Print();

                if (arr == arr1)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                if (arr <= arr1)
                {
                    Console.WriteLine("Сумма arr меньше или равно сумме arr1");
                }

                if (arr >= arr1)
                {
                    Console.WriteLine("Сумма arr больше или равно сумме arr1");

                }

                IntArray arr3 = arr + arr1;
                arr3.Print();
            }
        }
        public static bool operator <(Program a, Program b)
        {
            return a.arr.Sum() < b.arr1.Sum();
        }
        public static bool operator >(Program a, Program b)
        {
            return a.arr.Sum() > b.arr1.Sum();
        }


    }

}
