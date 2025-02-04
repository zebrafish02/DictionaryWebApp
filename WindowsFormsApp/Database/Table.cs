using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace Dictionary.Database
{
    public static class Table
    {
        static string parentPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Database/Storage");
        public static void Serialize<T>(T[] entities, string tableName)
        {
            File.WriteAllText(
                Path.Combine(
                    parentPath, $"{tableName}.json"
                ),
                JsonConvert.SerializeObject(entities)
            );
        }

        public static T[] Deserialize<T>(string tableName)
        {
            string fileContents = File.ReadAllText(Path.Combine(
                parentPath, $"{tableName}.json"
            ));

            return JsonConvert.DeserializeObject<T[]>(fileContents);
        }
    }
}
