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
        private List<int> shipList = new List<int>() { 0, 1, 2, 3 };

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
            List<int> xdList = new List<int>();
            for (int i = 0; i < shipSize; i++)
            {
                if (_board.SquareList[id].Coord.XAxis + shipSize < 9 && _board.SquareList[id + i].IsOccupied == false && _board.SquareList[id + i].IsShip == false)
                {
                    Console.WriteLine("horizonal");
                    Console.WriteLine("truehori");
                    xdList.Add(i);
                    if (xdList.Count == shipSize) return true;

                }
            }
            Console.WriteLine("falsehori");
            return false;
        }
        private bool CheckIfShipAbleToDeployVerticaly(int shipSize, int id)
        {
            List<int> xdList = new List<int>();
            for (int i = 0; i < shipSize; i++)
            {
                if (_board.SquareList[id].Coord.YAxis + shipSize < 9 && _board.SquareList[id].IsOccupied == false && _board.SquareList[id].IsShip == false)
                {
                    Console.WriteLine("vertical");
                    Console.WriteLine("truever");
                    xdList.Add(i);
                    if (xdList.Count == shipSize) return true;
                }

            }
            Console.WriteLine("falsever");
            return false;
        }
        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}