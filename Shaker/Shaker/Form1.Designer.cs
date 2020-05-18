namespace Shaker
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
            this.pbx_Shaker = new System.Windows.Forms.PictureBox();
            this.btn_Roll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Shaker
            // 
            this.pbx_Shaker.InitialImage = global::Shaker.Properties.Resources.felt;
            this.pbx_Shaker.Location = new System.Drawing.Point(20, 16);
            this.pbx_Shaker.Name = "pbx_Shaker";
            this.pbx_Shaker.Size = new System.Drawing.Size(400, 400);
            this.pbx_Shaker.TabIndex = 0;
            this.pbx_Shaker.TabStop = false;
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(20, 433);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(400, 54);
            this.btn_Roll.TabIndex = 1;
            this.btn_Roll.Text = "Roll Dice";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 499);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.pbx_Shaker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Shaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Shaker;
        private System.Windows.Forms.Button btn_Roll;
    }
}

