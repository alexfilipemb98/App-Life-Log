using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models
{
	[Table("Versions")]
	[Description("Database model for versions")]
	public class VersionsModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[Base.Infrastructure.Attributes.Required]
		public System.Guid ProgramId { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(50, MinimumLength = 3)]
		public string Name { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(20)]
		public string Version { get; set; } 

		#endregion
	}
}
