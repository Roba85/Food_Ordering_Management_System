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
    public partial class Users_Admin_Form : Form
    {
        public Users_Admin_Form()
        {
            InitializeComponent();
            PopulateUsersDataGridView();
            PopulateIDComboBox();
        }

        private void PopulateUsersDataGridView()
        {
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
            sqlConnection.Open();
            string sql = @"SELECT c.customer_id, c.customer_name, c.email, c.address, p.phone, c.password
                            FROM Customer c
                            LEFT OUTER JOIN Customer_phones p ON
                            c.customer_id = p.customer_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            var grouped = dt.AsEnumerable()
            .GroupBy(row => new {
                CustomerId = row["customer_id"],
                Name = row["customer_name"],
                Email = row["email"],
                Address = row["address"],
                Password = row["password"]
            })
            .Select(g => new {
                ID = g.Key.CustomerId,
                Name = g.Key.Name,
                Email = g.Key.Email,
                Address = g.Key.Address,
                Password = g.Key.Password,
                Phones = string.Join(", ", g
                    .Where(r => r["phone"] != DBNull.Value)
                    .Select(r => r["phone"].ToString()))
            }).ToList();

            UsersDataGridView.DataSource = grouped;
            UsersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void PopulateIDComboBox()
        {
            string sql = "SELECT customer_id FROM Customer ORDER BY customer_id";
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            DataRow noneRow = dt.NewRow();
            noneRow["customer_id"] = DBNull.Value;
            dt.Rows.InsertAt(noneRow, 0);

            IdComboBox.DataSource = dt;
            IdComboBox.DisplayMember = "ID";
            IdComboBox.ValueMember = "customer_id";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'food_Ordering_SystemDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.food_Ordering_SystemDataSet.Customer);

        }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdComboBox.SelectedIndex <= 0)
                {
                    NameTxt.Text = "";
                    AddressTxt.Text = "";
                    EmailTxt.Text = "";
                    PhoneTxt.Text = "";
                    PasswordTxt.Text = "";
                    return;
                }

                int selectedId = Convert.ToInt32(IdComboBox.SelectedValue);
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE customer_id = @customer_id", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@customer_id", selectedId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NameTxt.Text = reader["customer_name"].ToString();
                            AddressTxt.Text = reader["address"].ToString();
                            EmailTxt.Text = reader["email"].ToString();
                            PasswordTxt.Text = reader["password"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd1 = new SqlCommand("SELECT phone FROM Customer_phones WHERE customer_id = @customer_id", sqlConnection))
                {
                    cmd1.Parameters.AddWithValue("@customer_id", selectedId);
                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (reader1.Read())
                        {
                            if (reader1["phone"] != DBNull.Value)
                                list.Add(reader1["phone"].ToString());
                        }
                        PhoneTxt.Text = string.Join(", ", list);
                    }
                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool EmptyFieldCheck()
        {

            if (NameTxt.Text.Length == 0 || PasswordTxt.Text.Length == 0
                || PhoneTxt.Text.Length == 0 || EmailTxt.Text.Length == 0
                || AddressTxt.Text.Length == 0)
                return true;
            return false;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFieldCheck()) throw new Exception("Name, Password, Address, Email and Phone Number field must be filled");
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();
                string sql = "INSERT INTO Customer (customer_name, address, password, email)"
                        + "VALUES(@name, @address, @password, @email)";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {

                    cmd.Parameters.AddWithValue("@name", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", AddressTxt.Text.ToString());

                    cmd.Parameters.AddWithValue("@password", PasswordTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());

                    cmd.ExecuteNonQuery();
                }

                sql = "SELECT customer_id FROM Customer WHERE email = @email";
                int id;
                using (SqlCommand cmd1 = new SqlCommand(sql, sqlConnection))
                {
                    cmd1.Parameters.AddWithValue("@email", EmailTxt.Text);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["customer_id"]);
                        }
                        else throw new Exception("Couldn't add customer due to ID issue");
                    }

                }

                List<string> phoneList = PhoneTxt.Text
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(phone => phone.Trim())
                .ToList();

                sql = "INSERT INTO Customer_phones (customer_id, phone) VALUES(@id, @phone)";

                foreach (string phone in phoneList) 
                {
                    using (SqlCommand cmd2 = new SqlCommand(sql, sqlConnection))
                    {
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.Parameters.AddWithValue("@phone", phone);
                        cmd2.ExecuteNonQuery();
                    }
                }


                PopulateIDComboBox();
                PopulateUsersDataGridView();

                sqlConnection.Close();
                MessageBox.Show("Customer added successfully!");
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
                if (EmptyFieldCheck()) throw new Exception("Name, Password, Address, Email and Phone Number field must be filled");
                SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                sqlConnection.Open();
                int selectedId = Convert.ToInt32(IdComboBox.SelectedValue);
                string sql = @"UPDATE Customer SET customer_name = @name, address = @address,
                            password = @password, email = @email WHERE customer_id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {

                    cmd.Parameters.AddWithValue("@name", NameTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@address", AddressTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    cmd.Parameters.AddWithValue("@password", PasswordTxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());

                    cmd.ExecuteNonQuery();
                }

                List<string> phoneList = PhoneTxt.Text
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(phone => phone.Trim())
                .ToList();
                
                using (SqlCommand cmd1 = new SqlCommand("DELETE FROM Customer_phones WHERE customer_id = @id", sqlConnection))
                {
                    cmd1.Parameters.AddWithValue("@id", selectedId);
                    cmd1.ExecuteNonQuery();
                }

                sql = "INSERT INTO Customer_phones (customer_id, phone) VALUES(@id, @phone)";

                foreach (string phone in phoneList)
                {
                    using (SqlCommand cmd2 = new SqlCommand(sql, sqlConnection))
                    {
                        cmd2.Parameters.AddWithValue("@id", selectedId);
                        cmd2.Parameters.AddWithValue("@phone", phone);
                        cmd2.ExecuteNonQuery();
                    }
                }


                PopulateIDComboBox();
                PopulateUsersDataGridView();

                sqlConnection.Close();
                MessageBox.Show("Customer edited successfully!");
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
                int selectedId = Convert.ToInt32(IdComboBox.SelectedValue);
                string sql = "DELETE FROM Customer_phones WHERE customer_id = @id";
                using (SqlCommand cmd1 = new SqlCommand(sql, sqlConnection))
                {
                    cmd1.Parameters.AddWithValue("@id", selectedId);
                    cmd1.ExecuteNonQuery();
                }

                sql = "DELETE FROM Customer WHERE customer_id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();

                }

                sqlConnection.Close();
                PopulateIDComboBox();
                PopulateUsersDataGridView();
                MessageBox.Show("Customer deleted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SwitcthToMenuItemsBtn_Click(object sender, EventArgs e)
        {
            
            Globals.menu_Form.Show();
            this.Hide();
        }
    }
}
