using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class CPUPlayerEasy : Player
    {
        Random random = new Random();
        public CPUPlayerEasy(Board playerBoard, string playerName, bool isDefeated = false) : base(playerBoard, playerName, isDefeated)
        {
        }

        public override void Shoot()
        {
            int shootXY = random.Next(0, 99);
        }

        public override void WinGame()
        {
            throw new NotImplementedException();
        }
    }
}
