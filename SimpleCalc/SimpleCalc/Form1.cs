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
            tbx_Screen.Text = "0";
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

        private void operClick(object sender, EventArgs e)
        {
            if (currentOp != "")
            {
                mem2 = decimal.Parse(tbx_Screen.Text);
                tbx_Screen.Text = calcAnswer().ToString();
            }
            mem1 = decimal.Parse(tbx_Screen.Text);
            currentOp = (sender as Button).Text;
        }

        private decimal calcAnswer()
        {
            decimal answer = 0;

            switch (currentOp)
            {
                case "+":
                    answer = mem1 + mem2;
                    break;
                case "-":
                    answer = mem1 - mem2;
                    break;
                case "X":
                    answer = mem1 * mem2;
                    break;
                case "÷":
                    answer = mem1 / mem2;
                    break;
                default:
                    break;
            }
            currentOp = "";
            return answer;

        }
    }
}
