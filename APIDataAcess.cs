using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EntertainmentManager
{
    public class APIDataAcess
    {
        private const string OMDB_URL = "http://www.omdbapi.com/";
        private const string API_KEY = "ad379dcc";
        private const string API_DATA_TYPE = "json";

        public static async Task<Item?> RequestItem(string title, string type, string year)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage dataResponse = await client.GetAsync($"{OMDB_URL}?apikey={API_KEY}&t={title}&type={type}&y={year}&r={API_DATA_TYPE}");
                    if (!dataResponse.IsSuccessStatusCode)
                    {
                        return null;
                    }
                    using (var responseStream = await dataResponse.Content.ReadAsStreamAsync())
                    {
                        Item? item = await JsonSerializer.DeserializeAsync<Item>(responseStream);
                        if (item == null || item.Title == null)
                        {
                            return null;
                        }
                        return item;
                    }
                }
                catch (Exception e)
                {
                    if (e is HttpIOException || e is HttpRequestException)
                    {
                        return null;
                    }
                    throw;
                }
            }
        }
    }
}
