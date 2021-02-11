namespace day9
{
    partial class Form2
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
            this.cmbFontStyle = new System.Windows.Forms.ComboBox();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkLined = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFontStyle
            // 
            this.cmbFontStyle.FormattingEnabled = true;
            this.cmbFontStyle.Items.AddRange(new object[] {
            "Tahoma",
            "Algerian",
            "Edwardian Script ITC"});
            this.cmbFontStyle.Location = new System.Drawing.Point(189, 95);
            this.cmbFontStyle.Name = "cmbFontStyle";
            this.cmbFontStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbFontStyle.TabIndex = 0;
            this.cmbFontStyle.SelectedIndexChanged += new System.EventHandler(this.CmbFontStyle_SelectedIndexChanged);
            // 
            // numFontSize
            // 
            this.numFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numFontSize.Location = new System.Drawing.Point(190, 162);
            this.numFontSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(120, 20);
            this.numFontSize.TabIndex = 1;
            this.numFontSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.NumFontSize_ValueChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(381, 77);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(41, 17);
            this.rbRed.TabIndex = 2;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.RbRed_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(381, 127);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(45, 17);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.RbBlue_CheckedChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(381, 175);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(59, 17);
            this.rbCustom.TabIndex = 4;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.RbCustom_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(235, 221);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(35, 80);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(46, 17);
            this.chkBold.TabIndex = 6;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkLined
            // 
            this.chkLined.AutoSize = true;
            this.chkLined.Location = new System.Drawing.Point(35, 176);
            this.chkLined.Name = "chkLined";
            this.chkLined.Size = new System.Drawing.Size(79, 17);
            this.chkLined.TabIndex = 7;
            this.chkLined.Text = "underLined";
            this.chkLined.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(35, 128);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(49, 17);
            this.chkItalic.TabIndex = 8;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 277);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkLined);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.cmbFontStyle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFontStyle;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkLined;
        private System.Windows.Forms.CheckBox chkItalic;
    }
}