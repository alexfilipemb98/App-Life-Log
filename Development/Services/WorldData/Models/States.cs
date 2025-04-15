using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldData.Models
{
    public class States
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string state_code { get; set; }
        public string type { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

}
