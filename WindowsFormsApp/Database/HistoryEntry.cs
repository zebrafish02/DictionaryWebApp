using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Database
{
    public class HistoryEntry
    {
        private static Dictionary<string, DateTime> hist = new Dictionary<string, DateTime>();

        public static Dictionary<string, DateTime> GetHist()
        {
            return hist;
        }

        public static void AddEntry(string word, DateTime date)
        {
            hist.Add(word, date);
        }

        public static void ClearHist()
        {
            hist.Clear();
        }
    }
}
