using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesOOP
{
    public partial class Game : Form
    {
        private Queue<Player> players;
        private DiceRoller DieShaker = new DiceRoller(true);

        public Game()
        {
            InitializeComponent();
            
        }

        public Game(Queue<Player> players)
            :this()
        {
            this.players = players;
        }

        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DieShaker.GetDiceRoll().ToString());
        }
    }


}
