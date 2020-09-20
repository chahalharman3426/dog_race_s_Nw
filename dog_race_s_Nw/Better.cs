using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog_race_s_Nw
{
   public class Better
    {
        //check the details of the player if he participate then 
        public int resultDeclaration(String Details,int winner,int budget) {
            String[] record = Details.Split(' ');
            int dog = Convert.ToInt32(record[5]);
            if (dog == winner)
            {
                return (budget + (Convert.ToInt32(record[7])));
            }
            else {
                return (budget - (Convert.ToInt32(record[7])));
            }

        }

    }
}
