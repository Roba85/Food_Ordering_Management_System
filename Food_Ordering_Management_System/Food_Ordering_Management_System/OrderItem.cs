using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Management_System
{
    public partial class OrderItem : UserControl
    {
        private int meal_id;
        public OrderItem()
        {
            InitializeComponent();
        }


        public void setMealId(int md) => meal_id = md;
        public void setLblItemName(String name) => lblItemName.Text = name;
        public void setLblItemPrice(decimal price) => lblItemPrice.Text = price.ToString("C");
        public void setLblQty(int qty) => lblQty.Text = qty.ToString();
        public void setLblTotal() => lblTotal.Text = (decimal.Parse(lblItemPrice.Text, NumberStyles.Currency) * int.Parse(lblQty.Text)).ToString("C");
        
        public String getItemName() => lblItemName.Text;

        public decimal getItemPrice() => decimal.Parse(lblItemPrice.Text, NumberStyles.Currency);
        public int getQty() => int.Parse(lblQty.Text);
        public decimal getTotal() => decimal.Parse(lblTotal.Text, NumberStyles.Currency);
        public int getMealId() => meal_id;

        public event Action QtyUpdated;
        public event Action<int> RemoveItem;

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Globals.User_Cart[meal_id]++;
            setLblQty(Globals.User_Cart[meal_id]);
            setLblTotal();

            QtyUpdated?.Invoke();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Globals.User_Cart[meal_id]--;
            if (Globals.User_Cart[meal_id] == 0)
            {
                RemoveItem?.Invoke(meal_id);
                QtyUpdated?.Invoke(); 
                return;
            }

            setLblQty(Globals.User_Cart[meal_id]);
            setLblTotal();
            QtyUpdated?.Invoke();
        }

        public void disableBtns()
        {
            btnDecrease.Enabled = false;
            btnIncrease.Enabled = false;
        }
    }
}
