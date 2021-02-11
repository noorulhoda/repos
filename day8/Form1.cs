using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedToLab_Click(object sender, EventArgs e)
        {
            int myCount = checkedListTrainees.CheckedItems.Count;
            for (int c = myCount - 1; c >= 0; c--)
            {
                string i= checkedListTrainees.CheckedItems[c] as string;
                checkedListLabTrainees.Items.Add(i);
                checkedListTrainees.Items.Remove(i);
            }
           
        }

        private void AllToLab_Click(object sender, EventArgs e)
        {
            int myCount = checkedListTrainees.Items.Count;
            for (int c=myCount-1;c>=0 ;c--)
            {
                string i = checkedListTrainees.Items[c] as string;
                checkedListLabTrainees.Items.Add(i);
                checkedListTrainees.Items.Remove(i);
            }
              
                
        }

        private void CheckedFromLab_Click(object sender, EventArgs e)
        {
            int myCount = checkedListLabTrainees.CheckedItems.Count;
            for (int c = myCount - 1; c >= 0; c--)
            {
                string i = checkedListLabTrainees.CheckedItems[c] as string;
                checkedListTrainees.Items.Add(i);
                checkedListLabTrainees.Items.Remove(i);
            }
        }

        private void AllfromLab_Click(object sender, EventArgs e)
        {
            int myCount = checkedListLabTrainees.Items.Count;
            for (int c = myCount - 1; c >= 0; c--)
            {
                string i = checkedListLabTrainees.Items[c] as string;
                checkedListTrainees.Items.Add(i);
                checkedListLabTrainees.Items.Remove(i);
            }
        }
    }
}
