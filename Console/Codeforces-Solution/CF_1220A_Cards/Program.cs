// http://codeforces.com/problemset/problem/1220/A


using System;

namespace CF_1220A_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
             int one = 0, zero = 0;
             string str = string.Empty;

            var length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (str[i] == 'n')
                    Console.WriteLine("1 ");
                else if (str[i] == 'z')
                    zero++;
            }


            for(int i=0; i<zero; i++)
            {
                Console.WriteLine("0 ");
            }
        }
    }
}
