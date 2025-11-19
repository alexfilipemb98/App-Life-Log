using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Services.WeatherApi.Models
{
	public class WindModel
	{
		[JsonProperty("speed")]
		public float Speed { get; set; }

		[JsonProperty("deg")]
		public int Deg { get; set; }
	}
}
