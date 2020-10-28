using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 },
                         { 4, 3, 2, 1 },
                         { 5, 6, 7, 8 },
                         { 8, 7, 6, 5 } };

            printDiagonalSums(a, 4);
        }

        static void printDiagonalSums(int[,] arr, int n)
        {
            int principal = 0, secondary = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        principal += arr[i, j];

                    if ((i + j) == (n - 1))
                        secondary += arr[i, j];
                }
            }

            Console.WriteLine("Sum of Principal Diagonal:"+ principal);

            Console.WriteLine("Sum of Secondary Diagonal:"+ secondary);
        }

    }
}
