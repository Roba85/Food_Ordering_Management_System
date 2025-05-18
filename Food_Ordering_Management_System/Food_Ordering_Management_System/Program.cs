using Food_Ordering_Management_System.Food_Ordering_SystemDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new User_homepage());
            Application.Run(new Users_Admin_Form());
            //Application.Run(new SignIn());
            //Application.Run(new Menu_form());

        }
    }

    public static class Globals
    {

        public static int User_id { get; set; }
        public static Dictionary<int, int> User_Cart = new Dictionary<int, int>();
        // public static Menu_Form menu_form = new Menu_Form();
        // public static Users_Admin_Form users_Admin_Form = new Users_Admin_Form();
        //public static User_homepage homePage = new User_homepage();
        public static User_profile user_profile = new User_profile();
        public static Cart cart = new Cart();


        // public const string ConnectionStirng =
        //"Data Source=RORA;Initial Catalog=Food_Ordering_System;Integrated Security=True;";


        //public const string ConnectionStirng = "Data Source=LAPTOP-78QNVUR1;Initial Catalog=Food_ordering_system;Integrated Security=True";
        public static int User_id { get; set; }
        public const string ConnectionStirng = 
            "Data Source=RORA;Initial Catalog=Food_Ordering_System;Integrated Security=True;";


        // R: "Data Source=RORA;Initial Catalog=Food_Ordering_System;Integrated Security=True;"
    }
}
