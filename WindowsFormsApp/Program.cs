using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Database;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Table.Serialize<FavoriteEntry>(new FavoriteEntry[] { new FavoriteEntry() {
                word = "balls",
                timeFavorited = DateTime.Now
            } }, "history") ;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
