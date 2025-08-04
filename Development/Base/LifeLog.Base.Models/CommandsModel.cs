namespace LifeLog.Base.Models
{
	public class CommandsModel : Bases.DataModelBase
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Command { get; set; }
		public bool IsEnabled { get; set; }
		public System.Guid IdUser { get; set; }
		public System.Guid IdExternalProgram { get; set; }
		public System.Guid IdImage { get; set; }
		public dynamic Icon { get; set; }
	}
}
