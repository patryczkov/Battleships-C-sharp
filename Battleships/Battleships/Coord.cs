using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Coord
    {

        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsHit { get; set; }

        public Coord(int xAxis, int yAxis, bool isOccupied = false, bool isHit = false)
        {
            XAxis = xAxis;
            YAxis = yAxis;
            IsOccupied = isOccupied;
            IsHit = isHit;
        }
    }
}
