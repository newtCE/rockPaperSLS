using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameLoop
    {
        public int currentRound;
        public string gameMode;
        public string player2Type;

        public void SelectGameMode()
        {
            Console.WriteLine("Please select the game mode you'd like to play:\n1.)Play Against Computer\n2.)Play Against A Human\n3.)Quit Game");
            gameMode = (Console.ReadLine());
            if (gameMode == "1" || gameMode == "2" || gameMode == "3")
            {
                switch (gameMode)
                {
                        case "1":
                        player2Type = "cpu";
                        CreateBout(player2Type);
                        break;

                        case "2":
                        player2Type = "human";
                        CreateBout(player2Type);
                        break;
                }

            }
            else
            {
                Console.WriteLine("Not a Valid option, please type either 1, 2 or 3...");
                Console.ReadLine();
                SelectGameMode();
            }
        }
        public void CreateBout(string player2Type)
        {
            Player player1 = new Player("human");
            Player player2 = new Player(player2Type);
        }


    }
}
