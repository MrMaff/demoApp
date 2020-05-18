using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shaker
{

    

    public partial class Form1 : Form
    {

        Roller gameRoller = new Roller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             pbx_Shaker.Image = new BoardDrawer().DrawBoard();
        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
            gameRoller.RollDice();
            if (gameRoller.IsADouble())
            {
                pbx_Shaker.Image = new BoardDrawer().DrawBoard(gameRoller.die1.Face, gameRoller.die2.Face, gameRoller.die3.Face);
            }
            else
            {
                pbx_Shaker.Image = new BoardDrawer().DrawBoard(gameRoller.die1.Face, gameRoller.die2.Face);
            }
        }
    }
}
