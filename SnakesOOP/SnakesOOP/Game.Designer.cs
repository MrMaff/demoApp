namespace SnakesOOP
{
    partial class Game
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
            this.pbx_Board = new System.Windows.Forms.PictureBox();
            this.pbx_Dice = new System.Windows.Forms.PictureBox();
            this.tbx_PlayerName = new System.Windows.Forms.Label();
            this.btn_RollDice = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Board
            // 
            this.pbx_Board.Location = new System.Drawing.Point(12, 12);
            this.pbx_Board.Name = "pbx_Board";
            this.pbx_Board.Size = new System.Drawing.Size(600, 600);
            this.pbx_Board.TabIndex = 0;
            this.pbx_Board.TabStop = false;
            // 
            // pbx_Dice
            // 
            this.pbx_Dice.Location = new System.Drawing.Point(669, 80);
            this.pbx_Dice.Name = "pbx_Dice";
            this.pbx_Dice.Size = new System.Drawing.Size(300, 300);
            this.pbx_Dice.TabIndex = 1;
            this.pbx_Dice.TabStop = false;
            // 
            // tbx_PlayerName
            // 
            this.tbx_PlayerName.AutoSize = true;
            this.tbx_PlayerName.Location = new System.Drawing.Point(667, 13);
            this.tbx_PlayerName.Name = "tbx_PlayerName";
            this.tbx_PlayerName.Size = new System.Drawing.Size(51, 20);
            this.tbx_PlayerName.TabIndex = 2;
            this.tbx_PlayerName.Text = "label1";
            // 
            // btn_RollDice
            // 
            this.btn_RollDice.Location = new System.Drawing.Point(673, 402);
            this.btn_RollDice.Name = "btn_RollDice";
            this.btn_RollDice.Size = new System.Drawing.Size(295, 78);
            this.btn_RollDice.TabIndex = 3;
            this.btn_RollDice.Text = "Roll Dice";
            this.btn_RollDice.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(675, 534);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(293, 77);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next Player";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 624);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_RollDice);
            this.Controls.Add(this.tbx_PlayerName);
            this.Controls.Add(this.pbx_Dice);
            this.Controls.Add(this.pbx_Board);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Board;
        private System.Windows.Forms.PictureBox pbx_Dice;
        private System.Windows.Forms.Label tbx_PlayerName;
        private System.Windows.Forms.Button btn_RollDice;
        private System.Windows.Forms.Button btn_Next;
    }
}