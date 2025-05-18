namespace Food_Ordering_Management_System
{
    partial class Users_Admin_Form
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
            this.components = new System.ComponentModel.Container();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_Ordering_SystemDataSet = new Food_Ordering_Management_System.Food_Ordering_SystemDataSet();
            this.customerTableAdapter = new Food_Ordering_Management_System.Food_Ordering_SystemDataSetTableAdapters.CustomerTableAdapter();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.SwitcthToMenuItemsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IdComboBox
            // 
            this.IdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(128, 423);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(157, 28);
            this.IdComboBox.TabIndex = 38;
            this.IdComboBox.Text = "Edit/Delete by ID";
            this.IdComboBox.SelectedIndexChanged += new System.EventHandler(this.IdComboBox_SelectedIndexChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdLabel.Location = new System.Drawing.Point(68, 423);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 20);
            this.IdLabel.TabIndex = 37;
            this.IdLabel.Text = "ID";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(65, 533);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(65, 20);
            this.DescriptionLabel.TabIndex = 36;
            this.DescriptionLabel.Text = "Phones";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhoneTxt.Location = new System.Drawing.Point(176, 527);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(593, 26);
            this.PhoneTxt.TabIndex = 35;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvailableLabel.Location = new System.Drawing.Point(567, 428);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(83, 20);
            this.AvailableLabel.TabIndex = 34;
            this.AvailableLabel.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordTxt.Location = new System.Drawing.Point(657, 425);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(115, 26);
            this.PasswordTxt.TabIndex = 33;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailLabel.Location = new System.Drawing.Point(313, 479);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailTxt.Location = new System.Drawing.Point(396, 476);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(378, 26);
            this.EmailTxt.TabIndex = 31;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(320, 423);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTxt.Location = new System.Drawing.Point(380, 420);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(157, 26);
            this.NameTxt.TabIndex = 29;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryLabel.Location = new System.Drawing.Point(66, 482);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(71, 20);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "Address";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddressTxt.Location = new System.Drawing.Point(149, 479);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(143, 26);
            this.AddressTxt.TabIndex = 25;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteBtn.Location = new System.Drawing.Point(655, 579);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 42);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddBtn.Location = new System.Drawing.Point(69, 579);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 42);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Add User";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditBtn.Location = new System.Drawing.Point(377, 579);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(119, 42);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.food_Ordering_SystemDataSet;
            // 
            // food_Ordering_SystemDataSet
            // 
            this.food_Ordering_SystemDataSet.DataSetName = "Food_Ordering_SystemDataSet";
            this.food_Ordering_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(28, 61);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersWidth = 51;
            this.UsersDataGridView.RowTemplate.Height = 24;
            this.UsersDataGridView.Size = new System.Drawing.Size(825, 336);
            this.UsersDataGridView.TabIndex = 39;
            // 
            // SwitcthToMenuItemsBtn
            // 
            this.SwitcthToMenuItemsBtn.Location = new System.Drawing.Point(738, 625);
            this.SwitcthToMenuItemsBtn.Name = "SwitcthToMenuItemsBtn";
            this.SwitcthToMenuItemsBtn.Size = new System.Drawing.Size(139, 25);
            this.SwitcthToMenuItemsBtn.TabIndex = 40;
            this.SwitcthToMenuItemsBtn.Text = "Go to Menu Items";
            this.SwitcthToMenuItemsBtn.UseVisualStyleBackColor = true;
            this.SwitcthToMenuItemsBtn.Click += new System.EventHandler(this.SwitcthToMenuItemsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(370, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Users";
            // 
            // Users_Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitcthToMenuItemsBtn);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "Users_Admin_Form";
            this.Text = "Users-Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IdComboBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private Food_Ordering_SystemDataSet food_Ordering_SystemDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Food_Ordering_SystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Button SwitcthToMenuItemsBtn;
        private System.Windows.Forms.Label label1;
    }
}