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
            // Random rng = new Random();
            //rng.Next(1, 5);
            int rng = 2;
            string choiceNumber = Convert.ToString(rng);
            return choiceNumber;
        }
    }
}
