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
        public List<string> throwList = new List<string>() {"Empty Spot","Rock","Paper","Scissors","Lizard","Spock" };


        public virtual string GestureMethod(){
            return "this should never happen";
        }

        public string SelectGesture(string gestureThrown)
        {
            outPutGesture = throwList[Convert.ToInt32(gestureThrown)];
            return outPutGesture;
        }
    }
}
