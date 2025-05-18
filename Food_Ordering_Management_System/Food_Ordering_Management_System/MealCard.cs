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
    public partial class MealCard : UserControl
    {
        private int meal_id;
        private int user_id = 2;
        public MealCard()
        {
            InitializeComponent();
        }

        // Setters
        public void setMealName(string meal_name) => lblMealName.Text = meal_name;
        public void setMealDescription(string meal_description) => lblMealDescription.Text = meal_description;
        public void setMealCategory(string meal_category) => lblMealCategory.Text = meal_category;
        public void setMealAvailable(char meal_available) => lblMealAvailable.Text = (meal_available == 'Y') ? "Yes" : "No";
        public void setMealSeason(string meal_season) => lblMealSeason.Text = meal_season;
        public void setMealPrice(decimal meal_price) => lblMealPrice.Text = meal_price.ToString("C"); // Currency format
        public void setMealId(int mealId) => meal_id =  mealId;

        // Getters
        public string getMealName() => lblMealName.Text;
        public string getMealDescription() => lblMealDescription.Text;
        public string getMealCategory() => lblMealCategory.Text;
        public string getMealAvailable() => lblMealAvailable.Text;
        public string getMealSeason() => lblMealSeason.Text;
        public decimal getMealPrice() => decimal.TryParse(lblMealPrice.Text, System.Globalization.NumberStyles.Currency, null, out var val) ? val : 0;
        public int getMealId() => meal_id;

        public void setFavoriteBtn()
        {
            int meal_id = getMealId();
            if (meal_id <= 0)
            {
                MessageBox.Show("Invalid meal selection");
                return;
            }

            if (user_id <= 0)
            {
                MessageBox.Show("Please login first");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                try
                {
                    sqlConnection.Open();

                    // Check if already favorited
                    string checkQuery = "SELECT COUNT(1) FROM customer_favorites WHERE customer_id = @customer_id AND meal_id = @meal_id";
                    bool alreadyFavorited;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, sqlConnection))
                    {
                        checkCmd.Parameters.AddWithValue("@customer_id", user_id);
                        checkCmd.Parameters.AddWithValue("@meal_id", meal_id);
                        alreadyFavorited = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    
                    btnAddFavorite.Text = alreadyFavorited ? "♥": "♡";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void btnAddFavorite_Click(object sender, EventArgs e)
        {

            // Get meal ID and user ID
            int meal_id = getMealId();
            if (meal_id <= 0)
            {
                MessageBox.Show("Invalid meal selection");
                return;
            }

            if (user_id <= 0)
            {
                MessageBox.Show("Please login first");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                try
                {
                    sqlConnection.Open();  

                    // Check if already favorited
                    string checkQuery = "SELECT COUNT(1) FROM customer_favorites WHERE customer_id = @customer_id AND meal_id = @meal_id";
                    bool alreadyFavorited;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, sqlConnection))
                    {
                        checkCmd.Parameters.AddWithValue("@customer_id", user_id);
                        checkCmd.Parameters.AddWithValue("@meal_id", meal_id);
                        alreadyFavorited = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    // Toggle favorite status
                    string operationQuery = alreadyFavorited
                        ? "DELETE FROM customer_favorites WHERE customer_id = @customer_id AND meal_id = @meal_id"
                        : "INSERT INTO customer_favorites (customer_id, meal_id) VALUES (@customer_id, @meal_id)";

                    using (SqlCommand cmd = new SqlCommand(operationQuery, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", user_id);
                        cmd.Parameters.AddWithValue("@meal_id", meal_id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            btnAddFavorite.Text = alreadyFavorited ? "♡" : "♥";
                            MessageBox.Show(alreadyFavorited ? "Removed from favorites" : "Added to favorites!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (Globals.User_Cart.TryGetValue(meal_id, out int currentQty))
                Globals.User_Cart[meal_id] = currentQty + 1;
            else
                Globals.User_Cart.Add(meal_id, 1);

        }
    }
}
