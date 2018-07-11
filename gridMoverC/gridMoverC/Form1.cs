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
            BoardImg bmp = new BoardImg(pbx_board.Width, pbx_board.Height);
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
        }
    }
}
