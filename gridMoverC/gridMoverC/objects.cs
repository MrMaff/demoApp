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
        public int health = 0;
        public int shield = 0;
        private int movesPerTurn = 1;
        private int attack = 2;
        public int xloc;
        public int yloc;

        public character(string name, int health, int xloc, int yloc)
        {
            this.health = health;
            this.xloc = xloc;
            this.yloc = yloc;
            this.walkable = false;
            this.name = name;
            if (name == "Hero")
            {
                this.icon = Properties.Resources.hero;
            }
            if (name == "Monster")
            {
                this.icon = Properties.Resources.monster;
            }
        }
    }

}
