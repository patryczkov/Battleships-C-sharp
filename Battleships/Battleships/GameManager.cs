using System;

namespace Battleships
{
    public class GameManager
    {
        public static bool playerTurn { get; set; }
        public static bool cpuTurn { get; set; }

        Board boardOne;
        Board boardTwo;
        HumanPlayer player;
        CPUPlayerEasy cpu;

        public GameManager(Board boardOne, Board boardTwo, HumanPlayer player, CPUPlayerEasy cpu)
        {
            this.boardOne = boardOne;
            this.boardTwo = boardTwo;
            this.player = player;
            this.cpu = cpu;

            if(CoinRoll().Equals(0))
            {
                playerTurn = true;
                MainWindow.TurnTextBlock.Text = "<== Turn";
            } else
            {
                playerTurn = false;
                MainWindow.TurnTextBlock.Text = "Turn ==>";
            }
            HandleTurns();
        }

        public void HandleTurns()
        {
            if (!playerTurn)
                cpu.Shoot(boardOne);
        }

        private int CoinRoll()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
