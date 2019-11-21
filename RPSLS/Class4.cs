using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CpuPlayer : Player
    {
        public CpuPlayer(string playerNumber)
        {

        }
        public override string GestureMethod()
        {
            string choiceNumber = "1";
            return choiceNumber;
        }
    }
}
