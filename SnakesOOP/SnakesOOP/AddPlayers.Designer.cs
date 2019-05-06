namespace SnakesOOP
{
    partial class AddPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.cbx_colours = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.btn_AddNewPlayer = new System.Windows.Forms.Button();
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Location = new System.Drawing.Point(235, 41);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(354, 20);
            this.lbl_Instructions.TabIndex = 0;
            this.lbl_Instructions.Text = "Player 1 Enter your name and choose your colour";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(276, 115);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(350, 26);
            this.tbx_Name.TabIndex = 1;
            // 
            // cbx_colours
            // 
            this.cbx_colours.FormattingEnabled = true;
            this.cbx_colours.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Yellow",
            "Blue"});
            this.cbx_colours.Location = new System.Drawing.Point(276, 180);
            this.cbx_colours.Name = "cbx_colours";
            this.cbx_colours.Size = new System.Drawing.Size(350, 28);
            this.cbx_colours.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(168, 120);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.AutoSize = true;
            this.lbl_Colour.Location = new System.Drawing.Point(168, 188);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(55, 20);
            this.lbl_Colour.TabIndex = 4;
            this.lbl_Colour.Text = "Colour";
            // 
            // btn_AddNewPlayer
            // 
            this.btn_AddNewPlayer.Location = new System.Drawing.Point(316, 273);
            this.btn_AddNewPlayer.Name = "btn_AddNewPlayer";
            this.btn_AddNewPlayer.Size = new System.Drawing.Size(204, 56);
            this.btn_AddNewPlayer.TabIndex = 5;
            this.btn_AddNewPlayer.Text = "Add New Player";
            this.btn_AddNewPlayer.UseVisualStyleBackColor = true;
            this.btn_AddNewPlayer.Click += new System.EventHandler(this.btn_AddNewPlayer_Click);
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.Location = new System.Drawing.Point(550, 273);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(215, 55);
            this.btn_PlayGame.TabIndex = 6;
            this.btn_PlayGame.Text = "Play Game";
            this.btn_PlayGame.UseVisualStyleBackColor = true;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(65, 273);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(215, 55);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // AddPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 374);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_PlayGame);
            this.Controls.Add(this.btn_AddNewPlayer);
            this.Controls.Add(this.lbl_Colour);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cbx_colours);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_Instructions);
            this.Name = "AddPlayers";
            this.Text = "AddPlayers";
            this.Load += new System.EventHandler(this.AddPlayers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.ComboBox cbx_colours;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Button btn_AddNewPlayer;
        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.Button btn_Menu;
    }
}