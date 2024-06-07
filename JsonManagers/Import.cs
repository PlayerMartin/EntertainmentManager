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
                using (FileStream fs = File.OpenRead(System.IO.Path.Combine(Path, Username + ".json")))
                {
                    return await JsonSerializer.DeserializeAsync<List<Item>>(fs);
                }
            }
            catch (IOException)
            {
                return null;
            }
            catch (JsonException)
            {
                return null;
            }
            catch (NotSupportedException)
            {
                return null;
            }
        }
    }
}
