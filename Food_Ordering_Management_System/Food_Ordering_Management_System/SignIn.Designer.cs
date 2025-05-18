namespace Food_Ordering_Management_System
{
    partial class SignIn
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
            this.SignInBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotAdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.YesRadioBtn = new System.Windows.Forms.RadioButton();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignInBtn.Location = new System.Drawing.Point(385, 525);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(130, 39);
            this.SignInBtn.TabIndex = 26;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotAdminRadioBtn);
            this.groupBox1.Controls.Add(this.YesRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(167, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 94);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is Admin";
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
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(372, 276);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(281, 22);
            this.PasswordTxt.TabIndex = 24;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(372, 198);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(281, 22);
            this.EmailTxt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(163, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(163, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(364, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 48);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sign In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NotAdminRadioBtn;
        private System.Windows.Forms.RadioButton YesRadioBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

