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

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            int listSize = boardOne.SquareList.Count;
            System.Console.WriteLine(listSize);

            boardOne.SquareList[0].isHit = true;
            boardTwo.SquareList[0].isHit = true;
        }
    }
}
