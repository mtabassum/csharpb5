// https://codeforces.com/problemset/problem/131/A


using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CF_131A_cAPSlOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLetterCapital = true;
            char  u ;
            var word = Console.ReadLine();

            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                    allLetterCapital = false;
            }

            if (allLetterCapital)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (char.IsLower(word[j]))
                       char.ToUpper(word[j]);

                    Console.WriteLine(word);
                }
            }

            
        }
    }
}
