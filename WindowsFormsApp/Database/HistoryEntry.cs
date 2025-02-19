using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Database
{
    public class HistoryEntry
    {
        private static List<string> words = new List<string>();
        private static List<DateTime> dateTimes = new List<DateTime>();

        public static List<string> GetWords()
        {
            return words;
        }

        public static List<DateTime> GetDateTimes()
        {
            return dateTimes;
        }

        public static void AddEntry(string word, DateTime date)
        {
            words.Add(word);
            dateTimes.Add(date);
        }

        public static void ClearHist()
        {
            words.Clear();
            dateTimes.Clear();
        }
    }
}
