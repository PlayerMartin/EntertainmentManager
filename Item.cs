using System.Reflection;
using System;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;

namespace EntertainmentManager
{
    public class Item
    {
        [JsonIgnore] public int ID { get; }
        [JsonIgnore] public string Owner { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Poster { get; }
        public string Genre { get; set; } = string.Empty;

        public string Tags { get; set; } = string.Empty;
        public int Rating { get; set; } = 0;
        public int Progress { get; set; } = 0;
        public string Status { get; set; } = string.Empty;

        // http request constructor
        [JsonConstructor]
        public Item(int id, string owner, string title, string type, string released, 
                    string runtime, string poster, string genre)
        {
            ID = id;
            Owner = owner;
            Title = title;
            Type = type;
            Released = released;
            Runtime = runtime;
            Poster = poster;
            Genre = genre;
        }

        // Library table constructor
        public Item(long id, string owner, string title, string released, string type, long rating, long progress, string status, 
                    string runtime, string poster, string genre, string tags) : this((int)id, owner, title, type, released, runtime, poster, genre)
        {
            Rating = (int)rating;
            Progress = (int)progress;
            Status = status;
            Tags = tags;
        }

        // For editing
        public Item(Item other)
            : this(other.ID, other.Owner, other.Title, other.Released, 
                  other.Type, other.Rating, other.Progress, other.Status, 
                  other.Runtime, other.Poster, other.Genre, other.Tags) {}


        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   ID == item.ID &&
                   Owner == item.Owner &&
                   Title == item.Title &&
                   Type == item.Type &&
                   Released == item.Released &&
                   Runtime == item.Runtime &&
                   Poster == item.Poster &&
                   Genre == item.Genre &&
                   Tags == item.Tags &&
                   Rating == item.Rating &&
                   Progress == item.Progress &&
                   Status == item.Status;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(ID);
            hash.Add(Owner);
            hash.Add(Title);
            hash.Add(Type);
            hash.Add(Released);
            hash.Add(Runtime);
            hash.Add(Poster);
            hash.Add(Genre);
            hash.Add(Tags);
            hash.Add(Rating);
            hash.Add(Progress);
            hash.Add(Status);
            return hash.ToHashCode();
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Title: {Title}");
            sb.Append(Environment.NewLine);
            sb.Append($"Type: {Type}");
            sb.Append(Environment.NewLine);
            sb.Append($"Released: {Released}");
            sb.Append(Environment.NewLine);
            sb.Append($"Runtime: {Runtime}");
            sb.Append(Environment.NewLine);

            if (Genre.Length > 0)
            {
                sb.Append($"Genre: {Genre}");
                sb.Append(Environment.NewLine);
            }

            if (Tags.Length > 0)
            {
                sb.Append($"Tags: {Tags}");
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
