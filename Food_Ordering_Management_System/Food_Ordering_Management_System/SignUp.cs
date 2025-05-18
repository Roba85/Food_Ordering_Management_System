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
    public partial class SignUp : Form
    {
        private bool is_admin = false;
        public SignUp()
        {
            InitializeComponent();
            PasswordTxt.UseSystemPasswordChar = true;
        }

        private void YesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            // Showing the branch id input fields
            if (rb.Checked == true)
            {
                BranchLabel.Visible = true;
                BranchIdTxt.Visible = true;
                is_admin = true;
                AddressTxt.Visible = false;
                AddressLabel.Visible = false;
            }
            else
            {
                BranchLabel.Visible = false;
                BranchIdTxt.Visible = false;
                is_admin = false;
                AddressTxt.Visible = true;
                AddressLabel.Visible = true;
            }
            
        }

        private void NotAdminRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            // Hiding the branch id
            if (rb.Checked == true)
            {
                BranchLabel.Visible = false;
                BranchIdTxt.Visible = false;
                is_admin = false;
                AddressTxt.Visible = true;
                AddressLabel.Visible = true;
            }

        }

        private void EmptyFieldCheck()
        {
            if (NameTxt.Text.Length == 0 || PasswordTxt.Text.Length == 0
                || PhoneTxt.Text.Length == 0 || EmailTxt.Text.Length == 0)
            {
                throw new Exception("Name, Email, Phone and Password must be filled");
            }
            if (is_admin == true && BranchIdTxt.Text.Length == 0)
            {
                throw new Exception("Branch ID must be filled");
            }
            if (!is_admin && AddressTxt.Text.Length == 0)
            {
                throw new Exception("Address must be filled");
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_admin)
                {
                    EmptyFieldCheck();
                    SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                    sqlConnection.Open();
                    int bId = Convert.ToInt32(BranchIdTxt.Text);
                    string sql = "INSERT INTO Admin (admin_name, email, branch_id, password) Values(@name, @email, @b_id, @pass)";
                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@name", NameTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@b_id", bId);
                        cmd.Parameters.AddWithValue("@pass", PasswordTxt.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    // Getting the admin ID
                    sql = "SELECT admin_id FROM Admin WHERE email = @email";
                    int id;
                    using (SqlCommand cmd1 = new SqlCommand(sql, sqlConnection))
                    {
                        cmd1.Parameters.AddWithValue("@email", EmailTxt.Text);
                        using (SqlDataReader reader = cmd1.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = Convert.ToInt32(reader["admin_id"]);
                            }
                            else throw new Exception("Couldn't add customer due to ID issue");
                        }

                    }
                    // Setting the global variable
                    Globals.User_id = id;

                    List<string> phoneList = PhoneTxt.Text
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(phone => phone.Trim())
                    .ToList();

                    sql = "INSERT INTO Admin_Phones (admin_id, phone) VALUES(@id, @phone)";

                    foreach (string phone in phoneList)
                    {
                        using (SqlCommand cmd2 = new SqlCommand(sql, sqlConnection))
                        {
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@phone", phone);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    sqlConnection.Close();
                    MessageBox.Show("Admin signed up successfully!");
                    Globals.menu_Form.Show();
                    this.Hide();
                }
                // Signing Up a Customer
                else
                {
                    EmptyFieldCheck();
                    SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                    sqlConnection.Open();
                    string sql = "INSERT INTO Customer (customer_name, email, address, password) Values(@name, @email, @address, @pass)";
                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@name", NameTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@address", AddressTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@pass", PasswordTxt.Text.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    // Getting the admin ID
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
                    // Setting the global variable
                    Globals.User_id = id;

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

                    sqlConnection.Close();
                    MessageBox.Show("Customer signed up successfully!");
                    // TODO
                    // Switch to customer Profile

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
