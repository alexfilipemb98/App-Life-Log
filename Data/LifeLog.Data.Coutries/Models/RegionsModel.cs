using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.World.Models
{
    public class RegionsModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public TranslationsModel translations { get; set; }
        public string wikiDataId { get; set; }
    }

}
