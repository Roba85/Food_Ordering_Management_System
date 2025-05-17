namespace Food_Ordering_Management_System
{
    partial class test
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
            System.Windows.Forms.Label meal_idLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label seasonLabel;
            System.Windows.Forms.Label is_availableLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label admin_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.food_ordering_systemDataSet = new Food_Ordering_Management_System.Food_ordering_systemDataSet();
            this.menu_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu_itemsTableAdapter = new Food_Ordering_Management_System.Food_ordering_systemDataSetTableAdapters.Menu_itemsTableAdapter();
            this.tableAdapterManager = new Food_Ordering_Management_System.Food_ordering_systemDataSetTableAdapters.TableAdapterManager();
            this.menu_itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.meal_idTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.seasonTextBox = new System.Windows.Forms.TextBox();
            this.is_availableTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.admin_idTextBox = new System.Windows.Forms.TextBox();
            this.fKcustomermeal46E78A0CBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_favoritesTableAdapter = new Food_Ordering_Management_System.Food_ordering_systemDataSetTableAdapters.customer_favoritesTableAdapter();
            this.menu_itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            meal_idLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            seasonLabel = new System.Windows.Forms.Label();
            is_availableLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            admin_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.food_ordering_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsBindingNavigator)).BeginInit();
            this.menu_itemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKcustomermeal46E78A0CBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // meal_idLabel
            // 
            meal_idLabel.AutoSize = true;
            meal_idLabel.Location = new System.Drawing.Point(11, 43);
            meal_idLabel.Name = "meal_idLabel";
            meal_idLabel.Size = new System.Drawing.Size(54, 16);
            meal_idLabel.TabIndex = 1;
            meal_idLabel.Text = "meal id:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(11, 71);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(63, 16);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "category:";
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Location = new System.Drawing.Point(11, 99);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new System.Drawing.Size(55, 16);
            seasonLabel.TabIndex = 5;
            seasonLabel.Text = "season:";
            // 
            // is_availableLabel
            // 
            is_availableLabel.AutoSize = true;
            is_availableLabel.Location = new System.Drawing.Point(11, 127);
            is_availableLabel.Name = "is_availableLabel";
            is_availableLabel.Size = new System.Drawing.Size(79, 16);
            is_availableLabel.TabIndex = 7;
            is_availableLabel.Text = "is available:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(11, 155);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(40, 16);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "price:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 183);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 211);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(76, 16);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "description:";
            // 
            // admin_idLabel
            // 
            admin_idLabel.AutoSize = true;
            admin_idLabel.Location = new System.Drawing.Point(11, 239);
            admin_idLabel.Name = "admin_idLabel";
            admin_idLabel.Size = new System.Drawing.Size(61, 16);
            admin_idLabel.TabIndex = 15;
            admin_idLabel.Text = "admin id:";
            // 
            // food_ordering_systemDataSet
            // 
            this.food_ordering_systemDataSet.DataSetName = "Food_ordering_systemDataSet";
            this.food_ordering_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menu_itemsBindingSource
            // 
            this.menu_itemsBindingSource.DataMember = "Menu_items";
            this.menu_itemsBindingSource.DataSource = this.food_ordering_systemDataSet;
            // 
            // menu_itemsTableAdapter
            // 
            this.menu_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.customer_favoritesTableAdapter = null;
            this.tableAdapterManager.Customer_phonesTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FeedbackTableAdapter = null;
            this.tableAdapterManager.Menu_itemsTableAdapter = this.menu_itemsTableAdapter;
            this.tableAdapterManager.Order_itemsTableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Food_Ordering_Management_System.Food_ordering_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menu_itemsBindingNavigator
            // 
            this.menu_itemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menu_itemsBindingNavigator.BindingSource = this.menu_itemsBindingSource;
            this.menu_itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menu_itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menu_itemsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.menu_itemsBindingNavigatorSaveItem});
            this.menu_itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menu_itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menu_itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menu_itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menu_itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menu_itemsBindingNavigator.Name = "menu_itemsBindingNavigator";
            this.menu_itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menu_itemsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.menu_itemsBindingNavigator.TabIndex = 0;
            this.menu_itemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // menu_itemsBindingNavigatorSaveItem
            // 
            this.menu_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu_itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menu_itemsBindingNavigatorSaveItem.Image")));
            this.menu_itemsBindingNavigatorSaveItem.Name = "menu_itemsBindingNavigatorSaveItem";
            this.menu_itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.menu_itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.menu_itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.menu_itemsBindingNavigatorSaveItem_Click);
            // 
            // meal_idTextBox
            // 
            this.meal_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "meal_id", true));
            this.meal_idTextBox.Location = new System.Drawing.Point(96, 40);
            this.meal_idTextBox.Name = "meal_idTextBox";
            this.meal_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.meal_idTextBox.TabIndex = 2;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(96, 68);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoryTextBox.TabIndex = 4;
            // 
            // seasonTextBox
            // 
            this.seasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "season", true));
            this.seasonTextBox.Location = new System.Drawing.Point(96, 99);
            this.seasonTextBox.Name = "seasonTextBox";
            this.seasonTextBox.Size = new System.Drawing.Size(100, 22);
            this.seasonTextBox.TabIndex = 6;
            // 
            // is_availableTextBox
            // 
            this.is_availableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "is_available", true));
            this.is_availableTextBox.Location = new System.Drawing.Point(96, 124);
            this.is_availableTextBox.Name = "is_availableTextBox";
            this.is_availableTextBox.Size = new System.Drawing.Size(100, 22);
            this.is_availableTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(96, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(96, 180);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(96, 208);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // admin_idTextBox
            // 
            this.admin_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_itemsBindingSource, "admin_id", true));
            this.admin_idTextBox.Location = new System.Drawing.Point(96, 236);
            this.admin_idTextBox.Name = "admin_idTextBox";
            this.admin_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.admin_idTextBox.TabIndex = 16;
            // 
            // fKcustomermeal46E78A0CBindingSource
            // 
            this.fKcustomermeal46E78A0CBindingSource.DataMember = "FK__customer___meal___46E78A0C";
            this.fKcustomermeal46E78A0CBindingSource.DataSource = this.menu_itemsBindingSource;
            // 
            // customer_favoritesTableAdapter
            // 
            this.customer_favoritesTableAdapter.ClearBeforeFill = true;
            // 
            // menu_itemsDataGridView
            // 
            this.menu_itemsDataGridView.AutoGenerateColumns = false;
            this.menu_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu_itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.menu_itemsDataGridView.DataSource = this.menu_itemsBindingSource;
            this.menu_itemsDataGridView.Location = new System.Drawing.Point(14, 282);
            this.menu_itemsDataGridView.Name = "menu_itemsDataGridView";
            this.menu_itemsDataGridView.RowHeadersWidth = 51;
            this.menu_itemsDataGridView.RowTemplate.Height = 24;
            this.menu_itemsDataGridView.Size = new System.Drawing.Size(670, 220);
            this.menu_itemsDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "meal_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "meal_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn2.HeaderText = "category";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "season";
            this.dataGridViewTextBoxColumn3.HeaderText = "season";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "is_available";
            this.dataGridViewTextBoxColumn4.HeaderText = "is_available";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "description";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "admin_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "admin_id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(470, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 84);
            this.listBox1.TabIndex = 18;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menu_itemsDataGridView);
            this.Controls.Add(meal_idLabel);
            this.Controls.Add(this.meal_idTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(seasonLabel);
            this.Controls.Add(this.seasonTextBox);
            this.Controls.Add(is_availableLabel);
            this.Controls.Add(this.is_availableTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(admin_idLabel);
            this.Controls.Add(this.admin_idTextBox);
            this.Controls.Add(this.menu_itemsBindingNavigator);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.food_ordering_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsBindingNavigator)).EndInit();
            this.menu_itemsBindingNavigator.ResumeLayout(false);
            this.menu_itemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKcustomermeal46E78A0CBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Food_ordering_systemDataSet food_ordering_systemDataSet;
        private System.Windows.Forms.BindingSource menu_itemsBindingSource;
        private Food_ordering_systemDataSetTableAdapters.Menu_itemsTableAdapter menu_itemsTableAdapter;
        private Food_ordering_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menu_itemsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton menu_itemsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox meal_idTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox seasonTextBox;
        private System.Windows.Forms.TextBox is_availableTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox admin_idTextBox;
        private System.Windows.Forms.BindingSource fKcustomermeal46E78A0CBindingSource;
        private Food_ordering_systemDataSetTableAdapters.customer_favoritesTableAdapter customer_favoritesTableAdapter;
        private System.Windows.Forms.DataGridView menu_itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ListBox listBox1;
    }
}