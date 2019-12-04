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
        Board boardOne;
        Board boardTwo;

        public MainWindow()
        {
            InitializeComponent();

            boardOne = new Board(firstPlayerBoard);
            boardTwo = new Board(secondPlayerBoard);

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            cpu.Shoot(boardOne);
            cpu.Shoot(boardOne);
            cpu.Shoot(boardOne);
            cpu.Shoot(boardOne);

        }
    }
}
