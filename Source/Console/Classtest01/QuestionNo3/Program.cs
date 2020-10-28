using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0, odd = 0;
            Console.WriteLine("No of elments:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

 
            Console.WriteLine("Reverse Array-");
            Array.Reverse(array);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            int[] array2 = new int[n];
            int[] array3 = new int[n];

            for (int i=0; i<n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array2[even] = array[i];
                    even++;
                }
                else
                    array3[odd] = array[i];
                    odd++;
            }

            Console.Write("Even numbers ");

            for (int i = 0; i < even; i++)
            {
                Console.Write("{0} ", array2[i]);
            }

            Console.Write("\nOdd numbers");

            for (int i = 0; i < odd; i++)
            {
                Console.Write("{0} ", array3[i]);
            }

            Array.Reverse(array2);

            Array.Reverse(array3);

            Console.Write("\nThe even elements are ");

            for (int i = 0; i < even; i++)
            {
                Console.Write("{0},", array2[i]);
            }

            Console.Write("\nThe odd elements are ");

            for (int i = 0; i < odd; i++)
            {
                Console.Write("{0},", array3[i]);
            }


            Console.ReadKey();

        }

    }
}

