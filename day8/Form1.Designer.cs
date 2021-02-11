namespace day8
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
            this.checkedListTrainees = new System.Windows.Forms.CheckedListBox();
            this.checkedListLabTrainees = new System.Windows.Forms.CheckedListBox();
            this.trainees = new System.Windows.Forms.Label();
            this.labTrainees = new System.Windows.Forms.Label();
            this.checkedToLab = new System.Windows.Forms.Button();
            this.allToLab = new System.Windows.Forms.Button();
            this.checkedFromLab = new System.Windows.Forms.Button();
            this.allfromLab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListTrainees
            // 
            this.checkedListTrainees.CheckOnClick = true;
            this.checkedListTrainees.FormattingEnabled = true;
            this.checkedListTrainees.Items.AddRange(new object[] {
            "noor",
            "ali",
            "haytham",
            "aliaa"});
            this.checkedListTrainees.Location = new System.Drawing.Point(95, 117);
            this.checkedListTrainees.Name = "checkedListTrainees";
            this.checkedListTrainees.Size = new System.Drawing.Size(144, 229);
            this.checkedListTrainees.TabIndex = 0;
            // 
            // checkedListLabTrainees
            // 
            this.checkedListLabTrainees.CheckOnClick = true;
            this.checkedListLabTrainees.FormattingEnabled = true;
            this.checkedListLabTrainees.Items.AddRange(new object[] {
            "walaa",
            "rasha ",
            "manar"});
            this.checkedListLabTrainees.Location = new System.Drawing.Point(559, 117);
            this.checkedListLabTrainees.Name = "checkedListLabTrainees";
            this.checkedListLabTrainees.Size = new System.Drawing.Size(170, 229);
            this.checkedListLabTrainees.TabIndex = 1;
            // 
            // trainees
            // 
            this.trainees.AutoSize = true;
            this.trainees.Location = new System.Drawing.Point(138, 74);
            this.trainees.Name = "trainees";
            this.trainees.Size = new System.Drawing.Size(46, 13);
            this.trainees.TabIndex = 2;
            this.trainees.Text = "trainees";
            this.trainees.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labTrainees
            // 
            this.labTrainees.AutoSize = true;
            this.labTrainees.Location = new System.Drawing.Point(628, 74);
            this.labTrainees.Name = "labTrainees";
            this.labTrainees.Size = new System.Drawing.Size(62, 13);
            this.labTrainees.TabIndex = 3;
            this.labTrainees.Text = "labTrainees";
            // 
            // checkedToLab
            // 
            this.checkedToLab.Location = new System.Drawing.Point(362, 138);
            this.checkedToLab.Name = "checkedToLab";
            this.checkedToLab.Size = new System.Drawing.Size(75, 23);
            this.checkedToLab.TabIndex = 4;
            this.checkedToLab.Text = ">";
            this.checkedToLab.UseVisualStyleBackColor = true;
            this.checkedToLab.Click += new System.EventHandler(this.CheckedToLab_Click);
            // 
            // allToLab
            // 
            this.allToLab.Location = new System.Drawing.Point(362, 185);
            this.allToLab.Name = "allToLab";
            this.allToLab.Size = new System.Drawing.Size(75, 23);
            this.allToLab.TabIndex = 5;
            this.allToLab.Text = ">>";
            this.allToLab.UseVisualStyleBackColor = true;
            this.allToLab.Click += new System.EventHandler(this.AllToLab_Click);
            // 
            // checkedFromLab
            // 
            this.checkedFromLab.Location = new System.Drawing.Point(362, 236);
            this.checkedFromLab.Name = "checkedFromLab";
            this.checkedFromLab.Size = new System.Drawing.Size(75, 23);
            this.checkedFromLab.TabIndex = 6;
            this.checkedFromLab.Text = "<";
            this.checkedFromLab.UseVisualStyleBackColor = true;
            this.checkedFromLab.Click += new System.EventHandler(this.CheckedFromLab_Click);
            // 
            // allfromLab
            // 
            this.allfromLab.Location = new System.Drawing.Point(362, 280);
            this.allfromLab.Name = "allfromLab";
            this.allfromLab.Size = new System.Drawing.Size(75, 23);
            this.allfromLab.TabIndex = 7;
            this.allfromLab.Text = "<<";
            this.allfromLab.UseVisualStyleBackColor = true;
            this.allfromLab.Click += new System.EventHandler(this.AllfromLab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allfromLab);
            this.Controls.Add(this.checkedFromLab);
            this.Controls.Add(this.allToLab);
            this.Controls.Add(this.checkedToLab);
            this.Controls.Add(this.labTrainees);
            this.Controls.Add(this.trainees);
            this.Controls.Add(this.checkedListLabTrainees);
            this.Controls.Add(this.checkedListTrainees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListTrainees;
        private System.Windows.Forms.CheckedListBox checkedListLabTrainees;
        private System.Windows.Forms.Label trainees;
        private System.Windows.Forms.Label labTrainees;
        private System.Windows.Forms.Button checkedToLab;
        private System.Windows.Forms.Button allToLab;
        private System.Windows.Forms.Button checkedFromLab;
        private System.Windows.Forms.Button allfromLab;
    }
}

