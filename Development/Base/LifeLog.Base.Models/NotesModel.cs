namespace LifeLog.Base.Models
{
	public class NotesModel : Bases.DataModelBase
	{
		public UsersModel User { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
