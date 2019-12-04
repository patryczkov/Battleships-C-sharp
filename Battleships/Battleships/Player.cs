using System.Windows.Shapes;

namespace Battleships
{
   public abstract class Player
    {
        public virtual Board PlayerBoard { get; set; }
        public virtual string PlayerName { get; set; }
        public virtual bool IsDefeated { get; set; }

        public Player(Board playerBoard, string playerName, bool isDefeated =false)
        {
            PlayerBoard = playerBoard;
            PlayerName = playerName;
            IsDefeated = isDefeated;
        }

        public abstract void Shoot(Board playerBoard);

        public abstract void WinGame();
    }
}
