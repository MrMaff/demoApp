using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridMoverC
{
    public partial class frm_board : Form
    {
        public frm_board()
        {
            InitializeComponent();
        }

        private void frm_board_Load(object sender, EventArgs e)
        {
            
            DrawBoard();
        }

        private void DrawBoard()
        {
            pbx_board.Height = 300;
            pbx_board.Width = 600;
            pbx_board.Location = new Point(100, 25);
            Bitmap bmp = new Bitmap(pbx_board.Width, pbx_board.Height);
            int boxwidth = (pbx_board.Width / 10)-1;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int Row = 0; Row < 5; Row++ )
                {
                    for (int Col  = 0; Col < 10; Col++)
                    {
                        g.DrawRectangle(Pens.Black, Col * boxwidth, Row * boxwidth, boxwidth, boxwidth);
                    }
                }
                pbx_board.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void pbx_board_MouseHover(object sender, MouseEventArgs e)
        {
            Point mHover = Cursor.Position;
            lbl_health.Text = mHover.X.ToString();
            lbl_shield.Text = mHover.Y.ToString();
        }
    }
}
