using LifeLog.Data.Database.Bases;
using System;

namespace LifeLog.Data.Database.Models
{
	public class CommandsModel : DataModelBase
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Command { get; set; }
		public bool IsEnabled { get; set; }
		public Guid IdUser { get; set; }
		public Guid IdExternalProgram { get; set; }
		public dynamic Icon { get; set; }
	}
}
