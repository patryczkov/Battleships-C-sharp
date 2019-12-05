using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Battleships
{
    public class Board
    {
        private Square _square;
        private int _squareId;
        private List<Square> _squareList = new List<Square>();
        public Board(Canvas canvas)
        {
            int height = 10;
            int width = 10;
            int posGap = 50;


            for (int vertical = 0; vertical < width; vertical++)
            {
                for (int horizontal = 0; horizontal < height; horizontal++)
                {
                    _square = new Square(canvas, horizontal * posGap, vertical * posGap, new Coord(horizontal, vertical),
                        _squareId = Convert.ToInt32(string.Format("{0}{1}", vertical, horizontal))); //clean it!
                    SquareList.Add(_square);


                }
            }
            
        }

        public List<Square> SquareList { get => _squareList; set => _squareList = value; }
        


    }
}
