﻿using System;
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
    public partial class AddPlayers : Form
    {
        Queue<Player> players = new Queue<Player>();
        Form topForm;

        public AddPlayers(Form topForm)
        {
            InitializeComponent();
            players.Clear();
            this.topForm = topForm;
        }

        private void AddPlayers_Load(object sender, EventArgs e)
        {
            btn_PlayGame.Enabled = false;
            updateInstructions();
            cbx_colours.SelectedIndex = 0;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            playGame();
        }

        private void btn_AddNewPlayer_Click(object sender, EventArgs e)
        {
            players.Enqueue(new Player(tbx_Name.Text, cbx_colours.Text));
            if (players.Count<4)
            {
                cbx_colours.Items.Remove(cbx_colours.SelectedItem);
                tbx_Name.Text = "";
                cbx_colours.SelectedIndex = 0;
                updateInstructions();
                CheckReadyToPlay();
            }
            else { playGame(); }
        }

        private void updateInstructions()
        {
            lbl_Instructions.Text = $"Player {(players.Count + 1).ToString()} Enter your name and choose your colour " ;
        }

        private void CheckReadyToPlay()
        {
            if (players.Count >= 2)
            {
                btn_PlayGame.Enabled = true;
            }
            if (players.Count == 4)
            {
                btn_AddNewPlayer.Enabled = false;
            }
        }

        private void playGame()
        {
            GameWindow game = new GameWindow(players, topForm);
            game.Show();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
