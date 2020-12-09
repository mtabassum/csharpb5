// https://codeforces.com/problemset/problem/96/A

using System;

namespace CF_96A_Football
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var one = 0; var zero = 0;
            var isDangerous = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1' )
                {
                    one++;
                    zero = 0;
                }
                else
                {
                    zero++;
                    one = 0;
                }

                if (zero == 7 || one == 7)
                {
                    isDangerous = 1;
                    break;
                }
            }
               if (isDangerous == 1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            
        }
    }
}
