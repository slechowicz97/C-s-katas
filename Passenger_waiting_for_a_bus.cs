using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passengers_waiting_for_a_bus
{
    class Program
    {
        public static int Enough(int cap, int on, int wait)
        {
            return Math.Abs(cap - on - wait);

            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int cap, on = 0, wait = 0;
            Console.WriteLine("Podaj ilosc miejsc w autobusie");
            cap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ilosc ludzi znajdujacych sie w autobusie");
            on = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ilosc ludzi na przystanku");
            wait = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Autobus nie zabierze {0} pasazerow",Enough(cap, on, wait));
            Console.ReadKey();
        }

    }
}
