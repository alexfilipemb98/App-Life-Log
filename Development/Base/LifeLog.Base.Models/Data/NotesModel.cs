namespace LifeLog.Base.Models.Data
{
	public class NotesModel : Bases.DataModelBase
	{
		public LoggedUserModel User { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
