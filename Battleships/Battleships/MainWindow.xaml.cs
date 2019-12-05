using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Battleships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static GameManager gameManager;
        public MainWindow()
        {
            InitializeComponent();

            Board boardOne = new Board(firstPlayerBoard, true);
            Board boardTwo = new Board(secondPlayerBoard, false);

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            gameManager = new GameManager(boardOne, boardTwo, player, cpu);
        }
    }
}
