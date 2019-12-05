using System;

namespace Battleships
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(Board playerBoard, string playerName, bool isDefeated = false) : base(playerBoard, playerName, isDefeated)
        {

        }

        public override void Shoot(Board playerBoard)
        {

        }

        public override void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
