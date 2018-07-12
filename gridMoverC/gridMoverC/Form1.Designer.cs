namespace gridMoverC
{
    partial class frm_board
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
            this.pbx_board = new System.Windows.Forms.PictureBox();
            this.pbx_moves = new System.Windows.Forms.PictureBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.btn_Move = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_Snipe = new System.Windows.Forms.Button();
            this.btn_Shield = new System.Windows.Forms.Button();
            this.lbl_health = new System.Windows.Forms.Label();
            this.lbl_shield = new System.Windows.Forms.Label();
            this.lbl_kills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_moves)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_board
            // 
            this.pbx_board.Location = new System.Drawing.Point(100, 25);
            this.pbx_board.Name = "pbx_board";
            this.pbx_board.Size = new System.Drawing.Size(600, 300);
            this.pbx_board.TabIndex = 0;
            this.pbx_board.TabStop = false;
            this.pbx_board.MouseLeave += new System.EventHandler(this.pbx_board_MouseLeave);
            this.pbx_board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_board_MouseHover);
            // 
            // pbx_moves
            // 
            this.pbx_moves.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbx_moves.Location = new System.Drawing.Point(25, 175);
            this.pbx_moves.Name = "pbx_moves";
            this.pbx_moves.Size = new System.Drawing.Size(50, 150);
            this.pbx_moves.TabIndex = 1;
            this.pbx_moves.TabStop = false;
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(25, 350);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(50, 50);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "GO!";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(100, 350);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(50, 49);
            this.btn_Move.TabIndex = 3;
            this.btn_Move.Text = "Move";
            this.btn_Move.UseVisualStyleBackColor = true;
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.Location = new System.Drawing.Point(165, 350);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(50, 49);
            this.btn_Shoot.TabIndex = 4;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = true;
            // 
            // btn_Snipe
            // 
            this.btn_Snipe.Location = new System.Drawing.Point(230, 350);
            this.btn_Snipe.Name = "btn_Snipe";
            this.btn_Snipe.Size = new System.Drawing.Size(50, 49);
            this.btn_Snipe.TabIndex = 5;
            this.btn_Snipe.Text = "Snipe";
            this.btn_Snipe.UseVisualStyleBackColor = true;
            // 
            // btn_Shield
            // 
            this.btn_Shield.Location = new System.Drawing.Point(300, 351);
            this.btn_Shield.Name = "btn_Shield";
            this.btn_Shield.Size = new System.Drawing.Size(50, 49);
            this.btn_Shield.TabIndex = 6;
            this.btn_Shield.Text = "Shield";
            this.btn_Shield.UseVisualStyleBackColor = true;
            // 
            // lbl_health
            // 
            this.lbl_health.AutoSize = true;
            this.lbl_health.Location = new System.Drawing.Point(650, 350);
            this.lbl_health.Name = "lbl_health";
            this.lbl_health.Size = new System.Drawing.Size(50, 13);
            this.lbl_health.TabIndex = 7;
            this.lbl_health.Text = "Health: 0";
            this.lbl_health.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_shield
            // 
            this.lbl_shield.AutoSize = true;
            this.lbl_shield.Location = new System.Drawing.Point(652, 366);
            this.lbl_shield.Name = "lbl_shield";
            this.lbl_shield.Size = new System.Drawing.Size(48, 13);
            this.lbl_shield.TabIndex = 8;
            this.lbl_shield.Text = "Shield: 0";
            this.lbl_shield.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kills
            // 
            this.lbl_kills.AutoSize = true;
            this.lbl_kills.Location = new System.Drawing.Point(663, 382);
            this.lbl_kills.Name = "lbl_kills";
            this.lbl_kills.Size = new System.Drawing.Size(37, 13);
            this.lbl_kills.TabIndex = 9;
            this.lbl_kills.Text = "Kills: 0";
            this.lbl_kills.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lbl_kills);
            this.Controls.Add(this.lbl_shield);
            this.Controls.Add(this.lbl_health);
            this.Controls.Add(this.btn_Shield);
            this.Controls.Add(this.btn_Snipe);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.pbx_moves);
            this.Controls.Add(this.pbx_board);
            this.Name = "frm_board";
            this.Text = "Board Game";
            this.Load += new System.EventHandler(this.frm_board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_moves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_board;
        private System.Windows.Forms.PictureBox pbx_moves;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_Snipe;
        private System.Windows.Forms.Button btn_Shield;
        private System.Windows.Forms.Label lbl_health;
        private System.Windows.Forms.Label lbl_shield;
        private System.Windows.Forms.Label lbl_kills;
    }
}

