using System;
using System.Collections.Generic;
using System.Text;

namespace TowerOfHanoiSolution
{
    public class Disk
    {
        private int numDiscs;
        private string color;

        public int number
        {
            get { return numDiscs; }

            set { numDiscs = value; }
        }

        public string Color
        {
            get { return color; }

            set { color = value; }
        }
    }
}
