using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Battleships
{
    public class Board
    {
        private Square _square;
        private List<Square> _squareList = new List<Square>();
        public Board(Canvas canvas)
        {
            int height = 10;
            int width = 10;
            int posGap = 50;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    _square = new Square(canvas, i * posGap, j * posGap, new Coord(i, j));
                    SquareList.Add(_square);
                    
                }
            }
        }

        public List<Square> SquareList { get => _squareList; set => _squareList = value; }
    }
}
