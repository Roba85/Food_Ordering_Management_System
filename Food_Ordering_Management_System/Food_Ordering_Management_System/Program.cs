using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Management_System
{
    public static class Globals
    {
        public static int User_id { get; set; }
        public static string Is_Admin { get; set; }
        // public const string ConnectionStirng =
        //"Data Source=RORA;Initial Catalog=Food_Ordering_System;Integrated Security=True;";


        public const string ConnectionStirng = "Data Source=LAPTOP-78QNVUR1;Initial Catalog=Food_ordering_system;Integrated Security=True";
    }

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
            Application.Run(new User_form());
        }
    }
}
