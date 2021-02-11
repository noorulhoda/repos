namespace day7_2
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
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.tennis = new System.Windows.Forms.CheckBox();
            this.swimming = new System.Windows.Forms.CheckBox();
            this.football = new System.Windows.Forms.CheckBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.register = new System.Windows.Forms.Button();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.hobbiesErrorLbl = new System.Windows.Forms.Label();
            this.thankyou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(58, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(58, 99);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 1;
            this.email.Text = "email";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(58, 174);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(41, 13);
            this.gender.TabIndex = 2;
            this.gender.Text = "gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "hobbies";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(129, 174);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(47, 17);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // tennis
            // 
            this.tennis.AutoSize = true;
            this.tennis.Location = new System.Drawing.Point(129, 228);
            this.tennis.Name = "tennis";
            this.tennis.Size = new System.Drawing.Size(55, 17);
            this.tennis.TabIndex = 7;
            this.tennis.Text = "tennis";
            this.tennis.UseVisualStyleBackColor = true;
            this.tennis.CheckedChanged += new System.EventHandler(this.Tennis_CheckedChanged);
            // 
            // swimming
            // 
            this.swimming.AutoSize = true;
            this.swimming.Location = new System.Drawing.Point(369, 228);
            this.swimming.Name = "swimming";
            this.swimming.Size = new System.Drawing.Size(71, 17);
            this.swimming.TabIndex = 8;
            this.swimming.Text = "swimming";
            this.swimming.UseVisualStyleBackColor = true;
            this.swimming.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // football
            // 
            this.football.AutoSize = true;
            this.football.Location = new System.Drawing.Point(246, 228);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(62, 17);
            this.football.TabIndex = 9;
            this.football.Text = "football";
            this.football.UseVisualStyleBackColor = true;
            this.football.CheckedChanged += new System.EventHandler(this.Football_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(246, 174);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(57, 17);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(371, 315);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 11;
            this.register.Text = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLbl.Location = new System.Drawing.Point(298, 102);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(108, 13);
            this.emailErrorLbl.TabIndex = 12;
            this.emailErrorLbl.Text = "email must contain @";
            this.emailErrorLbl.Visible = false;
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLbl.Location = new System.Drawing.Point(298, 59);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(125, 13);
            this.nameErrorLbl.TabIndex = 13;
            this.nameErrorLbl.Text = "name must be >5 letters";
            this.nameErrorLbl.Visible = false;
            // 
            // hobbiesErrorLbl
            // 
            this.hobbiesErrorLbl.AutoSize = true;
            this.hobbiesErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.hobbiesErrorLbl.Location = new System.Drawing.Point(480, 232);
            this.hobbiesErrorLbl.Name = "hobbiesErrorLbl";
            this.hobbiesErrorLbl.Size = new System.Drawing.Size(170, 13);
            this.hobbiesErrorLbl.TabIndex = 14;
            this.hobbiesErrorLbl.Text = "you must check 2 Hobbies at least";
            this.hobbiesErrorLbl.Visible = false;
            // 
            // thankyou
            // 
            this.thankyou.AutoSize = true;
            this.thankyou.ForeColor = System.Drawing.Color.Green;
            this.thankyou.Location = new System.Drawing.Point(338, 278);
            this.thankyou.Name = "thankyou";
            this.thankyou.Size = new System.Drawing.Size(142, 13);
            this.thankyou.TabIndex = 15;
            this.thankyou.Text = "thankyou for registering ^^";
            this.thankyou.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.thankyou);
            this.Controls.Add(this.hobbiesErrorLbl);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.emailErrorLbl);
            this.Controls.Add(this.register);
            this.Controls.Add(this.female);
            this.Controls.Add(this.football);
            this.Controls.Add(this.swimming);
            this.Controls.Add(this.tennis);
            this.Controls.Add(this.male);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.CheckBox tennis;
        private System.Windows.Forms.CheckBox swimming;
        private System.Windows.Forms.CheckBox football;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.Label nameErrorLbl;
        private System.Windows.Forms.Label hobbiesErrorLbl;
        private System.Windows.Forms.Label thankyou;
    }
}

