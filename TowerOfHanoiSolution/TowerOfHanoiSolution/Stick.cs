using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace TowerOfHanoiSolution
{
    class Stick
    {
        public SortedList<int, string> Disks = new SortedList<int, string>();
        public int Number { get; set; }


        public void AddDisk(Disk aDisk)
        {
            Disks.Add(aDisk.number, aDisk.Color);
        }

        public void RemoveDisk(Disk aDisk)
        {
            Disks.Remove(aDisk.number);
        }
    }
}
