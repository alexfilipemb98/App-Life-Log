using LifeLog.Data.Database.Bases;
using System;

namespace LifeLog.Data.Database.Models
{
	public class ExternalProgramsModel : DataModelBase
	{
		public string Name { get; set; }
		public string FileExtension { get; set; }
		public string PathToProgram { get; set; }
		public string Arguments { get; set; }
		public Guid IdUser { get; set; }
		public Guid IdImage { get; set; }
		public dynamic Icon { get; set; }
	}
}
