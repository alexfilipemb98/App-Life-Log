using LifeLog.Base.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models
{
	[Table("Tasks")]
	[Description("Database model for tasks")]
	public class TasksModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(350, MinimumLength = 3)]
		public string Description { get; set; }

		public bool IsDone { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[Base.Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; }

		#endregion

	}
}
