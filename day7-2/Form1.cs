using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day7_2
{
    public partial class Form1 : Form
    {
        int hobbiesCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (swimming.Checked) hobbiesCounter++;
            else hobbiesCounter--;
        }

        private void Tennis_CheckedChanged(object sender, EventArgs e)
        {
            if (tennis.Checked) hobbiesCounter++;
            else hobbiesCounter--;
        }

        private void Football_CheckedChanged(object sender, EventArgs e)
        {
            if (football.Checked) hobbiesCounter++;
            else hobbiesCounter--;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 5 && hobbiesCounter >=2 && txtEmail.Text.Contains('@'))
                thankyou.Visible = true;
            else
            {
                if (txtName.Text.Length < 5)
                    nameErrorLbl.Visible = true;
                if (hobbiesCounter < 2)
                    hobbiesErrorLbl.Visible = true;
                if (txtEmail.Text.Contains('@')==false)
                    emailErrorLbl.Visible = true;
            }
        }
    }
}
