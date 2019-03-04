
/* Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
The output should be two capital letters with a dot seperating them.
It should look like this:
Sam Harris => S.H
Patrick Feeney => P.F
*/

using System;
namespace ConsoleApp1
{
   class Program
   {
       public static string AbbrevName(string name)
       {
           string c = "", a = "";
           for (int i = 0; i < name.Length; i++)
           {
               if (name[i] == 32) { i++; c = System.Convert.ToString(name[i]); a = System.Convert.ToString(name[0]); break; }
           }
           return a.ToUpper() + "." + c.ToUpper();
       }

       static void Main(string[] args)
       {
           string first = "Alicja Kowalska", second = "Jan Nowak";
           Console.WriteLine(AbbrevName(first));
           Console.WriteLine(AbbrevName(second));
           Console.ReadKey();
       }
   }
}
