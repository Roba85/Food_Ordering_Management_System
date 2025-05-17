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
    public partial class MealCard : UserControl
    {
        public MealCard()
        {
            InitializeComponent();
        }

        // Setters
        public void setMealName(string meal_name) => lblMealName.Text = meal_name;
        public void setMealDescription(string meal_description) => lblMealDescription.Text = meal_description;
        public void setMealCategory(string meal_category) => lblMealCategory.Text = meal_category;
        public void setMealAvailable(char meal_available) => lblMealAvailable.Text = (meal_available == 'Y') ? "Yes" : "No";
        public void setMealSeason(string meal_season) => lblMealSeason.Text = meal_season;
        public void setMealPrice(decimal meal_price) => lblMealPrice.Text = meal_price.ToString("C"); // Currency format
        public void setMealOrderBtnName(string meal_orderBtnName) => btnOrder.Name = "btnOrder_" + meal_orderBtnName;

        // Getters
        public string getMealName() => lblMealName.Text;
        public string getMealDescription() => lblMealDescription.Text;
        public string getMealCategory() => lblMealCategory.Text;
        public string getMealAvailable() => lblMealAvailable.Text;
        public string getMealSeason() => lblMealSeason.Text;
        public decimal getMealPrice() => decimal.TryParse(lblMealPrice.Text, System.Globalization.NumberStyles.Currency, null, out var val) ? val : 0;
        public int getMealOrderBtnName()
        {
            string name = btnOrder.Name; // e.g. "btnOrder_123" such that 123 is the meal id 
            return (name.Split('_').Length == 2 && int.TryParse(name.Split('_')[1], out int mealId)) ? mealId : -1;
        }
    }
}
