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

            playerTurn = CoinRoll().Equals(0);
        }

        public void HandleTurns()
        {
            if (!playerTurn)
                cpu.Shoot(boardOne);
        }

        private int CoinRoll()
        {
            Random random = new Random();
            return random.Next(0, 1);
        }
    }
}
