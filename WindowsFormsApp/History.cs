using Dictionary.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            loadHist();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home home1 = new Home();
            this.Hide();
            home1.ShowDialog();
            this.Close();
        }

        private void clear_hist_button_Click(object sender, EventArgs e)
        {
            HistoryEntry.ClearHist();
            history_box.Clear();
        }

        private void loadHist()
        {
            Dictionary<string, DateTime> hist = HistoryEntry.GetHist();
            foreach (string word in hist.Keys)
            {
                history_box.Text += word + "     " + hist[word] + "\r\n";
            }
        }
    }
}
