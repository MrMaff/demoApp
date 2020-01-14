using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingAppTest
{
    class EquilateralTriangle
    {
        //Properties
        public float XOrigin { get; private set; }
        public float YOrigin { get; private set; }
        public float SideLength { get; private set; }

        //Constructor
        public EquilateralTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            this.XOrigin = xOrigin;
            this.YOrigin = yOrigin;
            this.SideLength = sideLength;
           
        }
    }
}
