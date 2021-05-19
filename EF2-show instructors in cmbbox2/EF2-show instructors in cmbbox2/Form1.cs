using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EF2_show_instructors_in_cmbbox2
{
    public partial class Form1 : Form
    {
        ITIEntities context;
        
        public Form1()
        {
            InitializeComponent();
            context = new ITIEntities();
            context.Database.Log = log=>Debug.WriteLine(log);//to show db queries made by compiler
            LoadDepartments();
            
        }

        private void LoadDepartments()
        {
            cmbDepartments.DataSource =context.Departments.ToList() ;
            cmbDepartments.ValueMember = "Dept_Id";
            cmbDepartments.DisplayMember = "Dept_Name";
        }
        private void LoadInstructors(int DeptId)
        {

            lstViwInstructors.Items.Clear();

            var Instrs = context.Instructors.Where(i => i.Dept_Id == DeptId) ;
           foreach (Instructor i in Instrs)
           lstViwInstructors.Items.Add(i.Ins_Name);
        }

        private void CmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DID = ((Department)cmbDepartments.SelectedItem).Dept_Id;// cmbDepartments.SelectedValue);
            LoadInstructors(DID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LstViwInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            foreach (Instructor i in context.Instructors)
                if (i.Ins_Name == lstViwInstructors.FocusedItem.SubItems[0].Text)
                {
                    txtId.Text = i.Ins_Id.ToString();
                    txtName.Text = i.Ins_Name;
                    txtSalary.Text = i.Salary.ToString();
                }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor();
            i.Ins_Id = int.Parse(txtId.Text);
            i.Ins_Name = txtName.Text;
            i.Dept_Id = ((Department)cmbDepartments.SelectedItem).Dept_Id;
            i.Salary=int.Parse(txtSalary.Text);
            context.Instructors.Add(i);
            context.SaveChanges();
            CmbDepartments_SelectedIndexChanged(this, new EventArgs());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = lstViwInstructors.SelectedItems[0].Text;
            Instructor i = context.Instructors.Where(ii => ii.Ins_Name ==name ).FirstOrDefault();
            i.Ins_Id = int.Parse(txtId.Text);
            i.Ins_Name = txtName.Text;
            i.Dept_Id = ((Department)cmbDepartments.SelectedItem).Dept_Id;
            i.Salary = int.Parse(txtSalary.Text);
            context.SaveChanges();
            CmbDepartments_SelectedIndexChanged(this, new EventArgs());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string name = lstViwInstructors.SelectedItems[0].Text;
            Instructor i = context.Instructors.Where(ii => ii.Ins_Name == name).FirstOrDefault();
     
            context.Instructors.Remove(i);
            context.SaveChanges();
            CmbDepartments_SelectedIndexChanged(this, new EventArgs());
            txtId.Text = "";
            txtName.Text = "";
            txtSalary.Text = "";
        }
    }
}
