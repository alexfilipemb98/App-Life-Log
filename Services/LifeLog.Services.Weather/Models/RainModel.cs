using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Services.Weather.Models
{
	public class RainModel
	{
		[JsonProperty("3h")]
		public float ThreeHour { get; set; }

		[JsonProperty("1h")]
		public float OneHour { get; set; }
	}
}
