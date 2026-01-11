using System;

namespace LifeLog.Services.Weather.Models
{
	public class DailySummaryModel
	{
		public DateTime Date { get; set; }
		public double MinTemp { get; set; }
		public double MaxTemp { get; set; }
		public string Icon { get; set; }
	}
}
