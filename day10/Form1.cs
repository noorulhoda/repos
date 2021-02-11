using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl11_valuesChanged(object sender, EventArgs e)
        {
            label1.ForeColor= userControl11.color;
            label1.Font = new Font(this.Font.FontFamily, userControl11.size,this.Font.Style);
        }
    }
}
