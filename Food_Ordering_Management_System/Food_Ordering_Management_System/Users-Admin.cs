using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'food_Ordering_SystemDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.food_Ordering_SystemDataSet.Customer);

        }
    }
}
