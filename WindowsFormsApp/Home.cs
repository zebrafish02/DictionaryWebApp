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
        private readonly DefinitionDatabase definitionDatabase;
        public Home()
        {
            InitializeComponent();

            List<string> favWords = FavoriteEntry.GetFavWords();
            for (int i = 0; i < favWords.Count; i++)
            {
                favorite_words_box.Text += favWords[i] + "       ";
            }

            definitionDatabase = new DefinitionDatabase();
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
            
        }



        public async Task SearchWord(string word)
        {
            try
            {
                var results = await definitionDatabase.GetDef(word);

                foreach (var wordDef in results)
                {
                    Console.WriteLine($"\nDefinitions for: {wordDef.Word}");

                    foreach (var meaning in wordDef.Meanings)
                    {
                        Console.WriteLine($"\nPart of Speech: {meaning.PartOfSpeech}");
                        foreach (var def in meaning.Definitions)
                        {
                            Console.WriteLine($"Definition: {def.Text}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error looking up word: {ex.Message}");
            }
        }







        private void favorite_words_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void favorite_words_box_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
