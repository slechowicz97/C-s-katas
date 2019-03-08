using System;

class Solution
{
    public static int Solution1(int[] A)
    {   
        Array.Sort(A);
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine(A[i]);
        }
        int c = 0;
        for (int i = 0; i < A.Length - 1; i++)
        {
            if (A[i] == A[i+1]) { continue; }
            if (A[i] + 1 != A[i + 1])
            {
                return A[i]+1;
            }
        }
        return 0;
    }

static void Main(string[] args)
        {
        int[] A = { 11, 31, 6, 3, 1, 2 };
        Console.WriteLine(Solution1(A));

        Console.WriteLine(A[0]);
        Console.ReadKey();
        }
    
}

