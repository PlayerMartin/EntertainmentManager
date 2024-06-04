using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentManager
{
    public class Statistics
    {
        private IEnumerable<Item> Data;

        public Statistics(IEnumerable<Item> data)
        {
            Data = data;
        }

        public int ItemCount()
        {
            return Data.Count();
        }

        public double AverageRating()
        {
            return Data.Average(d => d.Rating);
        }

        public string MostCommonGenre()
        {
            return Data
                .SelectMany(d => d.Genre.Split(", "))
                .GroupBy(g => g)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
        }
    }
}
