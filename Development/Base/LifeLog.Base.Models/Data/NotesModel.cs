using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Notes")]
	public class NotesModel : Bases.DataModelBase
	{
		public LoggedUserModel User { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
