using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EntertainmentManager.JsonManagers
{
    public class Import : JsonManager
    {
        public Import(string path, string username) : base(path, username) {}

        public async Task<List<Item>?> Deserialize()
        {
            try
            {
                return await JsonSerializer.DeserializeAsync<List<Item>>(File.OpenRead(System.IO.Path.Combine(Path, Username + ".json")));
            }
            catch (Exception e)
            {
                if (e is IOException || e is JsonException || e is NotSupportedException)
                {
                    return null;
                }
                throw;
            }
        }
    }
}
