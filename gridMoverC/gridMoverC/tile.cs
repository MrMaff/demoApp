using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridMoverC
{
    class tile
    {
        public char mapTile;
        public objects inspace = null;
        public Boolean walkAble
        {
            get
            {
                if ((inspace == null || inspace.walkable == true) && mapTile != 'B')
                {
                    return true;
                }
                else return false;
            }
            
        }


    }
}
