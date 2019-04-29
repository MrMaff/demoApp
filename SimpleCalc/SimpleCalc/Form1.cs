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
        string screenText = "0";
        string currentOp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screenText = "0";
            UpdateDisplay();
            this.Icon = Properties.Resources.calculator;
        }

        private void UpdateDisplay()
        {
            tbx_Screen.Text = screenText;
        }

        private void Add2display(int num)
        {
            if (screenText != "0")
            {
                screenText = screenText + num.ToString();
            }
            else
            {
                screenText = num.ToString();
            }

            UpdateDisplay();
        }

        private void NumClick(object sender, EventArgs e)
        {
            string buttonNum = (sender as Button).Text;
            Add2display(int.Parse(buttonNum));
        }

        private void OperClick(object sender, EventArgs e)
        {
            CalcCall();
            mem1 = decimal.Parse(screenText);
            currentOp = (sender as Button).Text;
            screenText = "0";
        }

        private void CalcCall()
        {
            if (currentOp != "")
            {
                mem2 = decimal.Parse(screenText);
                if (calcAnswer())
                {
                    UpdateDisplay();
                }
                currentOp = "";
            }
        }

            private bool calcAnswer()
        {
            decimal answer = 0;
            bool completed = true;

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
                    if (mem2 != 0)
                    {
                        answer = mem1 / mem2;
                    }
                    else
                    {
                        tbx_Screen.Text = "Error: DIV 0";
                        completed = false;
                    }    
                    break;
                default:
                    completed = false;
                    break;
            }
            
            screenText = answer.ToString();
            return completed;

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            CalcCall();
            screenText = "0";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (screenText.Contains(".") == false)
            {
                screenText = screenText + ".";
                UpdateDisplay();
            }
            else Console.Beep();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (screenText.Length > 1)
            {
                screenText = screenText.Remove(screenText.Length-1);
            }
            else
            {
                screenText = "0";
            }
            UpdateDisplay();
        }
    }
}
