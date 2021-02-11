using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillView();
        }

        public void fillView()
        {
            lstVstudents.Items.Clear();
            foreach (student s in studentsData.students)
            {
                ListViewItem it = new ListViewItem(s.name);
                it.SubItems.Add(s.phone);
                it.SubItems.Add(s.date.Date.ToString());
                lstVstudents.Items.Add(it);
            }
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LstVstudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = lstVstudents.Items[lstVstudents.FocusedItem.Index].SubItems[0].Text;
            txtPhone.Text= lstVstudents.Items[lstVstudents.FocusedItem.Index].SubItems[1].Text;
            datePicker.Text= lstVstudents.Items[lstVstudents.FocusedItem.Index].SubItems[2].Text;
        }

        public bool existedName(string name)
        {
            foreach (student s in studentsData.students)
                if (s.name == name) return true;
            return false;
        }
        private void SaveAdd_Click(object sender, EventArgs e)

        {


            if (existedName(txtName.Text))
            {
               //
                studentsData.students[lstVstudents.FocusedItem.Index].name = txtName.Text;
                studentsData.students[lstVstudents.FocusedItem.Index].phone = txtPhone.Text;
                studentsData.students[lstVstudents.FocusedItem.Index].date = datePicker.Value;
                fillView();
            }
            else
            {
                student s = new student(txtName.Text, txtPhone.Text, datePicker.Value);
                studentsData.students.Add(s);
                fillView();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            studentsData.students.RemoveAt(lstVstudents.FocusedItem.Index);
            fillView();

        }
    }
}
