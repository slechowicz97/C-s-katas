using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPossitive
{
    class Program
    {
        static int PositiveSum(double[] arr)
        {
            int sum = 0;
            foreach (int element in arr)
            {
                if (element > 0)
                {
                    sum += element;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] a = new double[10];
            for (int i=0; i<10; i++)
            {
                a[i] = rand.Next(-160, 160);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(PositiveSum(a));
            Console.ReadKey();
        }

    }
}

