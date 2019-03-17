using System;

namespace Rent_Cars
{
    class Program
    {

     public static int RentalCarCost(int d)
            {
                if (d >= 7) { return d * 40 - 50; }
                else if (d >= 3) { return d * 40 - 20; }
                else return d * 40;
            }
        
        static void Main(string[] args)
        {
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RentalCarCost(d));
            Console.ReadKey();
        }
    }
}
