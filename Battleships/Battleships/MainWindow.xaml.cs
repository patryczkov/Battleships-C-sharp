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

        private readonly int AircraftCarrierSize = 5;
        private readonly int DestroyerSize = 4;
        private readonly int CruiserSize = 3;
        private readonly int SubmarineSize = 2;
        public MainWindow()
        {

            InitializeComponent();

            Board boardOne = new Board(firstPlayerBoard, true);
            Board boardTwo = new Board(secondPlayerBoard, false);

            Shipyard shipyardPlayer = new Shipyard(boardOne);
            Shipyard shipyardCpu = new Shipyard(boardTwo);

            //for sake of debug, need to change it!

            shipyardPlayer.CreateShip(AircraftCarrierSize, RandomID(), RandomAlligment());
            shipyardPlayer.CreateShip(DestroyerSize, RandomID(), RandomAlligment());
            shipyardPlayer.CreateShip(CruiserSize, RandomID(), RandomAlligment());
            shipyardPlayer.CreateShip(SubmarineSize, RandomID(), RandomAlligment());

            shipyardCpu.CreateShip(AircraftCarrierSize, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(DestroyerSize, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(CruiserSize, RandomID(), RandomAlligment());
            shipyardCpu.CreateShip(SubmarineSize, RandomID(), RandomAlligment());

            HumanPlayer player = new HumanPlayer(boardOne, "Player", false);
            CPUPlayerEasy cpu = new CPUPlayerEasy(boardTwo, "Computer", false);

            TurnTextBlock = turnTextBlock;
            gameManager = new GameManager(gameCanvas, boardOne, boardTwo, player, cpu);
        }

        public static bool RandomAlligment()
        {
            Random randomAlligment = new Random();
            int randomInt = randomAlligment.Next(0, 2);
            return randomInt == 0;
        }
       /*ublic static int RandomID()
        {
            Random random = new Random();
            return random.Next(9, 88);
        }
        */
        public static int RandomID()
        {
            Random random = new Random();
            return random.Next(0, 99);
        }
        
    }
}
