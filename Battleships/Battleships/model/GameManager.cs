using Battleships.model;
using System;
using System.Windows.Controls;

namespace Battleships
{
    public class GameManager
    {
        public static bool playerTurn { get; set; }
        public static bool cpuTurn { get; set; }
        public static int hitCounterPlayer { get; set; }
        public static int hitCounterCpu { get; set; }

        private Canvas _canvas;
        private Board _boardOne;
        private Board _boardTwo;
        private HumanPlayer _player;
        private CPUPlayerEasy _cpu;

        public GameManager(Canvas canvas, Board boardOne, Board boardTwo, HumanPlayer player, CPUPlayerEasy cpu)
        {
            this._canvas = canvas;
            this._boardOne = boardOne;
            this._boardTwo = boardTwo;
            this._player = player;
            this._cpu = cpu;

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

        private void Win()
        {
            new Win(_canvas);
        }

        public void HandleTurns()
        {
            if (hitCounterPlayer >= 14 || hitCounterCpu >= 14)
                Win();

            if (!playerTurn)
                _cpu.Shoot(_boardOne);
        }

        private int CoinRoll()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
