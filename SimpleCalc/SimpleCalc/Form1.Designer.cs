﻿namespace SimpleCalc
{
    partial class Form1
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
            this.tbx_Screen = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Screen
            // 
            this.tbx_Screen.BackColor = System.Drawing.Color.DimGray;
            this.tbx_Screen.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Screen.ForeColor = System.Drawing.Color.Lime;
            this.tbx_Screen.Location = new System.Drawing.Point(51, 35);
            this.tbx_Screen.MaxLength = 14;
            this.tbx_Screen.Name = "tbx_Screen";
            this.tbx_Screen.Size = new System.Drawing.Size(291, 50);
            this.tbx_Screen.TabIndex = 0;
            this.tbx_Screen.Text = "0";
            this.tbx_Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Maroon;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(51, 113);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 60);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Maroon;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(129, 113);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 60);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Maroon;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(205, 113);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 60);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Maroon;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(282, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 60);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.OperClick);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.Maroon;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_sub.ForeColor = System.Drawing.Color.White;
            this.btn_sub.Location = new System.Drawing.Point(282, 188);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(60, 60);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.OperClick);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Maroon;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(205, 188);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 60);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Maroon;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(129, 188);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 60);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Maroon;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(51, 188);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 60);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.Maroon;
            this.btn_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_mult.ForeColor = System.Drawing.Color.White;
            this.btn_mult.Location = new System.Drawing.Point(282, 267);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(60, 60);
            this.btn_mult.TabIndex = 12;
            this.btn_mult.Text = "X";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.OperClick);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Maroon;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(205, 267);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 60);
            this.btn_3.TabIndex = 11;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Maroon;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(129, 267);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 60);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Maroon;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(51, 267);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 60);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.Maroon;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_div.ForeColor = System.Drawing.Color.White;
            this.btn_div.Location = new System.Drawing.Point(282, 345);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(60, 60);
            this.btn_div.TabIndex = 16;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.OperClick);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.Maroon;
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_point.ForeColor = System.Drawing.Color.White;
            this.btn_point.Location = new System.Drawing.Point(205, 345);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(60, 60);
            this.btn_point.TabIndex = 15;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Maroon;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(129, 345);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 60);
            this.btn_0.TabIndex = 14;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.NumClick);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Maroon;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(51, 345);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(60, 60);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.Maroon;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.Color.White;
            this.btn_equal.Location = new System.Drawing.Point(51, 417);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(291, 60);
            this.btn_equal.TabIndex = 17;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 520);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.tbx_Screen);
            this.Name = "Form1";
            this.Text = "Simple Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Screen;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_equal;
    }
}

