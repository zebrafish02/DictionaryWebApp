using Dictionary.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Definition : Form
    {

        private readonly DefinitionDatabase definitionDatabase;
        private string defword;

        public Definition(string word)
        {
            InitializeComponent();
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            definitionDatabase = new DefinitionDatabase();
            SearchWord(word);
            defword = word;
            if (FavoriteEntry.ContainsWord(word))
            {                
                favorite_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets/heartFilled.png"));
            } else
            {
                favorite_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets/heartUnfilled.png"));
            }
            LoadColors();

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home home1 = new Home();
            this.Hide();
            home1.ShowDialog();
            this.Close();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History hist1 = new History();
            this.Hide();
            hist1.ShowDialog();
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            HistoryEntry.AddEntry(search_box.Text, DateTime.Now);
            Definition def1 = new Definition(search_box.Text);
            Hide();
            def1.ShowDialog();
            Close();
        }

        private void search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_button_Click(this, new EventArgs());
            }
        }

        private void favorite_button_Click(object sender, EventArgs e)
        {
            if (!FavoriteEntry.ContainsWord(defword) && FavoriteEntry.Count() < 12)
            {
                FavoriteEntry.AddFavWord(defword);
                //image changing from stack overflow
                favorite_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets\heartFilled.png"));
            }
            else if (FavoriteEntry.Count() >= 12)
            {
                FavoriteEntry.ErrorMessage();
            }
            else
            {
                FavoriteEntry.RemoveFavWord(defword);
                favorite_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets/heartUnfilled.png"));
            }
            
        }


        public async Task SearchWord(string word)
        {

            word_box.Text = word;
            try
            {
                var results = await definitionDatabase.GetDef(word);

                foreach (var wordDef in results)
                {

                    foreach (var meaning in wordDef.Meanings)
                    {
                        definition_box.Text +=($"\r\n \r\n ({meaning.PartOfSpeech}) \r\n");
                        foreach (var def in meaning.Definitions)
                        {
                            definition_box.Text += ($"\r\n{def.Text}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                definition_box.Text = ($"Error looking up word: {ex.Message}");
            }
        }

        private void LoadColors()
        {
            if (LightDarkModeSwitcher.GetIsLightMode())
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                top_panel.BackColor = Color.FromArgb(180, 180, 180);
                search_box.BackColor = Color.FromArgb(255, 255, 255);
                word_box.BackColor = Color.FromArgb(255, 255, 255);
                word_box.ForeColor = Color.FromArgb(0, 0, 0);
                definition_box.BackColor = Color.FromArgb(245, 245, 245);
                definition_box.ForeColor = Color.FromArgb(0, 0, 0);
                light_dark_mode_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets/lightmode.png"));
            }
            else
            {
                this.BackColor = Color.FromArgb(120, 120, 120);
                top_panel.BackColor = Color.FromArgb(60, 60, 60);
                search_box.BackColor = Color.FromArgb(100, 100, 100);
                word_box.BackColor = Color.FromArgb(160, 160, 160);
                word_box.ForeColor = Color.FromArgb(255, 255, 255);
                definition_box.BackColor = Color.FromArgb(160, 160, 160);
                definition_box.ForeColor = Color.FromArgb(255, 255, 255);
                light_dark_mode_button.Image = Image.FromFile(Utilities.ComputePath(@"Assets/darkmode.png"));
            }
        }

        private void definition_scroll_bar_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void light_dark_mode_button_Click(object sender, EventArgs e)
        {
            LightDarkModeSwitcher.ToggleMode();
            LoadColors();
        }
    }
}
