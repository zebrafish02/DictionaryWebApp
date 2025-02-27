using System.IO;
using System.Reflection;

namespace WindowsFormsApp
{
    public static class Utilities
    {
        private static string BuildFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static string ComputePath(string path)
        {
            return Path.Combine(BuildFolder, path);
        }
    }
}
