using System;

namespace LifeLog.Base.Models.Bases
{
	public class DataModelBase
	{
		[System.ComponentModel.DataAnnotations.Key]	
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public bool EditingMode { get; set; }
	}
}
