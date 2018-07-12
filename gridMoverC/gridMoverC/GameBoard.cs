using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gridMoverC
{
    class BoardImg 
    {
        public Bitmap layout = null;
        private Image floor = Image.FromFile("//ran/qe2root/QE2StaffUser/snhsMLON/Documents/gitHubApps/gridMoverC/gridMoverC/Resources/floor.png");
        public BoardImg(int width, int height)
        {
            layout = new Bitmap(width, height);
            drawgrid();
        }

        public void drawgrid()
        {
            
            int boxwidth = (layout.Width / 10) - 1;
            using (Graphics g = Graphics.FromImage(layout))
            {
                for (int Row = 0; Row < 5; Row++)
                {
                    for (int Col = 0; Col < 10; Col++)
                    {
                        g.DrawImage(floor, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);

                    }
                }
                
            }
        }

        public void drawgrid(Point hover)
        {
            int boxwidth = (layout.Width / 10) - 1;
            using (Graphics g = Graphics.FromImage(layout))
            {
                for (int Row = 0; Row < 5; Row++)
                {
                    for (int Col = 0; Col < 10; Col++)
                    {
                        g.DrawImage(floor, Col * boxwidth, Row * boxwidth, boxwidth,boxwidth);
                        g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        
                    }
                }
                int mouseRow = hover.X / (layout.Width/10);
                int mouseCol = hover.Y / (layout.Height/5);

                g.FillRectangle(Brushes.Red, mouseRow * boxwidth, mouseCol * boxwidth, boxwidth, boxwidth);
            }
        }
    }
}
