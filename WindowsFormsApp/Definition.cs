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
    public partial class Definition : Form
    {

        private readonly DefinitionDatabase definitionDatabase;
        private string defword;

        public Definition(string word)
        {
            InitializeComponent();
            definitionDatabase = new DefinitionDatabase();
            SearchWord(word);
            defword = word;
            if (FavoriteEntry.ContainsWord(word))
            {
                favorite_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\heartFilled.png");
            } else
            {
                favorite_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\heartUnfilled.png");
            }
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

        private void favorite_button_Click(object sender, EventArgs e)
        {
            if (!FavoriteEntry.ContainsWord(defword))
            {
                FavoriteEntry.AddFavWord(defword);
                //image changing from stack overflow
                favorite_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\heartFilled.png");
            } else
            {
                FavoriteEntry.RemoveFavWord(defword);
                favorite_button.Image = Image.FromFile(@"C:\__Students\Liu\DictionaryWebApp\heartUnfilled.png");
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
                        definition_box.Text +=($"\r\n({meaning.PartOfSpeech}) ");
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

        
    }
}
