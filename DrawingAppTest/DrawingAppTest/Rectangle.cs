using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingAppTest
{
    class Rectangle
    {
        //Properties
        public float XOrigin { get; private set; }
        public float YOrigin { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }

        //Constructor
        public Rectangle(float xOrigin, float yOrigin, float width, float height)
        {
            this.XOrigin = xOrigin;
            this.YOrigin = yOrigin;
            this.Width = width;
            this.Height = height;
        }
    }
}
