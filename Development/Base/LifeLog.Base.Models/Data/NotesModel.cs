using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Notes")]
	[Description("Database model for notes")]
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

		[Infrastructure.Attributes.StringLength(20)]
		public int Color { get; set; }

		[JsonIgnore]
		public short Position { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; } 
		
		#endregion
	}
}
