using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day9
{
    public partial class Form1 : Form
    {
        
      
        Form2 f2 = new Form2();
        public Form1()
        {
            
            InitializeComponent();
          


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form2 f = new Form2();
            //f.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form2 f = new Form2();
            //f.ShowDialog();
        }
        public void change(object t,EventArgs e)
        {
            txtFormat.Font = f2.myFont;
            txtFormat.ForeColor = f2.color;
        }
        private void BtnFormat_Click(object sender, EventArgs e)
        {
           
            f2.Evt += change;
            parent frm = this.MdiParent as parent;
            f2.MdiParent = this.MdiParent as parent;
            f2.Show();
        }
    }
}
