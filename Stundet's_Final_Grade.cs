
/*
Create a function finalGrade, which calculates the final grade of a student depending on two parameters: a grade for the exam and a number of completed projects.

This function should take two arguments: exam - grade for exam (from 0 to 100); projects - number of completed projects (from 0 and above);
This function should return a number (final grade). There are four types of final grades:

100, if a grade for the exam is more than 90 or if a number of completed projects more than 10.
90, if a grade for the exam is more than 75 and if a number of completed projects is minimum 5.
75, if a grade for the exam is more than 50 and if a number of completed projects is minimum 2.
0, in other cases
*/

using System;

namespace Student_s_Final_Grade
{
    class Program
    {
            public static int FinalGrade(int exam, int projects)
            {
                if ((exam >= 90) || (projects > 10)) { return 100; }
                else if ((exam > 75) && (projects >= 5)) { return 90; }
                else if ((exam > 50) && (projects >= 2)) { return 75; }
                return 0;
            }
      
    static void Main(string[] args)
        {
            int exam, projects;
            Console.WriteLine("Podaj wynik egzaminu w %");
            exam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę projektów ukończonych przez studenta");
            projects = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FinalGrade(exam, projects));
            Console.ReadKey();
        }
    }
}
