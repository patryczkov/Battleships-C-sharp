using Battleships.model.ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Shipyard
    {
        private Board _board;

        public Shipyard(Board board)
        {
            _board = board;
        }
        public void CreateShip(int shipSize, int id, bool isVertical)
        {
            if (shipSize == 5 && isVertical)
            {

                if (CheckIfShipAbleToDeployVerticaly(shipSize, id))
                {
                    new AircraftCarrier(_board, id, isVertical);
                }
               // Exit();
            }
            else if (shipSize == 5 && !isVertical)
            {

                if (CheckIfShipAbleToDeployHorizontaly(shipSize, id))
                {
                    new AircraftCarrier(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 4 && isVertical)
            {

                if (CheckIfShipAbleToDeployVerticaly(shipSize, id))
                {
                    new  Destroyer(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 4 && !isVertical)
            {

                if (CheckIfShipAbleToDeployHorizontaly(shipSize, id))
                {
                    new Destroyer(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 3 && isVertical)
            {

                if (CheckIfShipAbleToDeployVerticaly(shipSize, id))
                {
                    new Cruiser(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 3 && !isVertical)
            {

                if (CheckIfShipAbleToDeployHorizontaly(shipSize, id))
                {
                    new  Cruiser(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 2 && isVertical)
            {

                if (CheckIfShipAbleToDeployVerticaly(shipSize, id))
                {
                    new Submarine(_board, id, isVertical);
                }
               // Exit();

            }
            else if (shipSize == 2 && !isVertical)
            {

                if (CheckIfShipAbleToDeployHorizontaly(shipSize, id))
                {
                    new Submarine(_board, id, isVertical);
                }
               // Exit();

            }

           
        }
        private bool CheckIfShipAbleToDeployHorizontaly(int shipSize, int id)
        {
            if (_board.SquareList[id].IsOccupied == false && _board.SquareList[id].Coord.XAxis + shipSize < 9)
            {
                Console.WriteLine(_board.SquareList[id].Coord.XAxis);
                return true;
            }
            return false;
        }
        private bool CheckIfShipAbleToDeployVerticaly(int shipSize, int id)
        {
            if (_board.SquareList[id].IsOccupied == false && _board.SquareList[id].Coord.YAxis + shipSize < 9)
            {
                return true;
            }
            return false;
        }
        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}