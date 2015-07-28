﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    internal class Cell
    {
        public Cell()
        {
        }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Value = 1;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Value { get; set; }
    }
}
