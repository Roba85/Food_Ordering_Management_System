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
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.AvailableTxt = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonTxt = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTxt = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_Ordering_SystemDataSet = new Food_Ordering_Management_System.Food_Ordering_SystemDataSet();
            this.customerTableAdapter = new Food_Ordering_Management_System.Food_Ordering_SystemDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IdComboBox
            // 
            this.IdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(125, 394);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(157, 28);
            this.IdComboBox.TabIndex = 38;
            this.IdComboBox.Text = "Edit/Delete by ID";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdLabel.Location = new System.Drawing.Point(65, 394);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 20);
            this.IdLabel.TabIndex = 37;
            this.IdLabel.Text = "ID";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(65, 504);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.DescriptionLabel.TabIndex = 36;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionTxt.Location = new System.Drawing.Point(176, 498);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(593, 26);
            this.DescriptionTxt.TabIndex = 35;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvailableLabel.Location = new System.Drawing.Point(579, 450);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(76, 20);
            this.AvailableLabel.TabIndex = 34;
            this.AvailableLabel.Text = "Available";
            // 
            // AvailableTxt
            // 
            this.AvailableTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvailableTxt.Location = new System.Drawing.Point(669, 447);
            this.AvailableTxt.Name = "AvailableTxt";
            this.AvailableTxt.Size = new System.Drawing.Size(100, 26);
            this.AvailableTxt.TabIndex = 33;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceLabel.Location = new System.Drawing.Point(313, 450);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 32;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceTxt.Location = new System.Drawing.Point(396, 447);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(143, 26);
            this.PriceTxt.TabIndex = 31;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(65, 447);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 30;
            this.NameLabel.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTxt.Location = new System.Drawing.Point(125, 444);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(157, 26);
            this.NameTxt.TabIndex = 29;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SeasonLabel.Location = new System.Drawing.Point(579, 391);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(65, 20);
            this.SeasonLabel.TabIndex = 28;
            this.SeasonLabel.Text = "Season";
            // 
            // SeasonTxt
            // 
            this.SeasonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SeasonTxt.Location = new System.Drawing.Point(669, 388);
            this.SeasonTxt.Name = "SeasonTxt";
            this.SeasonTxt.Size = new System.Drawing.Size(100, 26);
            this.SeasonTxt.TabIndex = 27;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryLabel.Location = new System.Drawing.Point(313, 391);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(76, 20);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryTxt.Location = new System.Drawing.Point(396, 388);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(143, 26);
            this.CategoryTxt.TabIndex = 25;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteBtn.Location = new System.Drawing.Point(655, 550);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 42);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete Item";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddBtn.Location = new System.Drawing.Point(69, 550);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 42);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditBtn.Location = new System.Drawing.Point(377, 550);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(119, 42);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "Edit Item";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 338);
            this.dataGridView1.TabIndex = 39;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.Width = 125;
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
            // Users_Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.AvailableTxt);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonTxt);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "Users_Admin_Form";
            this.Text = "Users-Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IdComboBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.TextBox AvailableTxt;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.TextBox SeasonTxt;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox CategoryTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Food_Ordering_SystemDataSet food_Ordering_SystemDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Food_Ordering_SystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
    }
}