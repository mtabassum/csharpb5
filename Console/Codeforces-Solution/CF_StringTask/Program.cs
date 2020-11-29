
//problem link:http://codeforces.com/contest/118/problem/A
/* The program was supposed to do the following: in the given string, consisting if uppercase and lowercase letters, it:

--deletes all the vowels,
--inserts a character "." before each consonant,
--replaces all uppercase consonants with corresponding lowercase ones. */

using System;

namespace CF_118A_StringTask
{
   class Program
   {
       static void Main(string[] args)
       {
           string str1;
           string str2 = string.Empty;
           char[] arr;

           Console.Write("Input String-");
           str1 = Console.ReadLine();

           int length = str1.Length;
           arr = str1.ToCharArray();

           for (int i = 0; i < length; i++)
           {
               if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u' || arr[i] == 'y' ||
                   arr[i] == 'A' || arr[i] == 'E' || arr[i] == 'I' || arr[i] == 'O' || arr[i] == 'U' || arr[i] == 'Y') 

                   continue;
               else
               {
                   str2 += '.';
                   str2 += Char.ToLower(arr[i]);
               }
           }

           Console.WriteLine(str2);
       }
   }
}
