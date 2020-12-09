// http://codeforces.com/problemset/problem/1199/B

using System;

namespace CF_1199B_WaterLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var h = double.Parse(input[0]);
            var l = double.Parse(input[1]);

            var result = ((l * l - h * h) / (2 * h)).ToString("0.00000000");

            Console.WriteLine(result);
        }
    }
}