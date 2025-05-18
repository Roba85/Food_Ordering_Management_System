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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            Globals.User_id = 1;
            // TODO: This line of code loads data into the 'food_Ordering_SystemDataSet.Menu_items' table. You can move, or remove it, as needed.
            this.menu_itemsTableAdapter.Fill(this.food_Ordering_SystemDataSet.Menu_items);
            dataGridView1.DataSource = food_Ordering_SystemDataSet.Menu_items;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Refresh();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Name = col.DataPropertyName;
                if (col.DataPropertyName == "admin_id")
                {
                    col.Visible = false;
                }
            }

            // Modifying column names for display
            dataGridView1.Columns["meal_id"].HeaderText = "ID";
            dataGridView1.Columns["price"].HeaderText = "Price";
            dataGridView1.Columns["category"].HeaderText = "Category";
            dataGridView1.Columns["season"].HeaderText = "Season";
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["is_available"].HeaderText = "Available";
            dataGridView1.Columns["description"].HeaderText = "Description";

            // Modifying column order
            dataGridView1.Columns["meal_id"].DisplayIndex = 0;
            dataGridView1.Columns["name"].DisplayIndex = 1;
            dataGridView1.Columns["description"].DisplayIndex = 2;
            dataGridView1.Columns["category"].DisplayIndex = 3;
            dataGridView1.Columns["season"].DisplayIndex = 4;
            dataGridView1.Columns["is_available"].DisplayIndex = 5;
            dataGridView1.Columns["price"].DisplayIndex = 6;

            PopulateIDComboBox();

        }

        private void PopulateIDComboBox()
        {
            string sql = "SELECT meal_id FROM Menu_items ORDER BY meal_id";
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            DataRow noneRow = dt.NewRow();
            noneRow["meal_id"] = DBNull.Value;
            dt.Rows.InsertAt(noneRow, 0);

            IdComboBox.DataSource = dt;
            IdComboBox.DisplayMember = "ID";
            IdComboBox.ValueMember = "meal_id";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private Char GetAvailableText()
        {
            String s = AvailableTxt.Text;
            
            if (s.ToUpper() == "Y" || s.ToUpper() == "YES")
                return 'Y';
            else if (s.ToUpper() == "N" || s.ToUpper() == "NO")
                return 'N';
            else throw new Exception("Available text field is incorrect");
              
        }

        private bool EmptyFieldCheck()
        {

            if (NameTxt.Text.Length == 0 || AvailableTxt.Text.Length == 0 
                || CategoryTxt.Text.Length == 0 || SeasonTxt.Text.Length == 0
                || PriceTxt.Text.Length == 0 || DescriptionTxt.Text.Length == 0)
                return true;
            return false;
             
        }
        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFieldCheck()) throw new Exception("Name, Category, Available, Price, Description and Season field must be filled");
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();
                string sql = "INSERT INTO Menu_items (category, season, is_available, price, name, description, admin_id)"
                        + "VALUES(@category, @season, @is_available, @price, @name, @description, @admin_id)";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                
                cmd.Parameters.AddWithValue("@category", CategoryTxt.Text);
                cmd.Parameters.AddWithValue("@season", SeasonTxt.Text);
                    
                cmd.Parameters.AddWithValue("@is_available", GetAvailableText());
                cmd.Parameters.AddWithValue("@price", double.Parse(PriceTxt.Text));
                cmd.Parameters.AddWithValue("@name", NameTxt.Text);
                cmd.Parameters.AddWithValue("@description", DescriptionTxt.Text);
                cmd.Parameters.AddWithValue("@admin_id", Globals.User_id);
                cmd.ExecuteNonQuery();

                // Updating the grid
                this.menu_itemsTableAdapter.Fill(this.food_Ordering_SystemDataSet.Menu_items);

                sqlConnection.Close();
                MessageBox.Show("Item added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdComboBox.SelectedIndex == 0) throw new Exception("Please select an ID");
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();
                string sql = "DELETE FROM Menu_items WHERE meal_id = @meal_id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@meal_id", IdComboBox.SelectedValue);
                cmd.ExecuteNonQuery();

                // Updating the grid
                this.menu_itemsTableAdapter.Fill(this.food_Ordering_SystemDataSet.Menu_items);

                sqlConnection.Close();
                PopulateIDComboBox();
                MessageBox.Show("Item deleted successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdComboBox.SelectedIndex <= 0)
                {
                    NameTxt.Text = "";
                    CategoryTxt.Text = "";
                    AvailableTxt.Text = "";
                    PriceTxt.Text = "";
                    DescriptionTxt.Text = "";
                    SeasonTxt.Text = "";
                    return;
                }

                int selectedId = Convert.ToInt32(IdComboBox.SelectedIndex);
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Menu_items WHERE meal_id = @meal_id", sqlConnection);
                cmd.Parameters.AddWithValue("@meal_id", selectedId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NameTxt.Text = reader["name"].ToString();
                    DescriptionTxt.Text = reader["description"].ToString();
                    PriceTxt.Text = reader["price"].ToString();
                    SeasonTxt.Text = reader["season"].ToString();
                    AvailableTxt.Text = reader["is_available"].ToString();
                    CategoryTxt.Text = reader["category"].ToString();
                }
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFieldCheck()) throw new Exception("Name, Category, Available, Price, Description and Season field must be filled");
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();
                string sql = "UPDATE Menu_items SET category = @category, season = @season, is_available = @is_available," +
                    "price = @price, name = @name, description = @description, admin_id = @admin_id WHERE meal_id = @meal_id";
                        
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                cmd.Parameters.AddWithValue("@category", CategoryTxt.Text);
                cmd.Parameters.AddWithValue("@season", SeasonTxt.Text);
                cmd.Parameters.AddWithValue("@meal_id", IdComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@is_available", GetAvailableText());
                cmd.Parameters.AddWithValue("@price", double.Parse(PriceTxt.Text));
                cmd.Parameters.AddWithValue("@name", NameTxt.Text);
                cmd.Parameters.AddWithValue("@description", DescriptionTxt.Text);
                cmd.Parameters.AddWithValue("@admin_id", Globals.User_id);
                cmd.ExecuteNonQuery();

                // Updating the grid
                this.menu_itemsTableAdapter.Fill(this.food_Ordering_SystemDataSet.Menu_items);

                sqlConnection.Close();
                MessageBox.Show("Item edited successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
