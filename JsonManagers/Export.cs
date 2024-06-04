using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EntertainmentManager.JsonManagers
{
    public class Export : JsonManager
    {
        public Export(string path, string username)  : base(path, username) {}

        public bool Serialize(IEnumerable<Item> data)
        {
            try
            {
                File.WriteAllText(
                    System.IO.Path.Combine(Path, Username + ".json"),
                    JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true })
                );
            }
            catch (IOException)
            {
                return false;
            }
            return true;
        }
    }
}
