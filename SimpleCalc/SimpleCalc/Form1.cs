using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        decimal answer = 0;
        decimal mem1 = 0;
        decimal mem2 = 0;
        string lastOp = "";
        string currentOp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            answer = 0;
            tbx_Screen.Text = answer.ToString();
        }

        private void add2display(int num)
        {
            if (tbx_Screen.Text != "0")
            {
                tbx_Screen.Text = tbx_Screen.Text + num.ToString();
            }
            else
            {
                tbx_Screen.Text = num.ToString();
            }
        }

        private void numClick(object sender, EventArgs e)
        {
            string buttonNum = (sender as Button).Text;
            add2display(int.Parse(buttonNum));
        }
    }
}
