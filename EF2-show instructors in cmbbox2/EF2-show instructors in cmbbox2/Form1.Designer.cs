
namespace EF2_show_instructors_in_cmbbox2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.lstViwInstructors = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.instructorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(66, 45);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(200, 28);
            this.cmbDepartments.TabIndex = 0;
            this.cmbDepartments.SelectedIndexChanged += new System.EventHandler(this.CmbDepartments_SelectedIndexChanged);
            // 
            // lstViwInstructors
            // 
            this.lstViwInstructors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.instructorName});
            this.lstViwInstructors.HideSelection = false;
            this.lstViwInstructors.Location = new System.Drawing.Point(66, 105);
            this.lstViwInstructors.Name = "lstViwInstructors";
            this.lstViwInstructors.Size = new System.Drawing.Size(108, 293);
            this.lstViwInstructors.TabIndex = 1;
            this.lstViwInstructors.UseCompatibleStateImageBehavior = false;
            this.lstViwInstructors.View = System.Windows.Forms.View.Details;
            this.lstViwInstructors.SelectedIndexChanged += new System.EventHandler(this.LstViwInstructors_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(438, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "name";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(438, 186);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(214, 20);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.Text = "salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(672, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // instructorName
            // 
            this.instructorName.Text = "instructorName";
            this.instructorName.Width = 104;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(438, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(214, 20);
            this.txtId.TabIndex = 7;
            this.txtId.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstViwInstructors);
            this.Controls.Add(this.cmbDepartments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.ListView lstViwInstructors;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader instructorName;
        private System.Windows.Forms.TextBox txtId;
    }
}

