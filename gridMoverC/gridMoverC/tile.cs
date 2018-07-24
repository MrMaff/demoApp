using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gridMoverC
{
    class tile
    {
        public char mapTile;
        
        public objects inspace = null;

        public Image icon
        {
            get
            {
                switch (mapTile)
                {
                    case 'B':
                        return Properties.Resources.barrier;
                    case 'X':
                        return Properties.Resources.exit;
                    case 'E':
                        return Properties.Resources.enter;
                    default:
                        return Properties.Resources.floor;
                }
            }
        }
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
