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
            LoadHist();
            LoadColors();
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

        private void LoadColors()
        {
            if (LightDarkModeSwitcher.GetIsLightMode())
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                top_panel.BackColor = Color.FromArgb(180, 180, 180);
                history_box.BackColor = Color.FromArgb(245, 245, 245);
                history_box.ForeColor = Color.FromArgb(0, 0, 0);
                light_dark_mode_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\lightmode.png");
            }
            else
            {
                this.BackColor = Color.FromArgb(120, 120, 120);
                top_panel.BackColor = Color.FromArgb(60, 60, 60);
                history_box.BackColor = Color.FromArgb(120, 120, 120);
                history_box.ForeColor = Color.FromArgb(255, 255, 255);
                light_dark_mode_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\darkmode.png");
            }
        }

        private void LoadHist()
        {
            //Dictionary<string, DateTime> hist = HistoryEntry.GetHist();
            List<string> words = HistoryEntry.GetWords();
            List<DateTime> dateTimes = HistoryEntry.GetDateTimes();
            //foreach (string word in hist.Keys)
            //{
            //    history_box.Text += word + "     " + hist[word] + "\r\n";
            //}
            for (int i = 0; i < words.Count; i++)
            {
                history_box.Text += words[i] + "      " + dateTimes[i] + "\r\n";
            }
        }

        private void light_dark_mode_button_Click(object sender, EventArgs e)
        {
            LightDarkModeSwitcher.ToggleMode();
            LoadColors();
        }
    }
}
