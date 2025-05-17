namespace Food_Ordering_Management_System
{
    partial class MealCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMealName = new System.Windows.Forms.Label();
            this.lblMealDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMealCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMealSeason = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMealAvailable = new System.Windows.Forms.Label();
            this.lblMealPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMealName
            // 
            this.lblMealName.AutoSize = true;
            this.lblMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealName.Location = new System.Drawing.Point(3, -1);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(202, 38);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "Beef Burger";
            // 
            // lblMealDescription
            // 
            this.lblMealDescription.AutoSize = true;
            this.lblMealDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMealDescription.Location = new System.Drawing.Point(6, 37);
            this.lblMealDescription.Name = "lblMealDescription";
            this.lblMealDescription.Size = new System.Drawing.Size(259, 22);
            this.lblMealDescription.TabIndex = 1;
            this.lblMealDescription.Text = "Grilled beef burger with cheese";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category:";
            // 
            // lblMealCategory
            // 
            this.lblMealCategory.AutoSize = true;
            this.lblMealCategory.Location = new System.Drawing.Point(69, 65);
            this.lblMealCategory.Name = "lblMealCategory";
            this.lblMealCategory.Size = new System.Drawing.Size(82, 16);
            this.lblMealCategory.TabIndex = 3;
            this.lblMealCategory.Text = "Main Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(157, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Season:";
            // 
            // lblMealSeason
            // 
            this.lblMealSeason.AutoSize = true;
            this.lblMealSeason.Location = new System.Drawing.Point(220, 90);
            this.lblMealSeason.Name = "lblMealSeason";
            this.lblMealSeason.Size = new System.Drawing.Size(45, 16);
            this.lblMealSeason.TabIndex = 5;
            this.lblMealSeason.Text = "Winter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available:";
            // 
            // lblMealAvailable
            // 
            this.lblMealAvailable.AutoSize = true;
            this.lblMealAvailable.Location = new System.Drawing.Point(69, 90);
            this.lblMealAvailable.Name = "lblMealAvailable";
            this.lblMealAvailable.Size = new System.Drawing.Size(34, 16);
            this.lblMealAvailable.TabIndex = 7;
            this.lblMealAvailable.Text = "YES";
            // 
            // lblMealPrice
            // 
            this.lblMealPrice.AutoSize = true;
            this.lblMealPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPrice.Location = new System.Drawing.Point(410, 21);
            this.lblMealPrice.Name = "lblMealPrice";
            this.lblMealPrice.Size = new System.Drawing.Size(98, 38);
            this.lblMealPrice.TabIndex = 9;
            this.lblMealPrice.Text = "25.00";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(407, 65);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(158, 41);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // MealCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblMealPrice);
            this.Controls.Add(this.lblMealAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMealSeason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMealCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMealDescription);
            this.Controls.Add(this.lblMealName);
            this.Name = "MealCard";
            this.Size = new System.Drawing.Size(578, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealName;
        private System.Windows.Forms.Label lblMealDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMealSeason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMealAvailable;
        private System.Windows.Forms.Label lblMealPrice;
        private System.Windows.Forms.Button btnOrder;
    }
}
