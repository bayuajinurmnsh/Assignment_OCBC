using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_017_BayuAjiNurmansah.Models
{
    public class MoviesItem
    {
        private Models.MoviesContext context;
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public string releaseDate { get; set; }
    }
}
