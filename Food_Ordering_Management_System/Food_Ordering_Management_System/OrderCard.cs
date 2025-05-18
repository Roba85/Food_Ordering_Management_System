using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Management_System
{
    public partial class OrderCard : UserControl
    {
        private int order_id;
        public OrderCard()
        {
            InitializeComponent();
        }

        public void setOrderId(int orderId)
        {
            order_id = orderId;
            lblOrderNo.Text = orderId.ToString();
        }

        public void setLblPrice(decimal price) => lblOrderPrice.Text = price.ToString("C");
        public int getOrderId() => order_id;
        public decimal getOrderPrice() => decimal.Parse(lblOrderPrice.Text, NumberStyles.Currency);

        public event Action addFeedback;
        private void btnAddFeedback_Click(object sender, EventArgs e)
        {
            addFeedback?.Invoke();
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            Form bill = new Bill(order_id);
            bill.Show();
        }

        public void hideCancelBtn() => btnCancelOrder.Visible = false;

        public event Action<int> orderDeleted;
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();

                String query = "DELETE FROM Order_ WHERE order_id = @order_id";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@order_id", order_id);
                    cmd.ExecuteNonQuery();
                }

            }
            orderDeleted?.Invoke(order_id);
            MessageBox.Show("Order canceled successfully.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
