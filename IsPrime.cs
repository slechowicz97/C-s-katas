using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Program
    {
        public static bool IsPrime(int n)
        {
            if (n < 0) { return false; }
            if ((n == 0) || (n == 1)) { return false; }
            if (n != 2) { if (n % 2 == 0) { return false; } }

            for (int i = 3; i <= System.Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
            Console.ReadKey();
            
        }
    }
}
