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
        public string player1Throw;
        public string player2Throw;
        public Player player1;
        public Player player2;
        public string loseOutcome1 = "Paper";
        public string loseOutcome2 = "Spock";

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
            currentRound = 1;
            player1 = new HumanPlayer("1");
            if (player2Type == "human")
            {
                player2 = new HumanPlayer("2");
            }
            else
            {
                player2 = new CpuPlayer("2");
            }
            player1Throw = player1.SelectGesture(player1.GestureMethod());//1st throw
            player2Throw = player2.SelectGesture(player2.GestureMethod());
            CompareThrows(player1, player2);           
        }
        public void CheckGame()
        {
            if (currentRound > 3)
            {
                if (player1.boutScore < player2.boutScore)
                {
                    Console.WriteLine("Player 2 wins the game!!");
                    Console.ReadLine();
                    

                }
                else
                {
                    Console.WriteLine("Player 1 wins the game!!");
                    Console.ReadLine();
                }
            }
            else
            {
                player1Throw = player1.SelectGesture(player1.GestureMethod());//2nd throw onward
                player2Throw = player2.SelectGesture(player2.GestureMethod());
                CompareThrows(player1, player2);
            }
        }
        public void CompareThrows(Player player1, Player player2)
        {
            Console.WriteLine("Player 1 throws " + player1Throw + " !\nPlayer 2 throws " + player2Throw + " !");
            if (player1Throw == player2Throw)
            {
                Console.WriteLine("This round is a tie!!");
                CheckGame();
            }
            else
            {
                if (player1Throw == "Rock"){
                    loseOutcome1 = "Paper";
                    loseOutcome2 = "Spock";
                }
                else if (player1Throw == "Paper")
                {
                    loseOutcome1 = "Scissors";
                    loseOutcome2 = "Lizard";
                }
                else if (player1Throw == "Scissors")
                {
                    loseOutcome1 = "Rock";
                    loseOutcome2 = "Spock";
                }
                else if (player1Throw == "Lizard")
                {
                    loseOutcome1 = "Rock";
                    loseOutcome2 = "Scissors";
                }
                else //spock
                {
                    loseOutcome1 = "Paper";
                    loseOutcome2 = "Lizard";
                }
                if (player2Throw == loseOutcome1 || player2Throw == loseOutcome2)
                    {
                    Console.WriteLine("Player 2 Wins the round!");
                    player2.boutScore = player2.boutScore + 1;
                    currentRound = currentRound + 1;
                    CheckGame();
                }
                else
                {
                    Console.WriteLine("Player 1 Wins the round!");
                    player1.boutScore = player1.boutScore + 1;
                    currentRound = currentRound + 1;
                    CheckGame();
                }
                
            }

        }


    }
}
