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
        private bool turnOver = false;

        public Game()
        {
            InitializeComponent();
            
        }

        public Game(Queue<Player> players)
            :this()
        {
            this.players = players;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lbl_PlayerName.Text = players.Peek().Name;
            btn_RollDice.Enabled = true;
            btn_Next.Enabled = false;
        }

        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DieShaker.GetDiceRoll().ToString());
            btn_RollDice.Enabled = false;
            btn_Next.Enabled = true;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Player tempPlayer = players.Dequeue();
            players.Enqueue(tempPlayer);
            lbl_PlayerName.Text = players.Peek().Name;
            btn_RollDice.Enabled = true;
            btn_Next.Enabled = false;
           
        }
    }


}
