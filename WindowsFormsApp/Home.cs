using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Database;

namespace WindowsFormsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            List<string> favWords = FavoriteEntry.GetFavWords();
            for (int i = 0; i < favWords.Count; i++)
            {
                favorite_words_box.Text += favWords[i] + "       ";
            }
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History hist1 = new History();
            this.Hide();
            hist1.ShowDialog();
            this.Close();
        }



        private void favorite_words_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void favorite_words_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
