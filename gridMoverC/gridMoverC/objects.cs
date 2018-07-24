using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gridMoverC
{
    class objects
    {
        protected string name = null;
        public Image icon = null;
        public bool walkable = true;

    }

    class character : objects
    {
        private int health = 0;
        private int shield = 0;
        private int movesPerTurn = 1;
    }

}
