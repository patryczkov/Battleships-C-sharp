using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model.ships
{
    public class Destroyer : Ship
    {
        private List<Square> listShipSquares = new List<Square>();
        public Destroyer(Board board, int firstPartIndex, bool isVertical) : base(board, firstPartIndex, isVertical)
        {
            ShipLenght = 4;
            ShipTypeName = "Destroyer";
            Console.WriteLine(ShipTypeName);
            BuildShip(board, firstPartIndex, isVertical);
            Console.WriteLine(ShipTypeName + "build");
        }

        public override void BuildShip(Board board, int firstPartIndex, bool isVertical)
        {
            if (!isVertical)
            {
                for (var i = 0; i < ShipLenght; i++)
                {
                    ChangeSquaresIntoShipPartsAndAgregate(board, i, firstPartIndex);
                    ChangeSquaresIntoOcupationStatus(board, i, firstPartIndex);
                }
            }
            else
            {
                for (var i = 0; i < ShipLenght * 10; i += 10)
                {
                    ChangeSquaresIntoShipPartsAndAgregate(board, i, firstPartIndex);
                    ChangeSquaresIntoOcupationStatus(board, i, firstPartIndex);
                }
            }
        }
        private void ChangeSquaresIntoShipPartsAndAgregate(Board board, int i, int firstPartIndex)
        {
            board.SquareList[firstPartIndex + i].IsShip = true;
            board.SquareList[firstPartIndex + i].CheckTypeOfSquare();
            listShipSquares.Add(board.SquareList[firstPartIndex + i]);
        }
        private void ChangeSquaresIntoOcupationStatus(Board board, int i, int firstPartIndex)
        {
            if (board.SquareList[firstPartIndex].Coord.XAxis > 0 && board.SquareList[firstPartIndex].Coord.XAxis < 9 && board.SquareList[firstPartIndex].Coord.YAxis > 0 && board.SquareList[firstPartIndex].Coord.YAxis < 9)
            {

                board.SquareList[firstPartIndex + i - 11].IsOccupied = true;
                board.SquareList[firstPartIndex + i - 10].IsOccupied = true;
                board.SquareList[firstPartIndex + i - 9].IsOccupied = true;

                board.SquareList[firstPartIndex + i - 11].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i - 10].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i - 9].CheckTypeOfSquare();

                listShipSquares.Add(board.SquareList[firstPartIndex + i - 11]);
                listShipSquares.Add(board.SquareList[firstPartIndex + i - 10]);
                listShipSquares.Add(board.SquareList[firstPartIndex + i - 9]);

                board.SquareList[firstPartIndex + i - 1].IsOccupied = true;
                board.SquareList[firstPartIndex + i].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 1].IsOccupied = true;

                listShipSquares.Add(board.SquareList[firstPartIndex + i - 1]);
                board.SquareList[firstPartIndex + i - 1].CheckTypeOfSquare();
                listShipSquares.Add(board.SquareList[firstPartIndex + i]);
                board.SquareList[firstPartIndex + i].CheckTypeOfSquare();
                listShipSquares.Add(board.SquareList[firstPartIndex + i + 1]);
                board.SquareList[firstPartIndex + i + 1].CheckTypeOfSquare();

                board.SquareList[firstPartIndex + i + 9].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 10].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 11].IsOccupied = true;

                listShipSquares.Add(board.SquareList[firstPartIndex + i + 9]);
                listShipSquares.Add(board.SquareList[firstPartIndex + i + 10]);
                listShipSquares.Add(board.SquareList[firstPartIndex + i + 11]);

                board.SquareList[firstPartIndex + i + 9].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i + 10].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i + 11].CheckTypeOfSquare();
            }
        }

        public override bool CheckIfShipIsDestroyed(List<Square> ShipParts)
        {
            throw new NotImplementedException();
        }
    }
}
