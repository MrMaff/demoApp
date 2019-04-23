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
    }
}
