using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Cpu : Player
    {
        public Cpu(string playerNumber)
        {

        }
        public override string GestureMethod()
        {
            // Random rng = new Random();
            //rng.Next(1, 5);
            Random rng = new Random();
            int rngNum = rng.Next(1, 5);
            string choiceNumber = Convert.ToString(rngNum);
            return choiceNumber;
        }
    }
}
