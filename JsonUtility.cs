using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace DailyProject
{
    static class JsonUtility
    {
        public static int SaveJson<T>(T value, string savePath)
        {
            var options = new JsonSerializerOptions();
            var serial = JsonSerializer.Serialize(value, options);
            Debug.WriteLine(serial);

            using (var fileStream = File.Create(savePath))
            {
                using (var writer = new StreamWriter(fileStream, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(serial);
                }
            }

            return 0;
        }

        public static T LoadJson<T>(string path)
        {
            var options = new JsonSerializerOptions();
            using (var file = File.OpenText(path))
            {
                var text = file.ReadToEnd();
                var json = JsonSerializer.Deserialize<T>(text, options);
                return json;
            }
        }
    }
}
