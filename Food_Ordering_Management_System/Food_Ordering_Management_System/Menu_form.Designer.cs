namespace Food_Ordering_Management_System
{
    partial class Menu_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mealidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_Ordering_SystemDataSet = new Food_Ordering_Management_System.Food_Ordering_SystemDataSet();
            this.menu_itemsTableAdapter = new Food_Ordering_Management_System.Food_Ordering_SystemDataSetTableAdapters.Menu_itemsTableAdapter();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTxt = new System.Windows.Forms.TextBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonTxt = new System.Windows.Forms.TextBox();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.AvailableTxt = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealidDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.seasonDataGridViewTextBoxColumn,
            this.isavailableDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuitemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 6);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(600, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mealidDataGridViewTextBoxColumn
            // 
            this.mealidDataGridViewTextBoxColumn.DataPropertyName = "meal_id";
            this.mealidDataGridViewTextBoxColumn.HeaderText = "meal_id";
            this.mealidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mealidDataGridViewTextBoxColumn.Name = "mealidDataGridViewTextBoxColumn";
            this.mealidDataGridViewTextBoxColumn.ReadOnly = true;
            this.mealidDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "season";
            this.seasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // isavailableDataGridViewTextBoxColumn
            // 
            this.isavailableDataGridViewTextBoxColumn.DataPropertyName = "is_available";
            this.isavailableDataGridViewTextBoxColumn.HeaderText = "is_available";
            this.isavailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isavailableDataGridViewTextBoxColumn.Name = "isavailableDataGridViewTextBoxColumn";
            this.isavailableDataGridViewTextBoxColumn.ReadOnly = true;
            this.isavailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            this.adminidDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminidDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuitemsBindingSource
            // 
            this.menuitemsBindingSource.DataMember = "Menu_items";
            this.menuitemsBindingSource.DataSource = this.food_Ordering_SystemDataSet;
            // 
            // food_Ordering_SystemDataSet
            // 
            this.food_Ordering_SystemDataSet.DataSetName = "Food_Ordering_SystemDataSet";
            this.food_Ordering_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menu_itemsTableAdapter
            // 
            this.menu_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddBtn.Location = new System.Drawing.Point(75, 534);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 42);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteBtn.Location = new System.Drawing.Point(661, 534);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 42);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete Item";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditBtn.Location = new System.Drawing.Point(383, 534);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(119, 42);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit Item";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryLabel.Location = new System.Drawing.Point(319, 375);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(76, 20);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CategoryTxt.Location = new System.Drawing.Point(402, 372);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(143, 26);
            this.CategoryTxt.TabIndex = 5;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SeasonLabel.Location = new System.Drawing.Point(585, 375);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(65, 20);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Season";
            // 
            // SeasonTxt
            // 
            this.SeasonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SeasonTxt.Location = new System.Drawing.Point(675, 372);
            this.SeasonTxt.Name = "SeasonTxt";
            this.SeasonTxt.Size = new System.Drawing.Size(100, 26);
            this.SeasonTxt.TabIndex = 7;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvailableLabel.Location = new System.Drawing.Point(585, 434);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(76, 20);
            this.AvailableLabel.TabIndex = 14;
            this.AvailableLabel.Text = "Available";
            // 
            // AvailableTxt
            // 
            this.AvailableTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvailableTxt.Location = new System.Drawing.Point(675, 431);
            this.AvailableTxt.Name = "AvailableTxt";
            this.AvailableTxt.Size = new System.Drawing.Size(100, 26);
            this.AvailableTxt.TabIndex = 13;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceLabel.Location = new System.Drawing.Point(319, 434);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceTxt.Location = new System.Drawing.Point(402, 431);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(143, 26);
            this.PriceTxt.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(71, 431);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTxt.Location = new System.Drawing.Point(131, 428);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(157, 26);
            this.NameTxt.TabIndex = 9;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(71, 488);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.DescriptionLabel.TabIndex = 16;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionTxt.Location = new System.Drawing.Point(182, 482);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(593, 26);
            this.DescriptionTxt.TabIndex = 15;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdLabel.Location = new System.Drawing.Point(71, 378);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(26, 20);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "ID";
            // 
            // IdComboBox
            // 
            this.IdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(131, 378);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(157, 28);
            this.IdComboBox.TabIndex = 21;
            this.IdComboBox.Text = "Edit/Delete by ID";
            this.IdComboBox.SelectedIndexChanged += new System.EventHandler(this.IdComboBox_SelectedIndexChanged);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu_form";
            this.Text = "Menu-Admin";
            this.Load += new System.EventHandler(this.Menu_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_Ordering_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Food_Ordering_SystemDataSet food_Ordering_SystemDataSet;
        private System.Windows.Forms.BindingSource menuitemsBindingSource;
        private Food_Ordering_SystemDataSetTableAdapters.Menu_itemsTableAdapter menu_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox CategoryTxt;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.TextBox SeasonTxt;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.TextBox AvailableTxt;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ComboBox IdComboBox;
    }
}