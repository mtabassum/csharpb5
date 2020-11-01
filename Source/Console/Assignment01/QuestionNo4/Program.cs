using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {  

            int i, j;

            Console.Write("Enter No. of element-");
            int no = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[no, no];

            Console.Write("\n\nInput Elements :\n");
           
            for(i=0; i<no; i++)
            {
                for(j=0; j<no; j++)
                {
                     Console.Write("Element - [{0},{1}] ",i,j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            printDiagonalSums(arr, no);
            }

            static void printDiagonalSums(int[,] arr, int length)
            {
                int principal = 0, secondary = 0;
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i == j)
                            principal += arr[i, j];

                        if ((i + j) == (length - 1))
                            secondary += arr[i, j];
                    }
                }

                Console.WriteLine("Sum of Principal Diagonal:" + principal);

                Console.WriteLine("Sum of Secondary Diagonal:" + secondary);
            }
        }
    }

