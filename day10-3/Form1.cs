using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10_3
{
    public partial class Form1 : Form
    {
   
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = CreateGraphics();
            if (e.Button == MouseButtons.Left)
                gr.FillRectangle(Brushes.Blue, e.X, e.Y, 3, 3);
            else if (e.Button == MouseButtons.Right)
                gr.FillRectangle(new SolidBrush(this.BackColor), e.X, e.Y, 6, 6);
        }
    }
}
