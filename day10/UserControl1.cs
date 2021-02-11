using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10
{
    public partial class UserControl1 : UserControl
    {
        public float size { set; get; } = 10;
        public Color color { set; get; }
        public event EventHandler valuesChanged;
        public UserControl1()
        {
            InitializeComponent();
        }
  

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string s=(string) domainUpDown1.SelectedItem;
             color  = ColorTranslator.FromHtml(s);
           
            valuesChanged(this,new EventArgs());

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size =(int) numericUpDown1.Value;
            valuesChanged(this, new EventArgs());
        }
    }
}
