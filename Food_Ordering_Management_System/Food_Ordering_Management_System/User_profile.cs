using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Management_System
{
    public partial class User_profile : Form
    {
        private int user_id = 2;
        public User_profile()
        {
            InitializeComponent();
            LoadProgileInfo();
            LoadFavorites();
            LoadOrders();
            LoadFeedbacks();
        }

        public void LoadProgileInfo()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
                {
                    sqlConnection.Open();

                    String query = @"SELECT customer_name, email, address, phone FROM Customer, Customer_phones WHERE Customer.customer_id = @user_id
                                    AND Customer_phones.customer_id = @user_id";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            TBUsername.Text = reader["customer_name"].ToString();
                            TBEmail.Text = reader["email"].ToString();
                            TBAddress.Text = reader["address"].ToString();
                            TBPhone.Text = reader["phone"].ToString();
                        }
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Make sure you are loggin in first");
            }

        }

        public void LoadFavorites()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                String query = $@"SELECT meal_id, category, season, is_available, price, name, description 
                                FROM Menu_items
                                WHERE meal_id IN (SELECT meal_id FROM customer_favorites WHERE customer_id = @user_id)";

                using (SqlCommand cmd =  new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    sqlConnection.Open();

                    User_form User_form = new User_form();

                    User_form.LoadMealsFromDatabase(cmd, flowLayoutFavorite);
                }
            }

        }

        public void LoadOrders()
        {
            flowLayoutOrders.Controls.Clear();

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();

                int lastOrderId = 0;   
                const string lastOrderSql = @" SELECT TOP 1 order_id
                                                FROM   Order_
                                                WHERE  customer_id = @user_id
                                                ORDER BY order_id DESC;";

                using (var lastCmd = new SqlCommand(lastOrderSql, sqlConnection))
                {
                    lastCmd.Parameters.AddWithValue("@user_id", user_id);
                    object result = lastCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        lastOrderId = Convert.ToInt32(result);
                }

                const string ordersSql = @" SELECT order_id, total
                                            FROM   Order_
                                            WHERE  customer_id = @user_id
                                            ORDER BY order_id DESC;";      

                using (var cmd = new SqlCommand(ordersSql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderCard card = new OrderCard();

                            int orderId = Convert.ToInt32(reader["order_id"]);
                            decimal total = Convert.ToDecimal(reader["total"]);

                            card.setOrderId(orderId);
                            card.setLblPrice(total);
                            card.orderDeleted += removeOrder;
                            card.addFeedback += addEmptyFeedbackPanel;

                            if (orderId != lastOrderId)
                                card.hideCancelBtn();

                            flowLayoutOrders.Controls.Add(card);
                        }
                    }
                }
            }

        }

        public void LoadFeedbacks()
        {
            flowLayoutFeedback.Controls.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                String query = $@"SELECT feedback_id, data, rate, review
                                FROM Feedback
                                WHERE customer_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    sqlConnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int feedBack_id = Convert.ToInt32(reader["feedback_id"]);

                            // Create a Panel for each feedback
                            Panel feedbackPanel = new Panel();
                            feedbackPanel.Width = flowLayoutFeedback.ClientSize.Width - 25;
                            feedbackPanel.Height = 80;
                            feedbackPanel.BorderStyle = BorderStyle.FixedSingle;
                            feedbackPanel.Margin = new Padding(3);

                            // Review textbox (editable)
                            TextBox txtReview = new TextBox();
                            txtReview.Multiline = true;
                            txtReview.Width = feedbackPanel.Width - 150;
                            txtReview.Height = 50;
                            txtReview.Text = reader["review"].ToString();
                            txtReview.Location = new Point(5, 5);

                            // Rate numeric up-down (editable)
                            NumericUpDown numRate = new NumericUpDown();
                            numRate.Minimum = 1;
                            numRate.Maximum = 5;
                            numRate.Value = Convert.ToDecimal(reader["rate"]);
                            numRate.Location = new Point(txtReview.Right + 5, 5);

                            // Date label (read-only)
                            Label lblDate = new Label();
                            lblDate.Text = Convert.ToDateTime(reader["data"]).ToShortDateString();
                            lblDate.Location = new Point(txtReview.Right + 5, numRate.Bottom + 5);

                            // Save button
                            Button btnSave = new Button();
                            btnSave.Text = "Save";
                            btnSave.Location = new Point(txtReview.Right + 5, lblDate.Bottom + 5);

                            // Delete button
                            Button btnDelete = new Button();
                            btnDelete.Text = "Delete";
                            btnDelete.Location = new Point(btnSave.Right + 5, lblDate.Bottom + 5);

                            // Add controls to panel
                            feedbackPanel.Controls.Add(txtReview);
                            feedbackPanel.Controls.Add(numRate);
                            feedbackPanel.Controls.Add(lblDate);
                            feedbackPanel.Controls.Add(btnSave);
                            feedbackPanel.Controls.Add(btnDelete);

                            flowLayoutFeedback.Controls.Add(feedbackPanel);

                            
                            btnSave.Click += (s, e) =>
                            {
                                UpdateFeedback(feedBack_id, txtReview.Text, (int)numRate.Value);
                            };

                            btnDelete.Click += (s, e) =>
                            {
                                var confirm = MessageBox.Show("Are you sure you want to delete this feedback?", "Confirm Delete", MessageBoxButtons.YesNo);
                                if (confirm == DialogResult.Yes)
                                {
                                    DeleteFeedback(feedBack_id);
                                    flowLayoutFeedback.Controls.Remove(feedbackPanel);
                                }
                            };
                        }

                    }
                }
            }
        }

        private void addEmptyFeedbackPanel()
        {
            Panel feedbackPanel = new Panel();
            feedbackPanel.Width = flowLayoutFeedback.ClientSize.Width - 25;
            feedbackPanel.Height = 80;
            feedbackPanel.BorderStyle = BorderStyle.FixedSingle;
            feedbackPanel.Margin = new Padding(3);

            // Empty review textbox
            TextBox txtReview = new TextBox();
            txtReview.Multiline = true;
            txtReview.Width = feedbackPanel.Width - 150;
            txtReview.Height = 50;
            txtReview.Location = new Point(5, 5);

            // Rate numeric up-down
            NumericUpDown numRate = new NumericUpDown();
            numRate.Minimum = 1;
            numRate.Maximum = 5;
            numRate.Value = 3; // default rating
            numRate.Location = new Point(txtReview.Right + 5, 5);

            // Date label (show current date for new feedback)
            Label lblDate = new Label();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDate.Location = new Point(txtReview.Right + 5, numRate.Bottom + 5);

            // Add button
            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(txtReview.Right + 5, lblDate.Bottom + 5);

            feedbackPanel.Controls.Add(txtReview);
            feedbackPanel.Controls.Add(numRate);
            feedbackPanel.Controls.Add(lblDate);
            feedbackPanel.Controls.Add(btnAdd);

            flowLayoutFeedback.Controls.Add(feedbackPanel);

            btnAdd.Click += (s, e) =>
            {
                // Validate input if you want
                if (string.IsNullOrWhiteSpace(txtReview.Text))
                {
                    MessageBox.Show("Review cannot be empty.");
                    return;
                }

                addFeedback(txtReview.Text, (int)numRate.Value);

                // Remove the empty add panel after adding
                flowLayoutFeedback.Controls.Remove(feedbackPanel);

                // Optionally reload all feedbacks or just add this to UI dynamically
                LoadFeedbacks();
            };
        }

        private void addFeedback(string review, int rate)
        { 

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();

                string sql = @"INSERT INTO Feedback (customer_id, review, rate, data) 
                       VALUES (@user_id, @review, @rate, @date)";

                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@review", review);
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Feedback added successfully.");
        }


        private void UpdateFeedback(int feedbackId, string review, int rate)
        {
            using (SqlConnection conn = new SqlConnection(Globals.ConnectionStirng))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Feedback SET review = @review, rate = @rate WHERE feedback_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@review", review);
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.Parameters.AddWithValue("@id", feedbackId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Feedback updated.");
        }

        private void DeleteFeedback(int feedbackId)
        {
            using (SqlConnection conn = new SqlConnection(Globals.ConnectionStirng))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Feedback WHERE feedback_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", feedbackId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Feedback deleted.");
        }


        private void removeOrder(int order_id)
        {
            var item = flowLayoutOrders.Controls
                        .OfType<OrderCard>()
                        .FirstOrDefault(i => i.getOrderId() == order_id);

            if (item != null)
            {
                flowLayoutOrders.Controls.Remove(item);
                item.Dispose();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Form user_form = new User_form();
            user_form.Show();
            this.Hide();
        }
    }
}
