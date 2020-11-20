// problem link - https://codeforces.com/contest/71/problem/A

using System;
using System.Linq;

namespace CF_WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string words = Console.ReadLine();
                if(words.Count() > 10 )
                    Console.WriteLine(words.Substring(0,1) + (words.Count()-2) + words.Last());
                else
               Console.WriteLine(words);
            }
        }
    }
}
