using LifeLog.Data.Database.Bases;
using System;

namespace LifeLog.Data.Database.Models
{
	public class VersionsModel : DataModelBase
	{
		public Guid ProgramId { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
	}
}
