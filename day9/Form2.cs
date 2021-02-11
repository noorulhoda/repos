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
    public partial class Form2 : Form
    {
        public  float size
        {
            set; get;
        } = 16;
         public string fontFamily
        {
            set; get;
        }
         FontStyle style = FontStyle.Regular;

         public Color color
        {
            set; get;
        }

        public Font myFont;
        public Form2()
        {
            InitializeComponent();
            
        }
       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void RbRed_CheckedChanged(object sender, EventArgs e)
        {
          color= Color.Red;

        }

        private void RbBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void RbCustom_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            cdlg.ShowDialog();
            if(cdlg.ShowDialog()==DialogResult.OK)
                color = cdlg.Color;

        }

        private void CmbFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamily = cmbFontStyle.SelectedItem as string;
        }

        private void NumFontSize_ValueChanged(object sender, EventArgs e)
        {
            size = (float)numFontSize.Value;
        }

        public event EventHandler Evt;
        private void BtnApply_Click(object sender, EventArgs e)
        {

           
            style=FontStyle.Regular;
            if (chkBold.Checked) style |= FontStyle.Bold;
            if (chkItalic.Checked) style |= FontStyle.Italic;
            if (chkLined.Checked) style |= FontStyle.Underline;
             myFont = new Font(fontFamily, size, style);
            //Form1 f1 = this.MdiParent.MdiChildren[0]as Form1;
            //Font myFont = new Font(fontFamily, size,style);
            //f1.frm1txtFont = myFont;
            //f1.frm1txtclr = color;

            Evt(this, new EventArgs());

          

        }
    }
}
