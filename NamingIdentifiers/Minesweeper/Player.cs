using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Player
    {
        private string _name;
        private int _points;

        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }


        public string Name
        {
            get { return this._name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "Name can not be empty or null!");
                }
                this._name = value;
            }
        }

        public int Points
        {
            get { return this._points; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points", "Points can not be negative number!");
                }
                this._points = value;
            }
        }
    }
}

