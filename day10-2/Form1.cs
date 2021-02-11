using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void UserControl11_speedChanged(object sender, EventArgs e)
        {
            progressBar1.Step = userControl11.speed;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
                progressBar1.PerformStep();
        }
    }
}
