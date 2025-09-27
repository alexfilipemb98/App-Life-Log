using System.Drawing;

namespace LifeLog.Services.WeatherApi.Models
{
	public class WeatherModel
	{
		public Bitmap image;
		public int id { get; set; }
		public string main { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
	}
}
