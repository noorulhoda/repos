namespace day777
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
            this.convert = new System.Windows.Forms.Button();
            this.valTxt = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.Label();
            this.cmTOm = new System.Windows.Forms.RadioButton();
            this.mTOcm = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.resTxt = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(211, 288);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(105, 35);
            this.convert.TabIndex = 0;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // valTxt
            // 
            this.valTxt.Location = new System.Drawing.Point(70, 147);
            this.valTxt.Name = "valTxt";
            this.valTxt.Size = new System.Drawing.Size(100, 20);
            this.valTxt.TabIndex = 1;
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(67, 120);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(33, 13);
            this.value.TabIndex = 2;
            this.value.Text = "value";
            // 
            // cmTOm
            // 
            this.cmTOm.AutoSize = true;
            this.cmTOm.Location = new System.Drawing.Point(318, 162);
            this.cmTOm.Name = "cmTOm";
            this.cmTOm.Size = new System.Drawing.Size(60, 17);
            this.cmTOm.TabIndex = 3;
            this.cmTOm.TabStop = true;
            this.cmTOm.Text = "cmTOm";
            this.cmTOm.UseVisualStyleBackColor = true;
            // 
            // mTOcm
            // 
            this.mTOcm.AutoSize = true;
            this.mTOcm.Location = new System.Drawing.Point(318, 204);
            this.mTOcm.Name = "mTOcm";
            this.mTOcm.Size = new System.Drawing.Size(60, 17);
            this.mTOcm.TabIndex = 4;
            this.mTOcm.TabStop = true;
            this.mTOcm.Text = "mTOcm";
            this.mTOcm.UseVisualStyleBackColor = true;
            this.mTOcm.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(67, 211);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(34, 13);
            this.result.TabIndex = 6;
            this.result.Text = "result";
            this.result.Click += new System.EventHandler(this.Label2_Click);
            // 
            // resTxt
            // 
            this.resTxt.Location = new System.Drawing.Point(70, 238);
            this.resTxt.Name = "resTxt";
            this.resTxt.Size = new System.Drawing.Size(100, 20);
            this.resTxt.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(20);
            this.title.Size = new System.Drawing.Size(96, 53);
            this.title.TabIndex = 7;
            this.title.Text = "Converter";
            this.title.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 372);
            this.Controls.Add(this.title);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resTxt);
            this.Controls.Add(this.mTOcm);
            this.Controls.Add(this.cmTOm);
            this.Controls.Add(this.value);
            this.Controls.Add(this.valTxt);
            this.Controls.Add(this.convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox valTxt;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.RadioButton cmTOm;
        private System.Windows.Forms.RadioButton mTOcm;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox resTxt;
        private System.Windows.Forms.Label title;
    }
}

