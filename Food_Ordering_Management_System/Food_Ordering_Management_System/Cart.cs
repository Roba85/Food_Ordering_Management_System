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
    public partial class Cart : Form
    {
        private decimal sub_total;
        public Cart()
        {
            InitializeComponent();
            sub_total = 0;
            LoadOrderItems();
            calculateTotal();
        }

        public void LoadOrderItems()
        {
            SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng);
            sqlConnection.Open();

            flowLayoutCart.Controls.Clear();
            foreach (var item in Globals.User_Cart)
            {
                String query = "SELECT name, price FROM Menu_items WHERE meal_id = @meal_id";

                using(SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@meal_id", item.Key);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        OrderItem orderItem = new OrderItem();
                        orderItem.setMealId(item.Key);
                        orderItem.setLblItemName(reader["name"].ToString());
                        orderItem.setLblItemPrice(Convert.ToDecimal(reader["price"]));
                        orderItem.setLblQty(item.Value);
                        orderItem.setLblTotal();
                        orderItem.QtyUpdated += calculateTotal;
                        orderItem.RemoveItem += removeItem;
                        flowLayoutCart.Controls.Add(orderItem);
                    }
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Globals.User_Cart.Clear();
            LoadOrderItems();
            lblTotalOrder.Text = 0.ToString("C");
        }

        public void calculateTotal()
        {
            foreach (OrderItem item in flowLayoutCart.Controls.OfType<OrderItem>())
            {
                sub_total += item.getItemPrice() * item.getQty();
            }

            lblTotalOrder.Text = sub_total.ToString("C");
        }

        private void removeItem(int meal_id)
        {
            var item = flowLayoutCart.Controls
                        .OfType<OrderItem>()
                        .FirstOrDefault(i => i.getMealId() == meal_id);

            if (item != null)
            {
                flowLayoutCart.Controls.Remove(item);
                item.Dispose();
            }

            // Remove from cart
            Globals.User_Cart.Remove(meal_id);

            // Update total
            calculateTotal();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (Globals.User_Cart.Count == 0) { return; }

            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();

                String Orderquery = @"INSERT INTO Order_ (date, total, tax, payment_method, sub_total, branch_id, customer_id)
                             VALUES (@date, @total, @tax, 'Cash', @sub_total, '3', @user_id); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(Orderquery, sqlConnection))
                {
                    
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    cmd.Parameters.AddWithValue("@total", sub_total + sub_total * 0.07m);
                    cmd.Parameters.AddWithValue("@tax", sub_total * 0.07m);
                    cmd.Parameters.AddWithValue("@sub_total", sub_total);
                    cmd.Parameters.AddWithValue("@user_id", Globals.User_id);

                    int newOrderId = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (OrderItem item in flowLayoutCart.Controls.OfType<OrderItem>())
                    {
                        String OrderItemsquery = @"INSERT INTO Order_items (Quantity, product_total, order_id, meal_id)
                                        VALUES (@qty, @ptoduct_total, @order_id, @meal_id)";

                        using(SqlCommand cmd2 =  new SqlCommand(OrderItemsquery, sqlConnection))
                        {
                            cmd2.Parameters.AddWithValue("@qty", item.getQty());
                            cmd2.Parameters.AddWithValue("@ptoduct_total", item.getTotal());
                            cmd2.Parameters.AddWithValue("@order_id", newOrderId);
                            cmd2.Parameters.AddWithValue("@meal_id", item.getMealId());

                            insertOrderItem(item, newOrderId);
                        }
                    }
                }

            }
            MessageBox.Show("Oder was successfully made!");
            
        }

        private void insertOrderItem(OrderItem item, int newOrderId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Globals.ConnectionStirng))
            {
                sqlConnection.Open();

                String OrderItemsquery = @"INSERT INTO Order_items (Quantity, product_total, order_id, meal_id)
                                        VALUES (@qty, @ptoduct_total, @order_id, @meal_id)";

                using (SqlCommand cmd2 = new SqlCommand(OrderItemsquery, sqlConnection))
                {
                    cmd2.Parameters.AddWithValue("@qty", item.getQty());
                    cmd2.Parameters.AddWithValue("@ptoduct_total", item.getTotal());
                    cmd2.Parameters.AddWithValue("@order_id", newOrderId);
                    cmd2.Parameters.AddWithValue("@meal_id", item.getMealId());

                    cmd2.ExecuteNonQuery();
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Form user_form = new User_homepage();
            user_form.Show();
            this.Hide();
        }
    }
}
