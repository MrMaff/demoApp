using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gridMoverC
{
    public partial class frm_board : Form
    {
        BoardImg bmp;
        int lastMouseRow = -1;
        int lastMouseCol = -1;
        tile[,] grid = new tile[5, 10];
        character player;

        public frm_board()
        {
            InitializeComponent();
        }

        private void frm_board_Load(object sender, EventArgs e)
        {
            loadMap();
            player = new character("Hero", 10, 2, 0);
            grid[2, 0].inspace = player;
            bmp = new BoardImg(pbx_board.Width, pbx_board.Height, grid);
            DrawBoard();
        }

        private void DrawBoard()
        {
            pbx_board.Height = 300;
            pbx_board.Width = 600;
            pbx_board.Location = new Point(100, 25);
            pbx_board.Image = bmp.layout;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        private void pbx_board_MouseHover(object sender, MouseEventArgs e)
        {
            Point mHover = e.Location;
            lbl_health.Text = mHover.X.ToString();
            lbl_shield.Text = mHover.Y.ToString();
            int mouseRow = mHover.X / (600 / 10);
            int mouseCol = mHover.Y / (300 / 5);
            if (mouseCol != lastMouseCol || mouseRow != lastMouseRow)
            {
                bmp.drawgrid(mHover);
                pbx_board.Image = bmp.layout;
            }
            
        }

        private void pbx_board_MouseLeave(object sender, EventArgs e)
        {
            bmp.drawgrid();
            pbx_board.Image = bmp.layout;
            lastMouseRow = -1;
            lastMouseCol = -1;
        }
        
    
        private void loadMap()
        {
            using (BinaryReader lvlMap = new BinaryReader(File.Open(@"C:\Users\SNHSmlon\Documents\GitFolder\gridMoverC\gridMoverC\Resources\demoLvl.dat", FileMode.Open)))
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
            //temp item load
            //grid[0,5].inspace = new objects();
            //grid[0, 5].inspace.icon = Properties.Resources.stimpack;
            //grid[0, 5].inspace.walkable = true;
            //grid[4, 7].inspace = new objects();
            //grid[4, 7].inspace.icon = Properties.Resources.medpack;
            //grid[4, 7].inspace.walkable = true;


        }
    }
}
