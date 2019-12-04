using Battleships.model.ships;
using System;
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
        public MainWindow()
        {
            InitializeComponent();

            Board board = new Board(firstPlayerBoard);
            Board board2 = new Board(secondPlayerBoard);
            Shipyard shipyard = new Shipyard(board);
            int shipSize = 5;
            int id = 80;
            shipyard.CreateShip(shipSize, id, true);





        }


    }
}
