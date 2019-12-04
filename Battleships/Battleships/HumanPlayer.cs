using System;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(Board playerBoard, string playerName, bool isDefeated = false) : base(playerBoard, playerName, isDefeated)
        {
        }

        public override void Shoot()
        {
            throw new NotImplementedException();
        }

        public override void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
