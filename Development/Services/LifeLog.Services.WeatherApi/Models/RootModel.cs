using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Services.WeatherApi.Models
{
	public class RootModel
	{
		public CoordModel coord { get; set; }
		public WeatherModel[] weather { get; set; }
		public string _base { get; set; }
		public MainModel main { get; set; }
		public int visibility { get; set; }
		public WindModel wind { get; set; }
		public CloudsModel clouds { get; set; }
		public int dt { get; set; }
		public SysModel sys { get; set; }
		public int timezone { get; set; }
		public int id { get; set; }
		public string name { get; set; }
		public int cod { get; set; }
	}
}
