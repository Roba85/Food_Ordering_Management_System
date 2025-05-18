namespace Food_Ordering_Management_System
{
    partial class SignUp
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YesRadioBtn = new System.Windows.Forms.RadioButton();
            this.NotAdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.BranchIdTxt = new System.Windows.Forms.TextBox();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(150, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(150, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(150, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(150, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(351, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(359, 159);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(281, 22);
            this.NameTxt.TabIndex = 10;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(359, 209);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(281, 22);
            this.EmailTxt.TabIndex = 11;
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(359, 270);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(281, 22);
            this.PhoneTxt.TabIndex = 12;
            this.PhoneTxt.TextChanged += new System.EventHandler(this.PhoneTxt_TextChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(359, 322);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(281, 22);
            this.PasswordTxt.TabIndex = 13;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressTxt);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.BranchIdTxt);
            this.groupBox1.Controls.Add(this.BranchLabel);
            this.groupBox1.Controls.Add(this.NotAdminRadioBtn);
            this.groupBox1.Controls.Add(this.YesRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(151, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is Admin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // YesRadioBtn
            // 
            this.YesRadioBtn.AutoSize = true;
            this.YesRadioBtn.Location = new System.Drawing.Point(36, 39);
            this.YesRadioBtn.Name = "YesRadioBtn";
            this.YesRadioBtn.Size = new System.Drawing.Size(58, 24);
            this.YesRadioBtn.TabIndex = 0;
            this.YesRadioBtn.TabStop = true;
            this.YesRadioBtn.Text = "Yes";
            this.YesRadioBtn.UseVisualStyleBackColor = true;
            this.YesRadioBtn.CheckedChanged += new System.EventHandler(this.YesRadioBtn_CheckedChanged);
            // 
            // NotAdminRadioBtn
            // 
            this.NotAdminRadioBtn.AutoSize = true;
            this.NotAdminRadioBtn.Location = new System.Drawing.Point(172, 39);
            this.NotAdminRadioBtn.Name = "NotAdminRadioBtn";
            this.NotAdminRadioBtn.Size = new System.Drawing.Size(51, 24);
            this.NotAdminRadioBtn.TabIndex = 1;
            this.NotAdminRadioBtn.TabStop = true;
            this.NotAdminRadioBtn.Text = "No";
            this.NotAdminRadioBtn.UseVisualStyleBackColor = true;
            this.NotAdminRadioBtn.CheckedChanged += new System.EventHandler(this.NotAdminRadioBtn_CheckedChanged);
            // 
            // BranchIdTxt
            // 
            this.BranchIdTxt.Location = new System.Drawing.Point(161, 97);
            this.BranchIdTxt.Name = "BranchIdTxt";
            this.BranchIdTxt.Size = new System.Drawing.Size(190, 26);
            this.BranchIdTxt.TabIndex = 16;
            this.BranchIdTxt.Visible = false;
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BranchLabel.Location = new System.Drawing.Point(32, 97);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(85, 20);
            this.BranchLabel.TabIndex = 15;
            this.BranchLabel.Text = "Branch ID";
            this.BranchLabel.Visible = false;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignUpBtn.Location = new System.Drawing.Point(372, 584);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(130, 39);
            this.SignUpBtn.TabIndex = 15;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(161, 91);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(190, 26);
            this.AddressTxt.TabIndex = 18;
            this.AddressTxt.Visible = false;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddressLabel.Location = new System.Drawing.Point(32, 91);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(71, 20);
            this.AddressLabel.TabIndex = 17;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton YesRadioBtn;
        private System.Windows.Forms.TextBox BranchIdTxt;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.RadioButton NotAdminRadioBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Label AddressLabel;
    }
}