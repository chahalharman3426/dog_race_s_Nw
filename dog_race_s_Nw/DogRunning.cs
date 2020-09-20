using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog_race_s_Nw
{
    public class DogRunning
    {
        Random rd = new Random();

        //set the running point of the dog 
        public int run() {
            return rd.Next(1, 30);
        }

        //set the finishpoint of the game
        public int lastPoint() {
                return 710;
        }
    }
}
