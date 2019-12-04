using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public abstract void MarkShot();
        public abstract void WinGame();
       
      
    }
}
