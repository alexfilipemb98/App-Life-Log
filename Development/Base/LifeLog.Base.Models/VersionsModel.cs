namespace LifeLog.Base.Models
{
	public class VersionsModel : Bases.DataModelBase
	{
		public System.Guid ProgramId { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
	}
}
