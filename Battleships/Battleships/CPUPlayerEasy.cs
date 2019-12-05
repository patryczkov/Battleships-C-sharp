﻿using System;

namespace Battleships
{
    public class CPUPlayerEasy : Player
    {
        Random random = new Random();

        public CPUPlayerEasy(Board playerBoard, string playerName, bool isDefeated = false) : base(playerBoard, playerName, isDefeated)
        {
        }

        public override void Shoot(Board playerBoard)
        {
            int shootSquare = random.Next(0, 99);
            Square square = playerBoard.SquareList[shootSquare];
            square.isMiss = true;
            square.CheckTypeOfSquare();
            Console.WriteLine("CpuShoot");
            GameManager.cpuTurn = false;
            GameManager.playerTurn = true;
            MainWindow.TurnTextBlock.Text = "<== Turn";
        }

        public override void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
