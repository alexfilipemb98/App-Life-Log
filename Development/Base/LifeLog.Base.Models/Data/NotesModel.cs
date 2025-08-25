using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Notes")]
	public class NotesModel : Bases.DataModelBase
	{
		#region PROPERTIES

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		public string Title { get; set; }

		[DataType(DataType.MultilineText)]
		[Infrastructure.Attributes.StringLength(4000)]
		public string Text { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[DataType(DataType.Custom)]
		[Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; } 
		
		#endregion
	}
}
