using LifeLog.Base.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models
{
	[Table("Notes")]
	[Description("Database model for notes")]
	public class NotesModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Title { get; set; }

		[DataType(DataType.MultilineText)]
		public string Text { get; set; }

		[Base.Infrastructure.Attributes.StringLength(20)]
		public int Color { get; set; }

		[JsonIgnore]
		public short Position { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[Base.Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; } 
		
		#endregion
	}
}
