using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class CPUPlayerEasy : Player
    {
        public CPUPlayerEasy(Board playerBoard, string playerName, bool isDefeated = false) : base(playerBoard, playerName, isDefeated)
        {
        }

        public override void MarkShot()
        {
            throw new NotImplementedException();
        }

        public override void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
