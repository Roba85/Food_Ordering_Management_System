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
    public partial class Bill : Form
    {
        public Bill(int order_id)
        {
            InitializeComponent();
            LoadBill(order_id);
        }

        private void LoadBill(int order_id)
        {
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
            sqlConnection.Open();

            flowLayoutBill.Controls.Clear();
            String query = @"SELECT Menu_items.name, Menu_items.price, Quantity, product_total, Order_items.meal_id 
                            FROM Order_items, Menu_items WHERE Order_items.order_id = @order_id 
                            AND Menu_items.meal_id = Order_items.meal_id";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@order_id", order_id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.setMealId(Convert.ToInt32(reader["meal_id"]));
                        orderItem.setLblItemName(reader["name"].ToString());
                        orderItem.setLblItemPrice(Convert.ToDecimal(reader["price"]));
                        orderItem.setLblQty(Convert.ToInt32(reader["Quantity"]));
                        orderItem.setLblTotal();
                        orderItem.disableBtns();
                        flowLayoutBill.Controls.Add(orderItem);
                    }
                }
            }

            query = "SELECT sub_total, tax, total FROM Order_ WHERE order_id = @order_id";
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@order_id", order_id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    lblSubTotal.Text = "$" + reader["sub_total"].ToString();
                    lblTax.Text = "$" +  reader["tax"].ToString();
                    lblTotal.Text = "$" + reader["total"].ToString();
                }
            }

        }
    }
}
