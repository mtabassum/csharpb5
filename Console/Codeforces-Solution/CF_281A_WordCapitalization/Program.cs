// https://codeforces.com/problemset/problem/281/A


using System;

namespace CF_281A_WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.Length == 1)
            {
                Console.WriteLine(char.ToUpper(word[0]));
            }
            else
            {
                Console.WriteLine(Char.ToUpper(word[0]) + word.Substring(1));
            }
        }
    }
}
