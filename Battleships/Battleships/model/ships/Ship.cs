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
        public Coord FirstShipPart { get; set; }//?
        public bool IsDestroyed { get; set; }

        public Ship(Coord firstShipPart, bool isDestroyed = false)
        {
            FirstShipPart = firstShipPart;
            IsDestroyed = isDestroyed;

        }
        public abstract bool CheckIfShipIsDestroyed(List<Coord> ShipParts);
        public abstract List<Coord> BuildShip();
    }
}