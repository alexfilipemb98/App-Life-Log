using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Versions")]
	public class VersionsModel : Bases.DataModelBase
	{
		public System.Guid ProgramId { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
	}
}
