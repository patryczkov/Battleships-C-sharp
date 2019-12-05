using Battleships.model.ships;
using System;
using System.Windows;
using System.Windows.Controls;
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
        public static TextBlock TurnTextBlock { get; set; }
        public MainWindow()
        {

            InitializeComponent();

            Board boardOne = new Board(firstPlayerBoard, true);
            Board boardTwo = new Board(secondPlayerBoard, false);

            Shipyard shipyard = new Shipyard(board);

            //for sake of debug, need to change it!
            int shipSize = 5;
            shipyard.CreateShip(shipSize, RandomID(), RandomAlligment());
            
            int shipSize2 = 4;
            shipyard.CreateShip(shipSize2, RandomID(), RandomAlligment());

            int shipSize3 = 3;
            shipyard.CreateShip(shipSize3, RandomID(), RandomAlligment());
            
            int shipSize4 = 2;
            shipyard.CreateShip(shipSize4, RandomID(), RandomAlligment());

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            TurnTextBlock = turnTextBlock;
            gameManager = new GameManager(boardOne, boardTwo, player, cpu);
        }

        public static bool RandomAlligment()
        {
            Random randomAlligment = new Random();
            int randomInt = randomAlligment.Next(0, 2);
            return randomInt == 0;
        }
        public static int RandomID()
        {
            Random random = new Random();
            return random.Next(9, 88);
        }
        /*
        public static int RandomID()
        {
            Random random = new Random();
            return random.Next(0, 99);
        }
        */
    }
}
