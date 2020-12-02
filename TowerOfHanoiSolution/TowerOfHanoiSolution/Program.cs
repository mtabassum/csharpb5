using System;
using System.Collections;
using System.Collections.Generic;

namespace TowerOfHanoiSolution
{
    class Program
    {
        static Disk red = new Disk();
        static Disk green = new Disk();
        static Disk blue = new Disk();
        static Disk red2 = new Disk();
        static Disk green2 = new Disk();
        static Disk blue2 = new Disk();
        static Disk red3 = new Disk();
        static Disk green3 = new Disk();
        static Disk blue3 = new Disk();
        static List<Stick> stick1 = new List<Stick>();
        static List<Stick> stick2 = new List<Stick>();
        static List<Stick> stick3 = new List<Stick>();
        static int moveCount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Hanoi Game!");

            AssingDiskToStick();

           PrintStick();
           Console.WriteLine("\nEnter Disk Move From Stick (Example - 1 or 2 or 3) : \n");
           String fromDisk = Console.ReadLine();
           Console.WriteLine("\nEnter Disk Move To Stick (Example - 1 or 2 or 3) : \n");
           String toDisk = Console.ReadLine();


           MoveDisk(Convert.ToInt32(fromDisk), Convert.ToInt32(toDisk));

           moveCount = 0;
        }

        private static void AssingDiskToStick()
        {
            red.number = 1;
            red.Color = "Red";

            green.number = 2;
            green.Color = "Green";

            blue.number = 3;
            blue.Color = "Blue";


            red2.number = 4;
            red2.Color = "Red";

            green2.number = 5;
            green2.Color = "Green";

            blue2.number = 6;
            blue2.Color = "Blue";

            red3.number = 7;
            red3.Color = "Red";

            green3.number = 8;
            green3.Color = "Green";

            blue3.number = 9;
            blue3.Color = "Blue";

            Stick aStick = new Stick();
            aStick.Number = 1;
            aStick.AddDisk(red);
            stick1.Add(aStick);
            aStick = new Stick();
            aStick.Number = 1;
            aStick.AddDisk(green);
            stick1.Add(aStick);
            aStick = new Stick();
            aStick.Number = 1;
            aStick.AddDisk(blue);
            stick1.Add(aStick);


            aStick = new Stick();
            aStick.Number = 2;
            aStick.AddDisk(red2);
            stick2.Add(aStick);
            aStick = new Stick();
            aStick.Number = 2;
            aStick.AddDisk(green2);
            stick2.Add(aStick);
            aStick = new Stick();
            aStick.Number = 2;
            aStick.AddDisk(blue2);
            stick2.Add(aStick);


            aStick = new Stick();
            aStick.Number = 3;
            aStick.AddDisk(red3);
            stick3.Add(aStick);
            aStick = new Stick();
            aStick.Number = 3;
            aStick.AddDisk(green3);
            stick3.Add(aStick);
            aStick = new Stick();
            aStick.Number = 3;
            aStick.AddDisk(blue3);
            stick3.Add(aStick);
        }

        private static void MoveDisk(int diskFrom, int diskTo)
        {
            SortedList<int, string> Disks = new SortedList<int, string>();
           
            // Get Data for move 
            if (diskFrom == 1)
            {
                Disks = stick1[0].Disks;

            }
            else if (diskFrom == 2)
            {
                Disks = stick2[0].Disks;
            }
            else if (diskFrom == 3)
            {
                Disks = stick3[0].Disks;
            }

            // Move Data
            if (diskTo == 1)
            {
                Disk disk = new Disk();
                Stick aStick = new Stick();
                aStick.Number = 1;
                IList<string> diskOneValue = Disks.Values;
                foreach (var value  in diskOneValue)
                {
                    disk.Color = value;
                }

                IList<int> diskOneKey = Disks.Keys;
                foreach (var value in diskOneKey)
                {
                    disk.number = value;
                }
                aStick.AddDisk(disk);
                stick1.Add(aStick);
            }
            else if (diskTo == 2)
            {
                Disk disk = new Disk();
                Stick aStick = new Stick();
                aStick.Number = 2;
                IList<string> diskTwoValue = Disks.Values;
                foreach (var value in diskTwoValue)
                {
                    disk.Color = value;
                }

                IList<int> diskTwoKey = Disks.Keys;
                foreach (var value in diskTwoKey)
                {
                    disk.number = value;
                }
                aStick.AddDisk(disk);
                stick2.Add(aStick);
            }
            else if (diskTo == 3)
            {
                Disk disk = new Disk();
                Stick aStick = new Stick();
                aStick.Number = 3;
                IList<string> diskThreeValue = Disks.Values;
                foreach (var value in diskThreeValue)
                {
                    disk.Color = value;
                }

                IList<int> diskThreeKey = Disks.Keys;
                foreach (var value in diskThreeKey)
                {
                    disk.number = value;
                }
                aStick.AddDisk(disk);
                stick3.Add(aStick);
            }

            // Remove Data
            if (diskFrom == 1)
            {
                stick1.RemoveAt(0);
            }
            else if (diskFrom == 2)
            {
                stick2.RemoveAt(0);
            }
            else if (diskFrom == 3)
            {
                stick3.RemoveAt(0);
            }

            moveCount++;
            Console.WriteLine($"\n Disk Move {moveCount} From Stick {diskFrom} To Stick {diskTo.ToString()} : \n");

            PrintStick();

            Console.WriteLine("\nEnter Disk Move From Stick (Example - 1 or 2 or 3) : \n");
            String fromDisk = Console.ReadLine();
            Console.WriteLine("\nEnter Disk Move To Stick (Example - 1 or 2 or 3) : \n");
            String toDisk = Console.ReadLine();

            MoveDisk(Convert.ToInt32(fromDisk), Convert.ToInt32(toDisk));
        }


        private static void PrintStick()
        {
            Console.WriteLine("\nStick One \n");
            List<String> stickArrayDataOne = new List<string>();
            List<String> stickArrayDataTwo = new List<string>();
            List<String> stickArrayDataThree = new List<string>();
            for (int i = 0; i < stick1.Count; i++)
            {
                IList<string> value = stick1[i].Disks.Values;
                foreach (var VARIABLE in value)
                {
                    stickArrayDataOne.Add(VARIABLE);
                }

            }
            Console.WriteLine(string.Join("\n", stickArrayDataOne));
            Console.WriteLine("\nStick Two \n");
            for (int i = 0; i < stick2.Count; i++)
            {
                IList<string> value = stick2[i].Disks.Values;
                foreach (var VARIABLE in value)
                {
                    stickArrayDataTwo.Add(VARIABLE);
                }

            }
            Console.WriteLine(string.Join("\n", stickArrayDataTwo));
            Console.WriteLine("\nStick Three \n");
            for (int i = 0; i < stick3.Count; i++)
            {
                IList<string> value3 = stick3[i].Disks.Values;
                foreach (var VARIABLE in value3)
                {
                    stickArrayDataThree.Add(VARIABLE);
                }

            }
            Console.WriteLine(string.Join("\n", stickArrayDataThree));

        }
    }

}
