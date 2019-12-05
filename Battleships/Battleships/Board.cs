using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Battleships
{
    public class Board
    {
        private Square _square;
        public List<Square> SquareList = new List<Square>();

        public Board(Canvas canvas, bool isPlayer)
        {
            int height = 10;
            int width = 10;
            int posGap = 50;

            // first player board
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    _square = new Square(canvas, i * posGap, j * posGap, i * j, isPlayer);
                    SquareList.Add(_square);
                }
            }
        }
    }
}
