using System;

namespace Sum_Mixed_Array
{
    class Program
    {
        public static int SumMix(object[] x)
        {
            return x.Sum(Convert.ToInt32);
        }

        static void Main(string[] args)
        {
            object[] tab = { "5", "0", 9, 3, 2, 1, "9", 6, 7 };
            Console.WriteLine(SumMix(tab));
            Console.ReadKey();
        }
    }
}
