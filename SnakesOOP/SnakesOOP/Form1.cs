using System;
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
    public partial class frm_Launcher : Form
    {
        public frm_Launcher()
        {
            InitializeComponent();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
