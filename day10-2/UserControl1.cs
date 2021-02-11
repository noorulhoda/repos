using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10_2
{
    public partial class UserControl1 : UserControl
    {
        public int speed;
        public event EventHandler speedChanged;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            speed = trackBar1.Value;
            speedChanged(this, new EventArgs());

        }
    }
}
