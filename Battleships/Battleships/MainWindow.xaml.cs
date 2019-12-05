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
            //for sake of debug, need to change it!
            int shipSize = 5;
            int id = 0;
            shipyard.CreateShip(shipSize, id, true);

            int shipSize2 = 4;
            int id2 = 74;
            shipyard.CreateShip(shipSize2, id2, false);

            int shipSize3 = 3;
            int id3 = 13;
            shipyard.CreateShip(shipSize3, id3, true);
            
            int shipSize4 = 2;
            int id4 = 80;
            shipyard.CreateShip(shipSize4, id4, false);





        }


    }
}
