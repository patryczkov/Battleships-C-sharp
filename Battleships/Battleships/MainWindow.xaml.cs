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

            Board boardOne = new Board(firstPlayerBoard);
            Board boardTwo = new Board(secondPlayerBoard);

            new HumanPlayer(boardOne, "Player", false);
            new CPUPlayerEasy(boardTwo, "Computer", false);
        }
    }
}
