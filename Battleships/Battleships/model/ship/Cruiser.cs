using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.model.ships
{
    class Cruiser : Ship
    {
        private List<Square> listShipSquares = new List<Square>();
        public Cruiser(Board board, int firstPartIndex, bool isVertical) : base(board, firstPartIndex, isVertical)
        {
            ShipLenght = 3;
            ShipTypeName = "Cruiser";
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
                    //ChangeSquaresIntoOcupationStatus(board, i, firstPartIndex);
                }
            }
            else
            {
                for (var i = 0; i < ShipLenght * 10; i += 10)
                {
                    ChangeSquaresIntoShipPartsAndAgregate(board, i, firstPartIndex);
                    // ChangeSquaresIntoOcupationStatus(board, i, firstPartIndex);
                }
            }
        }
        private void ChangeSquaresIntoShipPartsAndAgregate(Board board, int i, int firstPartIndex)
        {
            board.SquareList[firstPartIndex + i].IsShip = true;
            board.SquareList[firstPartIndex + i].CheckTypeOfSquare();
            ChangeSquaresIntoOcupationStatus(board, i, firstPartIndex);
            listShipSquares.Add(board.SquareList[firstPartIndex + i]);
        }
        private void ChangeSquaresIntoOcupationStatus(Board board, int i, int firstPartIndex)
        {
            try
            {

                board.SquareList[firstPartIndex + i - 11].IsOccupied = true;
                board.SquareList[firstPartIndex + i - 10].IsOccupied = true;
                board.SquareList[firstPartIndex + i - 9].IsOccupied = true;

                board.SquareList[firstPartIndex + i - 11].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i - 10].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i - 9].CheckTypeOfSquare();



                board.SquareList[firstPartIndex + i - 1].IsOccupied = true;
                board.SquareList[firstPartIndex + i].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 1].IsOccupied = true;



                board.SquareList[firstPartIndex + i - 1].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i + 1].CheckTypeOfSquare();

                board.SquareList[firstPartIndex + i + 9].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 10].IsOccupied = true;
                board.SquareList[firstPartIndex + i + 11].IsOccupied = true;



                board.SquareList[firstPartIndex + i + 9].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i + 10].CheckTypeOfSquare();
                board.SquareList[firstPartIndex + i + 11].CheckTypeOfSquare();
            }
            catch { }
          
            

        }

        public override bool CheckIfShipIsDestroyed(List<Square> ShipParts)
        {
            throw new NotImplementedException();
        }
    }
}
