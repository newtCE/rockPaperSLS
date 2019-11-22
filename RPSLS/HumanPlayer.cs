using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human:Player
    {
        public string playerNumber;
        string playerInput;

        public Human(string playerNumber)
        {
            this.playerNumber = playerNumber;
        }
        public override string GestureMethod()
        {
            playerInput = "0";   
            while (playerInput != "1" && playerInput != "2" && playerInput != "3" && playerInput != "4" && playerInput != "5")
            {
                Console.WriteLine("Player " + playerNumber + " select your throw!\n1.)Rock\n2.)Paper\n3.)Scissors\n4.)Lizard\n5.)Spock");
                playerInput = Console.ReadLine();
            }
            return playerInput;

        }
    }
}
