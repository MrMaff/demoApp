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
    public partial class GameWindow : Form
    {
        private Queue<Player> players;
        private DiceRoller DieShaker = new DiceRoller(true);
        private Board GameBoard = new Board();
        private bool turnOver = false;
        private Form topForm;

        public GameWindow()
        {
            InitializeComponent();
            
        }

        public GameWindow(Queue<Player> players, Form topForm)
            :this()
        {
            this.players = players;
            this.topForm = topForm;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lbl_PlayerName.Text = players.Peek().Name;
            btn_RollDice.Enabled = true;
            btn_Next.Enabled = false;
        }

        private void btn_RollDice_Click(object sender, EventArgs e)
        {
            
            btn_RollDice.Enabled = false;
            PlayerTurn(DieShaker.GetDiceRoll());
            btn_Next.Enabled = true;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (players.Peek().Location != null)
            {
                lbl_PlayerName.Text = players.Peek().Name + " " + players.Peek().Location.Number;
            }
            else lbl_PlayerName.Text = players.Peek().Name;

            btn_RollDice.Enabled = true;
            btn_Next.Enabled = false;
           
        }

        private void PlayerTurn(int dieRoll)
        {
            Player currentPlayer = players.Dequeue();
            MessageBox.Show(dieRoll.ToString());
            currentPlayer.Move(dieRoll, GameBoard);
            currentPlayer.ApplyActions(GameBoard);
            if (currentPlayer.Winner)
            {
                MessageBox.Show(currentPlayer.Name + "Wins!");
                topForm.Show();
                this.Close();
            }
            players.Enqueue(currentPlayer);
        }
    }


}
