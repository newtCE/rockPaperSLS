using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public int boutScore;
        public string outPutGesture;

        public void SelectGesture(string gestureThrown)
        {
            
            switch (gestureThrown)
            {
                case "1":
                outPutGesture ="Rock";
                break;
                case "2":
                outPutGesture="Paper";
                break;
                case "3":
                outPutGesture="Scissors";
                break;
                case "4":
                outPutGesture="Lizard";
                break;
                case "5":
                outPutGesture="Spock";
                break;
            }
        }
    }
}
