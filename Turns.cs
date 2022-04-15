using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsGame
{
    public class Turns
    {
        private int[] darts = new int[3];

        public int[] Darts
        {
            get { return darts; }
            set { darts = value; }
        }


        //Constructor
        public Turns(int[] darts)
        {
            Darts = darts;
        }

        public Turns()
        {

        }
    }
}
