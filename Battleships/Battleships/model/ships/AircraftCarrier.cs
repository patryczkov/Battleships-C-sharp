using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model.ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier(Coord firstShipPart, bool isDestroyed = false) : base(firstShipPart, isDestroyed)
        {
            ShipTypeName = "AircraftCarrier";
            ShipLenght = 5;
        }
        
        public override List<Coord> BuildShip()
        {
            throw new NotImplementedException();
        }

        public override bool CheckIfShipIsDestroyed(List<Coord> ShipParts)
        {
            throw new NotImplementedException();
        }

    }
}
