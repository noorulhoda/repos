using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10_4
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        bool Clicked = false;
        public Form1()
        {
            InitializeComponent();
           rect = new Rectangle(10, 10, 20, 20);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
            if(
               Clicked
                )
            {
                Graphics gr = CreateGraphics();
                if (e.Button == MouseButtons.Left)
                    gr.Clear(this.BackColor);
               
                gr.DrawRectangle(Pens.Black,e.X,e.Y,rect.Width,rect.Height);
            }
            if (
             !Clicked
              )  return;

           }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CreateGraphics().DrawRectangle(Pens.Black, rect);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            rect.X = e.X; rect.Y = e.Y;
            Clicked = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (
               e.X > rect.X &&
               e.X < rect.X + rect.Width &&
               e.Y > rect.Y &&
               e.Y < rect.Y + rect.Height )
            Clicked = true;
        }
    }
}
