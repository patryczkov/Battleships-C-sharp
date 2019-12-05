using Battleships.model.ships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{

    class Shipyard
    {
        private Board _board;
        private List<int> shipList = new List<int>() { 0, 1, 2, 3};

        public Shipyard(Board board)
        {
            _board = board;
        }
        public void CreateShip(int shipSize, int id, bool isVertical)
        {
            Console.WriteLine("Create ship");
            if (shipList.Count != 0)
            {
                if (CheckPosition(shipSize, id, isVertical))
                {
                    if (shipSize == 5)
                    {
                        new AircraftCarrier(_board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 4)
                    {
                        new Destroyer(_board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 3)
                    {
                        new Cruiser(_board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 2)
                    {
                        new Submarine(_board, id, isVertical);
                        shipList.Remove(0);
                    }
                }
                else CreateShip(shipSize, MainWindow.RandomID(), MainWindow.RandomAlligment());
            }
           
        }

        private bool CheckPosition(int shipSize, int id, bool isVertical)
        {
            return isVertical ? CheckIfShipAbleToDeployVerticaly(shipSize, id) : CheckIfShipAbleToDeployHorizontaly(shipSize, id);
        }

        private bool CheckIfShipAbleToDeployHorizontaly(int shipSize, int id)
        {
            if (_board.SquareList[id].IsOccupied == false && _board.SquareList[id].IsShip == false && _board.SquareList[id].Coord.XAxis + shipSize < 9)
            {
                Console.WriteLine("horizonal");
                return true;
            }
            return false;
        }
        private bool CheckIfShipAbleToDeployVerticaly(int shipSize, int id)
        {
            if (_board.SquareList[id].IsOccupied == false && _board.SquareList[id].IsShip == false && _board.SquareList[id].Coord.YAxis + shipSize < 9)
            {
                Console.WriteLine("vertical");
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