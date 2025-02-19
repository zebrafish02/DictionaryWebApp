using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Dictionary.Database
{
    public class FavoriteEntry
    {
        private static List<String> FavoriteWords = new List<String>();
        

        public static List<String> GetFavWords()
        {
            return FavoriteWords;
        }

        public static void AddFavWord(String word)
        {
            if (FavoriteWords.Count >= 12)
            {
                //stack overflow
                MessageBox.Show(
                "You can only favorite up to 12 words!",
                "Maximum Favorites Reached",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            } else
            {
                FavoriteWords.Add(word);
            }
        }

        public static void RemoveFavWord(String word)
        {
            FavoriteWords.Remove(word);
        }

        public static bool ContainsWord(String word)
        {
            return (FavoriteWords.Contains(word));
        }
    }
}
