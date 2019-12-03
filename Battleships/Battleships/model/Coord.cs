using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model
{
    class Coord
    {
        private int _xAxis;
        private int _yAxis;
        private bool _isShip;
        private bool _isOccupied;
        private bool _isHit;

        public Coord(int xAxis, int yAxis, bool isShip = false, bool isOccupied = false, bool isHit = false)
        {
            XAxis = xAxis;
            YAxis = yAxis;
            IsShip = isShip;
            IsOccupied = isOccupied;
            IsHit = isHit;
        }

        public int XAxis { get => _xAxis; set => _xAxis = value; }
        public int YAxis { get => _yAxis; set => _yAxis = value; }
        public bool IsShip { get => _isShip; set => _isShip = value; }
        public bool IsOccupied { get => _isOccupied; set => _isOccupied = value; }
        public bool IsHit { get => _isHit; set => _isHit = value; }
    }
}
