using System;

namespace Trzeci
{
    class Program
    {
            public static bool isDivisible(long n, long x, long y)
            {
                bool a = true;
                if ((n % x == 0) && (n % y == 0)) { return a; }
                else return false;
            }
        
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Podaj liczbę dla której sprawdzasz podzielność");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj potencjalny dzielnik");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi potencjalny dzielnik");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isDivisible(a,b,c));
            Console.ReadKey();
        }
    }
}
