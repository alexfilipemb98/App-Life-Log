namespace LifeLog.Base.Models
{
	public class NotesModel : Bases.DataModelBase
	{
		public System.Guid IdUser { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
