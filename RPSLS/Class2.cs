using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string playerNumber;
        public int boutScore;

        public string SelectGesture(string gestureThrown)
        {
            public string outPutGesture;
            switch (gestureThrown)
            {
                case "1":
                outPutGesture="Rock";
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
