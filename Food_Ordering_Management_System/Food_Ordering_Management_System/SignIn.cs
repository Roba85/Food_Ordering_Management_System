using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Ordering_Management_System
{
    public partial class SignIn : Form
    {
        private bool is_admin = false;
        public SignIn()
        {
            InitializeComponent();
            PasswordTxt.UseSystemPasswordChar = true;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
        
        }

        private void YesRadioBtn_CheckedChanged(object sender, EventArgs e)
        
        {
            var rb = sender as RadioButton;
            // Adjusting the variable
            if (rb.Checked == true)
            {
                is_admin = true;   
            }
            else
            {
                is_admin = false; 
            }

        }

        private void NotAdminRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            // Adjusting the variable
            if (rb.Checked == true)
            {
                is_admin = false;
            }
        }

        private void EmptyFieldCheck()
        {
            if (PasswordTxt.Text.Length == 0 || EmailTxt.Text.Length == 0)
            {
                throw new Exception("Please fill password and email fields");
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmptyFieldCheck();
                if (is_admin)
                {
                    SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT password FROM Admin WHERE email = @email", sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (Convert.ToString(reader["password"]) == PasswordTxt.Text.ToString())
                                {
                                    MessageBox.Show("Logged in successfully!");
                                    Globals.menu_Form.Show();
                                    this.Hide();
                                }
                                else throw new Exception("Invalid Password");
                            }
                            else throw new Exception("Invalid Email");
                        }

                    }
                    sqlConnection.Close();
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT password FROM Customer WHERE email = @email", sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@email", EmailTxt.Text.ToString());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (Convert.ToString(reader["password"]) == PasswordTxt.Text.ToString())
                                {
                                    // TODO
                                    // Show customer page
                                    //MessageBox.Show("Logged in successfully!");
                                    //Globals.menu_Form.Show();
                                    //this.Hide();
                                }
                                else throw new Exception("Invalid Password");
                            }
                            else throw new Exception("Invalid Email");
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
