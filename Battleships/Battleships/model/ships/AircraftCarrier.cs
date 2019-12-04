using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model.ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier(Board board, int firstPartIndex, bool isVertical) : base(board, firstPartIndex, isVertical)
        {
            ShipLenght = 5;
            ShipTypeName = "AircraftCarrier";
            BuildShip(board, firstPartIndex, isVertical);
        }

        public override void BuildShip(Board board, int firstPartIndex, bool isVertical)
        {
            if (!isVertical)
            {
                for (var i = 0; i < ShipLenght; i++)
                {
                    board.SquareList[firstPartIndex + i].IsShip = true;
                }
            }
            else
            {
                for (var i = 0; i < ShipLenght * 10; i += 10)
                {
                    board.SquareList[firstPartIndex + i].IsShip = true;
                }
            }
        }

        public override bool CheckIfShipIsDestroyed(List<Square> ShipParts)
        {
            throw new NotImplementedException();
        }
    }
}
