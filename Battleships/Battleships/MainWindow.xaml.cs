using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Battleships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Square square;

        public MainWindow()
        {
            InitializeComponent();

            CreateBoard(firstPlayerBoard);
            CreateBoard(secondPlayerBoard);
        }

        private void CreateBoard(Canvas canvas)
        {
            int height = 10;
            int width = 10;
            int posGap = 50;

            // first player board
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    square = new Square(canvas, i * posGap, j * posGap, new Coord(i,j));
                }
            }
        }
    }
}
