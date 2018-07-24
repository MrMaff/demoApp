using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace gridMoverC
{
    class BoardImg 
    {
        public Bitmap layout = null;
        private tile[,] grid;


        public BoardImg(int width, int height, tile[,] grid)
        {
            layout = new Bitmap(width, height);
            this.grid = grid;
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
                        g.DrawImage(grid[Row, Col].icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                
                        if (grid[Row,Col].inspace != null)
                        {
                            g.DrawImage(grid[Row, Col].inspace.icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        }
                       // g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);

                    }
                }
                
            }
        }

        public void drawgrid(Point hover, string colour)
        {
            int boxwidth = (layout.Width / 10) - 1;
            SolidBrush highlight = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
            if (colour == "R")
            {
                highlight = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
            }
            if (colour == "G")
            {
                highlight = new SolidBrush(Color.FromArgb(128, 0, 255, 0));
            }
            using (Graphics g = Graphics.FromImage(layout))
            {
                for (int Row = 0; Row < 5; Row++)
                {
                    for (int Col = 0; Col < 10; Col++)
                    {
                        g.DrawImage(grid[Row, Col].icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);

                        if (grid[Row, Col].inspace != null)
                        {
                            g.DrawImage(grid[Row, Col].inspace.icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        }
                        //g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        
                    }
                }
                int mouseCol = hover.X / (layout.Width/10);
                int mouseRow = hover.Y / (layout.Height/5);
                if (grid[mouseRow,mouseCol].walkAble == true)
                {

                    g.FillRectangle(highlight, mouseCol * boxwidth, mouseRow * boxwidth, boxwidth, boxwidth);
                }
            }
        }
    }
}
