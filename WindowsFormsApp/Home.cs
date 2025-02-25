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
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);

            List<string> favWords = FavoriteEntry.GetFavWords();
            //for (int i = 0; i < favWords.Count; i++)
            //{
            //    favorite_words_box.Text += favWords[i] + "       ";
            //}

            favorite_words_panel.Controls.Clear();


            int buttonWidth = 150;
            int buttonHeight = 30;
            int xPos = 10;
            int yPos = 10;
            int horizontalSpacing = 20;
            int verticalSpacing = 15;
            int buttonsPerRow = favorite_words_panel.Width / (buttonWidth + horizontalSpacing);
            int count = 0;
            foreach (string word in favWords)
            {
                Button wordButton = new Button();
                wordButton.Text = word;
                wordButton.Width = buttonWidth;
                wordButton.Height = buttonHeight;
                wordButton.Location = new Point(xPos, yPos);
                wordButton.Margin = new Padding(5);
                wordButton.Tag = word;
                wordButton.Show();

                wordButton.Click += FavoriteWordButton_Click;

                favorite_words_panel.Controls.Add(wordButton);

                count++;
                if (count % buttonsPerRow == 0)
                {
                    xPos = 10;
                    yPos += buttonHeight + verticalSpacing;
                }
                else
                {
                    xPos += buttonWidth + horizontalSpacing;
                }
            }


            LoadColors();


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


        private void light_dark_mode_button_Click(object sender, EventArgs e)
        {
            LightDarkModeSwitcher.ToggleMode();
            LoadColors();
        }

        private void LoadColors()
        {
            if (LightDarkModeSwitcher.GetIsLightMode())
            {
                this.BackColor = Color.FromArgb(245, 245, 245);
                top_panel.BackColor = Color.FromArgb(180, 180, 180);
                favorite_words_label.BackColor = Color.FromArgb(230, 230, 230);
                favorite_words_label.ForeColor = Color.FromArgb(0, 0, 0);
                search_box.BackColor = Color.FromArgb(255, 255, 255);
                light_dark_mode_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\lightmode.png");
            } else
            {
                this.BackColor = Color.FromArgb(120, 120, 120);
                top_panel.BackColor = Color.FromArgb(60, 60, 60);
                favorite_words_label.BackColor = Color.FromArgb(60, 60, 60);
                favorite_words_label.ForeColor = Color.FromArgb(255, 255, 255);
                search_box.BackColor = Color.FromArgb(160, 160, 160);
                light_dark_mode_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\darkmode.png");
            }
        }

        private void FavoriteWordButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {                
                string word = clickedButton.Tag.ToString();
                HistoryEntry.AddEntry(word, DateTime.Now);
                Definition def1 = new Definition(word);
                Hide();
                def1.ShowDialog();
                Close();
            }

            
        }

        



        private void favorite_words_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void favorite_words_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
