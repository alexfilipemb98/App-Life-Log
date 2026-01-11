using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Models
{
	public class CountriesModel
	{
		public int id { get; set; }
		public string name { get; set; }
		public string iso3 { get; set; }
		public string iso2 { get; set; }
		public string numeric_code { get; set; }
		public string phone_code { get; set; }
		public string capital { get; set; }
		public string currency { get; set; }
		public string currency_name { get; set; }
		public string currency_symbol { get; set; }
		public string tld { get; set; }
		public string native { get; set; }
		public string region { get; set; }
		public string region_id { get; set; }
		public string subregion { get; set; }
		public string subregion_id { get; set; }
		public string nationality { get; set; }
		public Timezone[] timezones { get; set; }
		public TranslationsModel translations { get; set; }
		public string latitude { get; set; }
		public string longitude { get; set; }
		public string emoji { get; set; }
		public string emojiU { get; set; }
		public string CodeName => $"{iso2} ({name})";
	}

	public class Timezone
	{
		public string zoneName { get; set; }
		public int gmtOffset { get; set; }
		public string gmtOffsetName { get; set; }
		public string abbreviation { get; set; }
		public string tzName { get; set; }
	}

}
