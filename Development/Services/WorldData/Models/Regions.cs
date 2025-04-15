using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldData.Models
{
    public class Regions
    {
        public int id { get; set; }
        public string name { get; set; }
        public Translations translations { get; set; }
        public string wikiDataId { get; set; }
    }

}
