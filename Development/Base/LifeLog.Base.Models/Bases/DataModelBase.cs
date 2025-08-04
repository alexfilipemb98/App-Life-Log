using System;

namespace LifeLog.Base.Models.Bases
{
	public class DataModelBase
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public bool EditingMode { get; set; }
	}
}
