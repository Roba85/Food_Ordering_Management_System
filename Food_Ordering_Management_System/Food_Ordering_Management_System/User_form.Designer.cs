namespace Food_Ordering_Management_System
{
    partial class User_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBAutocomplete = new System.Windows.Forms.ListBox();
            this.TBMenuSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFullMenu = new System.Windows.Forms.Button();
            this.flowLayoutMeals = new System.Windows.Forms.FlowLayoutPanel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBMinPrice = new System.Windows.Forms.TextBox();
            this.TBMaxPrice = new System.Windows.Forms.TextBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.btnMainCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Ordering System";
            // 
            // LBAutocomplete
            // 
            this.LBAutocomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAutocomplete.FormattingEnabled = true;
            this.LBAutocomplete.ItemHeight = 25;
            this.LBAutocomplete.Location = new System.Drawing.Point(33, 148);
            this.LBAutocomplete.Name = "LBAutocomplete";
            this.LBAutocomplete.Size = new System.Drawing.Size(608, 79);
            this.LBAutocomplete.TabIndex = 6;
            this.LBAutocomplete.SelectedIndexChanged += new System.EventHandler(this.LBAutocomplete_SelectedIndexChanged);
            // 
            // TBMenuSearch
            // 
            this.TBMenuSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMenuSearch.Location = new System.Drawing.Point(33, 118);
            this.TBMenuSearch.Name = "TBMenuSearch";
            this.TBMenuSearch.Size = new System.Drawing.Size(609, 30);
            this.TBMenuSearch.TabIndex = 7;
            this.TBMenuSearch.TextChanged += new System.EventHandler(this.TBMenuSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for dishes";
            // 
            // btnFullMenu
            // 
            this.btnFullMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullMenu.Location = new System.Drawing.Point(678, 587);
            this.btnFullMenu.Name = "btnFullMenu";
            this.btnFullMenu.Size = new System.Drawing.Size(163, 34);
            this.btnFullMenu.TabIndex = 14;
            this.btnFullMenu.Text = "Full Menu";
            this.btnFullMenu.UseVisualStyleBackColor = true;
            this.btnFullMenu.Click += new System.EventHandler(this.btnFullMenu_Click);
            // 
            // flowLayoutMeals
            // 
            this.flowLayoutMeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutMeals.Location = new System.Drawing.Point(29, 244);
            this.flowLayoutMeals.Name = "flowLayoutMeals";
            this.flowLayoutMeals.Size = new System.Drawing.Size(613, 377);
            this.flowLayoutMeals.TabIndex = 15;
            // 
            // picProfile
            // 
            this.picProfile.Image = global::Food_Ordering_Management_System.Properties.Resources.user__2_;
            this.picProfile.Location = new System.Drawing.Point(791, 12);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(50, 63);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 1;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.Location = new System.Drawing.Point(678, 546);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(163, 34);
            this.btnClearFilters.TabIndex = 17;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Min price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(771, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Max price";
            // 
            // TBMinPrice
            // 
            this.TBMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMinPrice.Location = new System.Drawing.Point(656, 427);
            this.TBMinPrice.Name = "TBMinPrice";
            this.TBMinPrice.Size = new System.Drawing.Size(83, 30);
            this.TBMinPrice.TabIndex = 21;
            this.TBMinPrice.TextChanged += new System.EventHandler(this.TBMinPrice_TextChanged);
            // 
            // TBMaxPrice
            // 
            this.TBMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMaxPrice.Location = new System.Drawing.Point(781, 427);
            this.TBMaxPrice.Name = "TBMaxPrice";
            this.TBMaxPrice.Size = new System.Drawing.Size(86, 30);
            this.TBMaxPrice.TabIndex = 22;
            this.TBMaxPrice.TextChanged += new System.EventHandler(this.TBMaxPrice_TextChanged);
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilters.Location = new System.Drawing.Point(678, 506);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(163, 34);
            this.btnApplyFilters.TabIndex = 23;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "-";
            // 
            // btnDessert
            // 
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.Location = new System.Drawing.Point(678, 299);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(163, 34);
            this.btnDessert.TabIndex = 29;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.Location = new System.Drawing.Point(678, 339);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(163, 34);
            this.btnDrink.TabIndex = 30;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.SystemColors.Control;
            this.btnAppetizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.Location = new System.Drawing.Point(678, 219);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Size = new System.Drawing.Size(163, 34);
            this.btnAppetizer.TabIndex = 31;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.UseVisualStyleBackColor = false;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.BackColor = System.Drawing.SystemColors.Control;
            this.btnMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCourse.Location = new System.Drawing.Point(678, 259);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Size = new System.Drawing.Size(163, 34);
            this.btnMainCourse.TabIndex = 32;
            this.btnMainCourse.Text = "Main Course";
            this.btnMainCourse.UseVisualStyleBackColor = false;
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
            // 
            // User_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnMainCourse);
            this.Controls.Add(this.btnAppetizer);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnApplyFilters);
            this.Controls.Add(this.TBMaxPrice);
            this.Controls.Add(this.TBMinPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.flowLayoutMeals);
            this.Controls.Add(this.btnFullMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBMenuSearch);
            this.Controls.Add(this.LBAutocomplete);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.label1);
            this.Name = "User_form";
            this.Text = "User_form";
            this.Load += new System.EventHandler(this.User_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.ListBox LBAutocomplete;
        private System.Windows.Forms.TextBox TBMenuSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFullMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMeals;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBMinPrice;
        private System.Windows.Forms.TextBox TBMaxPrice;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnMainCourse;
    }
}