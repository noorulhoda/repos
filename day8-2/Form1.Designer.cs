namespace day8_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lstVstudents = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "birthDate";
            // 
            // saveAdd
            // 
            this.saveAdd.Location = new System.Drawing.Point(84, 352);
            this.saveAdd.Name = "saveAdd";
            this.saveAdd.Size = new System.Drawing.Size(75, 23);
            this.saveAdd.TabIndex = 3;
            this.saveAdd.Text = "saveAdd";
            this.saveAdd.UseVisualStyleBackColor = true;
            this.saveAdd.Click += new System.EventHandler(this.SaveAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(214, 352);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(189, 274);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(179, 20);
            this.datePicker.TabIndex = 5;
            this.datePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(179, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lstVstudents
            // 
            this.lstVstudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.phone,
            this.birthdate});
            this.lstVstudents.FullRowSelect = true;
            this.lstVstudents.HideSelection = false;
            this.lstVstudents.Location = new System.Drawing.Point(441, 42);
            this.lstVstudents.Name = "lstVstudents";
            this.lstVstudents.Size = new System.Drawing.Size(290, 386);
            this.lstVstudents.TabIndex = 8;
            this.lstVstudents.UseCompatibleStateImageBehavior = false;
            this.lstVstudents.View = System.Windows.Forms.View.Details;
            this.lstVstudents.SelectedIndexChanged += new System.EventHandler(this.LstVstudents_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "name";
            // 
            // phone
            // 
            this.phone.Text = "phone";
            // 
            // birthdate
            // 
            this.birthdate.Text = "birthDate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVstudents);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.saveAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ListView lstVstudents;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader birthdate;
    }
}

