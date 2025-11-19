using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Services.WeatherApi.Models
{
	public class SysModel
	{
		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("sunrise")]
		public int Sunrise { get; set; }

		[JsonProperty("sunset")]
		public int Sunset { get; set; }
	}
}
