using System;

namespace String_ends_with
{
    class Program
    {
            public static bool Solution(string str, string ending)
            {
                int b = 0;
                for (int i = str.Length - ending.Length; i < str.Length; i++)
                {
                    if (i < 0) { return false; }
                    if (str[i] == ending[b]) { b++; }
                    else { return false; }
                }
                return true;
            }
        static void Main(string[] args)
        {
            string str;
            string end;

            str = Convert.ToString(Console.ReadLine());
            end = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Solution(str, end));

            Console.ReadKey();
        }
    }
}
