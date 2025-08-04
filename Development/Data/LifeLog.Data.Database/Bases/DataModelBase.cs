using System;

namespace LifeLog.Data.Database.Bases
{
	public class DataModelBase
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		// Utilitário
		public bool EditingMode => Id != Guid.Empty;
	}
}
