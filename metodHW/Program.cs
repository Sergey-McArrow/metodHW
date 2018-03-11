using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodHW
{
    class Program
    {
        static int Minvalue(int n1, int n2)//10.5
        {
            if (n1 < n2)
            { return n1; }
            else if (n1 > n2)
            { return n2; }
            else
            {
                Console.WriteLine("They are equal");
                return 0;
            }
        }
        static int Maxvalue(int n1, int n2)//10.5
        {
            if (n1 > n2)
            { return n1; }
            else if (n1 < n2)
            { return n2; }
            else
            {
                Console.WriteLine("They are equal");
                return 0;
            }
        }

        static int arrayMin(int[] arrayMinMax)//10.6
        {
            int Minvalue = arrayMinMax[0];
                
            for (int i = 1; i < arrayMinMax.Length; i++)
            {
                if (Minvalue>arrayMinMax[i])
                {
                    Minvalue = arrayMinMax[i];
                }
            }
            return Minvalue;
        }

        static int arrayMax(int[] arrayMinMax)//10.6
        {
            int MaxValue = arrayMinMax[0];
            for (int i = 1; i < arrayMinMax.Length; i++)
            {
                if (MaxValue < arrayMinMax[i])
                {
                    MaxValue = arrayMinMax[i];
                }
            }
            return MaxValue;
        }

        static int SUM(int N)//10.7
        {
            int sum=0;
            for (int i = 0; i <= N; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TASK 10.5.Написать две функции, которые возвращают соответственно минимум и максимум из двух чисел, которые передаются в функцию в качестве аргументов.");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Minvalue(n1,n2));
            Console.WriteLine(Maxvalue(n1,n2));

            Console.WriteLine("TASK 10.6. Создать две функции,в которые передается массив чисел. Функции должны возвратить минимальный и максимальный элемент массива соответственно.");
            Console.WriteLine("Input array length");
            int length = int.Parse(Console.ReadLine());
            int [] arrayMinMax = new int [length];
            Console.WriteLine($"Input {length} numbers");
            for (int i = 0; i < length; i++)
            {
                arrayMinMax[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Min: {arrayMin(arrayMinMax)}");
            Console.WriteLine($"Max; {arrayMax(arrayMinMax)}");

            Console.WriteLine("TASK 10.7. Написать функцию вычисления суммы целых чисел от 1 до N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(SUM(N));

        }
    }
}
