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
        private Image floor = Properties.Resources.floor;
        private Image barrier = Properties.Resources.barrier;
        private Image enter = Properties.Resources.enter;
        private Image exit = Properties.Resources.exit;
        private char[,] grid = new char[5, 10];
        public BoardImg(int width, int height)
        {
            layout = new Bitmap(width, height);
            loadMap();
            drawgrid();
        }

        private void loadMap()
        {
            using (BinaryReader lvlMap = new BinaryReader(File.Open(@"C:\Users\SNHSmlon\Documents\GitFolder\gridMoverC\gridMoverC\Resources\demoLvl.dat", FileMode.Open)))
            {
                for (int Col = 0; Col < 10; Col++)
                {
                    for (int Row = 0; Row < 5; Row++)
                    {
                        grid[Row, Col] = lvlMap.ReadChar();
                    }
                }
            }
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
                        switch (grid[Row,Col])
                        {
                            case 'B':
                                g.DrawImage(barrier, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            case 'X':
                                g.DrawImage(exit, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            case 'E':
                                g.DrawImage(enter, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            default:
                                g.DrawImage(floor, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                        }

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
                        switch (grid[Row, Col])
                        {
                            case 'B':
                                g.DrawImage(barrier, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            case 'X':
                                g.DrawImage(exit, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            case 'E':
                                g.DrawImage(enter, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                            default:
                                g.DrawImage(floor, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                                break;
                        }
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
