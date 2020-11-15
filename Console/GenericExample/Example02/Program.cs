using System;
using System.Collections.Generic;

namespace Example02
{
    class Program
    {
		static List<T> GetList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }

        static void Main()
        {
            List<bool> list1 = GetList(true, 3);
            List<string> list2 = GetList<string>("Paris", 2);
            foreach (bool value in list1)
            {
                Console.WriteLine(value);
            }
            foreach (string value in list2)
            {
                Console.WriteLine(value);
            }
        }
	}
}
