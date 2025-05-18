using Food_Ordering_Management_System.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Food_Ordering_Management_System
{
    public partial class User_form : Form
    {
        private List<String> categories = new List<string>();

        public User_form()
        {
            InitializeComponent();

            TBMenuSearch.Leave += TBMenuSearch_Leave;
            TBMenuSearch.KeyDown += TBMenuSearch_KeyDown;
            LBAutocomplete.Visible = false;
            
        }
        private void User_form_Load(object sender, EventArgs e)
        {
            InitialLoadMealsFromDatabase();
        }

        public void TBMenuSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
                {
                    sqlConnection.Open();
                    btnClearFilters_Click(sender, e);
                    String searchText = TBMenuSearch.Text;

                    String query = "SELECT meal_id, category, season, is_available, price, name, description FROM Menu_items WHERE is_available = 'Y' AND name LIKE @meal_name";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@meal_name", "%" + searchText + "%");
                        LoadMealsFromDatabase(cmd, flowLayoutMeals);
                    }
                }
                Console.WriteLine("HI!");
            }
        }

        private void TBMenuSearch_Leave(object sender, EventArgs e)
        {
            if (!LBAutocomplete.Focused)
                LBAutocomplete.Visible = false;
        }

        private void TBMenuSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();
                String searchText = TBMenuSearch.Text;

                String query = "SELECT name FROM Menu_items WHERE name LIKE @meal_name";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@meal_name", "%" + searchText + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            LBAutocomplete.Items.Clear();
                            LBAutocomplete.Visible = true;
                        }
                        else
                        {
                            LBAutocomplete.Visible = false;
                        }

                        while (reader.Read())
                        {
                            LBAutocomplete.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void InitialLoadMealsFromDatabase()
        {
            try
            {
                flowLayoutMeals.Controls.Clear();
                string query = "SELECT meal_id, category, season, is_available, price, name, description FROM Menu_items WHERE is_available = 'Y'";

                using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var mealCard = new MealCard();
                            mealCard.setMealCategory(reader["category"].ToString());
                            mealCard.setMealSeason(reader["season"].ToString());
                            mealCard.setMealAvailable(reader["is_available"].ToString()[0]);
                            mealCard.setMealPrice(Convert.ToDecimal(reader["price"]));
                            mealCard.setMealName(reader["name"].ToString());
                            mealCard.setMealDescription(reader["description"].ToString());
                            mealCard.setMealId(Convert.ToInt32(reader["meal_id"]));
                            mealCard.setFavoriteBtn();
                            flowLayoutMeals.Controls.Add(mealCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
        }

        public void LoadMealsFromDatabase(SqlCommand cmd, FlowLayoutPanel flowLayoutMeals)
        {
            try
            {
                flowLayoutMeals.Controls.Clear();
                using (SqlConnection sqlConnection = cmd.Connection)
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Label message = new Label();
                        message.Text = "Sorry we don't have the meal that you are looking for!";
                        message.Font = new Font("Arial", 12, FontStyle.Bold);
                        message.ForeColor = SystemColors.ControlDarkDark;
                        message.AutoSize = true;
                        flowLayoutMeals.Controls.Add(message);
                    }

                    while (reader.Read())
                    {
                        var mealCard = new MealCard();
                        mealCard.setMealCategory(reader["category"].ToString());
                        mealCard.setMealSeason(reader["season"].ToString());
                        mealCard.setMealAvailable(reader["is_available"].ToString()[0]);
                        mealCard.setMealPrice(Convert.ToDecimal(reader["price"]));
                        mealCard.setMealName(reader["name"].ToString());
                        mealCard.setMealDescription(reader["description"].ToString());
                        mealCard.setMealId(Convert.ToInt32(reader["meal_id"]));
                        mealCard.setFavoriteBtn();
                        flowLayoutMeals.Controls.Add(mealCard);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            decimal minPrice = decimal.TryParse(TBMinPrice.Text, out decimal minPriceInput) ? minPriceInput : 0;
            decimal maxPrice = decimal.TryParse(TBMaxPrice.Text, out decimal maxPriceInput) ? maxPriceInput : 100000;

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();
                string query;
                SqlCommand cmd;

                if (categories.Count == 0)
                {
                    query = @"SELECT meal_id, category, season, is_available, price, name, description 
                            FROM Menu_items
                            WHERE is_available = 'Y'
                            AND price >= @minPrice
                            AND price <= @maxPrice";
                    cmd = new SqlCommand(query, sqlConnection);
                }
                else
                {
                    var paramNames = categories.Select((cat, index) => $"@cat{index}").ToList();
                    query = $@"SELECT meal_id, category, season, is_available, price, name, description 
                            FROM Menu_items
                            WHERE is_available = 'Y'
                            AND category IN ({string.Join(",", paramNames)})
                            AND price >= @minPrice
                            AND price <= @maxPrice";

                    cmd = new SqlCommand(query, sqlConnection);
                    for (int i = 0; i < categories.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(paramNames[i], categories[i]);
                    }
                }

                cmd.Parameters.AddWithValue("@minPrice", minPrice);
                cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                LoadMealsFromDatabase(cmd, flowLayoutMeals);
            }
        }

        private void TBMinPrice_TextChanged(object sender, EventArgs e)
        {
            validate_Price(TBMinPrice);
        }
        private void TBMaxPrice_TextChanged(object sender, EventArgs e)
        {
            validate_Price(TBMaxPrice);
        }

        private void validate_Price(System.Windows.Forms.TextBox TB)
        {
            try
            {
                String price = TB.Text;

                if (price.Contains("."))
                {
                    String dollars = price.Split('.')[0];
                    String cents = price.Split('.')[1];

                    decimal decimal_dollars = Convert.ToDecimal(dollars);
                    if (cents != "")
                    {
                        decimal decimal_cents = Convert.ToDecimal(cents);
                    }
                }
                else
                {
                    decimal decimal_min_price = Convert.ToDecimal(price);
                }
            }
            catch
            {
                if (TB.Text == "") return;
                MessageBox.Show("This is an invalid price !");
                TB.Text = TB.Text.Substring(0, TB.Text.Length - 1);
                TB.SelectionStart = TB.Text.Length;
            }
        }
        private void LBAutocomplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBAutocomplete.SelectedItem != null)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
                {
                    sqlConnection.Open();
                    btnClearFilters_Click(sender, e);
                    String searchText = LBAutocomplete.SelectedItem.ToString();

                    String query = "SELECT meal_id, category, season, is_available, price, name, description FROM Menu_items WHERE is_available = 'Y' AND name LIKE @meal_name";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@meal_name", "%" + searchText + "%");
                        LoadMealsFromDatabase(cmd, flowLayoutMeals);
                    }
                }
            }
        }

        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            btnAppetizer.BackColor = SystemColors.ControlDark;
            categories.Add("Appetizer");
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            btnMainCourse.BackColor = SystemColors.ControlDark;
            categories.Add("Main Course");
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            btnDessert.BackColor = SystemColors.ControlDark;
            categories.Add("Dessert");
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            btnDrink.BackColor = SystemColors.ControlDark;
            categories.Add("Drink");
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            btnAppetizer.BackColor = SystemColors.Control;
            btnMainCourse.BackColor = SystemColors.Control;
            btnDessert.BackColor = SystemColors.Control;
            btnDrink.BackColor = SystemColors.Control;

            categories.Clear();

            TBMinPrice.Clear();
            TBMaxPrice.Clear();

            InitialLoadMealsFromDatabase();
        }

        private void btnFullMenu_Click(object sender, EventArgs e)
        {
            InitialLoadMealsFromDatabase();
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            Form User_profile_form = new User_profile();
            User_profile_form.Show();
            this.Hide();
        }

        private void picCart_Click(object sender, EventArgs e)
        {
            Form Cart_form = new Cart();
            Cart_form.Show();
            this.Hide();
        }
    }
}