﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model.ships
{
    class Cruiser : Ship
    {
        private List<Square> listShipSquares;
        public Cruiser(Board board, int firstPartIndex, bool isVertical) : base(board, firstPartIndex, isVertical)
        {
            ShipLenght = 3;
            ShipTypeName = "Creuiser";
            BuildShip(board, firstPartIndex, isVertical);
        }

        public override void BuildShip(Board board, int firstPartIndex, bool isVertical)
        {
            if (!isVertical)
            {
                for (var i = 0; i < ShipLenght; i++)
                {
                    ChangeSquaresIntoShipPartsAndAgregate(board, i, firstPartIndex);
                }
            }
            else
            {
                for (var i = 0; i < ShipLenght * 10; i += 10)
                {
                    ChangeSquaresIntoShipPartsAndAgregate(board, i, firstPartIndex);
                }
            }
        }
        private void ChangeSquaresIntoShipPartsAndAgregate(Board board, int i, int firstPartIndex)
        {
            board.SquareList[firstPartIndex + i].IsShip = true;
            listShipSquares.Add(board.SquareList[firstPartIndex + i]);
        }

        public override bool CheckIfShipIsDestroyed(List<Square> ShipParts)
        {
            throw new NotImplementedException();
        }
    }
}
