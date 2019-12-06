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
        
        private List<int> shipList = new List<int>() { 0, 1, 2, 3 };
        public Board Board { get; set; }

        public Shipyard(Board board)
        {
            Board = board;
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
                        new AircraftCarrier(Board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 4)
                    {
                        new Destroyer(Board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 3)
                    {
                        new Cruiser(Board, id, isVertical);
                        shipList.Remove(0);
                    }

                    if (shipSize == 2)
                    {
                        new Submarine(Board, id, isVertical);
                        shipList.Remove(0);
                    }
                }
                else CreateShip(shipSize, MainWindow.RandomID(), MainWindow.RandomAlligment()); //how to avoid that?
            }

        }

        private bool CheckPosition(int shipSize, int id, bool isVertical)
        {
            return isVertical ? CheckIfShipAbleToDeployVerticaly(shipSize, id) : CheckIfShipAbleToDeployHorizontaly(shipSize, id);
        }

        private bool CheckIfShipAbleToDeployHorizontaly(int shipSize, int id) // to nie działa dalej :(
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < shipSize; i++)
            {
                if (Board.SquareList[id].Coord.XAxis + shipSize < 9 && Board.SquareList[id + i].IsShip == false && Board.SquareList[id + i].IsOccupied == false)
                {
                    
                    Console.WriteLine("truehori");
                    tempList.Add(i);
                    if (tempList.Count == shipSize) return true;

                }
            }
            Console.WriteLine("falsehori");
            return false;
        }
        private bool CheckIfShipAbleToDeployVerticaly(int shipSize, int id)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < shipSize; i++)
            {
                if (Board.SquareList[id].Coord.YAxis + shipSize < 9 && Board.SquareList[id + i].IsShip == false && Board.SquareList[id + i].IsOccupied == false)
                {
                    
                    Console.WriteLine("truever");
                    tempList.Add(i);
                    if (tempList.Count == shipSize) return true;
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