using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Commands")]
	public class CommandsModel : Bases.DataModelBase
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Command { get; set; }
		public bool IsEnabled { get; set; }
		public UsersModel User { get; set; }
		public ExternalProgramsModel ExternalProgram { get; set; }
		public dynamic Icon { get; set; }
	}
}
