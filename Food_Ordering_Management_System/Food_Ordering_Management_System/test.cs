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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            listBox1.Items.Add("hi");
            listBox1.Items.Add("bye");
            listBox1.Items.Add("hi");
        }

        private void menu_itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menu_itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.food_ordering_systemDataSet);

        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'food_ordering_systemDataSet.customer_favorites' table. You can move, or remove it, as needed.
            this.customer_favoritesTableAdapter.Fill(this.food_ordering_systemDataSet.customer_favorites);
            // TODO: This line of code loads data into the 'food_ordering_systemDataSet.Menu_items' table. You can move, or remove it, as needed.
            this.menu_itemsTableAdapter.Fill(this.food_ordering_systemDataSet.Menu_items);

        }

    }
}
