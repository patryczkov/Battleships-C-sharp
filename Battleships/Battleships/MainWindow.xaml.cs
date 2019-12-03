using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
