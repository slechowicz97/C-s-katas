using System;

namespace Sum_Mixed_Array
{
    class Program
    {
        public static int SumMix(object[] x)
        {
            int a = 0, sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                a = System.Convert.ToInt32(x[i]);
                sum = sum + a;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            object[] tab = { "5", "0", 9, 3, 2, 1, "9", 6, 7 };
            Console.WriteLine(SumMix(tab));
            Console.ReadKey();
        }
    }
}
