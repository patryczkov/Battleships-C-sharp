using System;
using System.Windows;
using System.Windows.Controls;

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

            Shipyard shipyardPlayer = new Shipyard(boardOne);
            Shipyard shipyardCpu = new Shipyard(boardTwo);

            //for sake of debug, need to change it!
            int shipSize = 5;
            shipyardPlayer.CreateShip(shipSize, RandomID(), RandomAlligment());
            int shipSize2 = 4;
            shipyardPlayer.CreateShip(shipSize2, RandomID(), RandomAlligment());
            int shipSize3 = 3;
            shipyardPlayer.CreateShip(shipSize3, RandomID(), RandomAlligment());
            int shipSize4 = 2;
            shipyardPlayer.CreateShip(shipSize4, RandomID(), RandomAlligment());            
            
            shipyardCpu.CreateShip(shipSize, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(shipSize2, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(shipSize3, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(shipSize4, RandomID(), RandomAlligment());

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            TurnTextBlock = turnTextBlock;
            gameManager = new GameManager(gameCanvas ,boardOne, boardTwo, player, cpu);
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
