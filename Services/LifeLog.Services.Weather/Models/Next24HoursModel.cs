using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Services.Weather.Models
{
	public class Next24HoursModel
	{
		public DateTime Time { get; set; }
		public double Temp { get; set; }
	}
}
