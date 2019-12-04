using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public abstract class Ship
    {

        public string ShipTypeName { get; set; }
        public int ShipLenght { get; set; }
        public Board Board { get; set; }//?
        public bool IsVertical { get; set; }

        public Ship(Board board, int firstPartId, bool isVertical)
        {
            Board = board;
            IsVertical = isVertical;

        }
        public abstract bool CheckIfShipIsDestroyed(List<Square> ShipParts);
        public abstract void BuildShip(Board board, int firstPartIndex, bool isVertical);
    }
}