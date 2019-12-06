using System;
﻿using System.Collections.Generic;
using System.Windows.Controls;

namespace Battleships
{
    public class Board
    {
        private Square _square;
        private int _squareId;
        private List<Square> _squareList = new List<Square>();
        public Canvas canvas;

        public Board(Canvas canvas, bool isPlayer)
        {
            int height = 10;
            int width = 10;
            int posGap = 50;

            for (int vertical = 0; vertical < width; vertical++)
            {
                for (int horizontal = 0; horizontal < height; horizontal++)
                {
                    _square = new Square(canvas, horizontal * posGap, vertical * posGap, new Coord(horizontal, vertical),
                        _squareId = ConcatenateXAxisNumberWithYAxisNumber(vertical, horizontal), isPlayer); //clean it!
                    SquareList.Add(_square);
                }
            }
        }

        private int ConcatenateXAxisNumberWithYAxisNumber(int vertical, int horizontal)
        {
            return Convert.ToInt32(string.Format("{0}{1}", vertical, horizontal));
        }
        public List<Square> SquareList { get => _squareList; set => _squareList = value; }
    }
}
