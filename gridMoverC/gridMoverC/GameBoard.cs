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
        private tile[,] grid = new tile[5, 10];
        public BoardImg(int width, int height)
        {
            layout = new Bitmap(width, height);
            loadMap();
            drawgrid();
        }

        private void loadMap()
        {using (MemoryStream levelDataStream = new MemoryStream(Properties.Resources.demoLvl))
            {
                using (BinaryReader lvlMap = new BinaryReader(levelDataStream))
                {
                    for (int Col = 0; Col < 10; Col++)
                    {
                        for (int Row = 0; Row < 5; Row++)
                        {
                            grid[Row, Col] = new tile();
                            grid[Row, Col].mapTile = lvlMap.ReadChar();
                        }
                    }
                    for (int Col = 0; Col < 10; Col++)
                    {
                        for (int Row = 0; Row < 5; Row++)
                        {
                            char tempObj = lvlMap.ReadChar();
                            if (tempObj == 'M')
                            {
                                grid[Row, Col].inspace = new objects();
                                grid[Row, Col].inspace.icon = Properties.Resources.medpack;
                                grid[Row, Col].inspace.walkable = true;
                            }
                            if (tempObj == 'S')
                            {
                                grid[Row, Col].inspace = new objects();
                                grid[Row, Col].inspace.icon = Properties.Resources.stimpack;
                                grid[Row, Col].inspace.walkable = true;
                            }
                        }
                    }
                }
            }
            //temp item load
            //grid[0,5].inspace = new objects();
            //grid[0, 5].inspace.icon = Properties.Resources.stimpack;
            //grid[0, 5].inspace.walkable = true;
            //grid[4, 7].inspace = new objects();
            //grid[4, 7].inspace.icon = Properties.Resources.medpack;
            //grid[4, 7].inspace.walkable = true;


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
                        switch (grid[Row,Col].mapTile)
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
                        if (grid[Row,Col].inspace != null)
                        {
                            g.DrawImage(grid[Row, Col].inspace.icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
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
                        switch (grid[Row, Col].mapTile)
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
                        if (grid[Row, Col].inspace != null)
                        {
                            g.DrawImage(grid[Row, Col].inspace.icon, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        }
                        g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                        
                    }
                }
                int mouseCol = hover.X / (layout.Width/10);
                int mouseRow = hover.Y / (layout.Height/5);
                if (grid[mouseRow,mouseCol].walkAble == true)
                {

                    g.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 0, 0)), mouseCol * boxwidth, mouseRow * boxwidth, boxwidth, boxwidth);
                }
            }
        }
    }
}
