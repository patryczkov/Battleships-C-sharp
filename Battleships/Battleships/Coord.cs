using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Coord
    {
        public int XAxis { get; }
        public int YAxis { get; }

        public Coord(int xAxis, int yAxis)
        {
            XAxis = xAxis;
            YAxis = yAxis;
        }
    }
}
