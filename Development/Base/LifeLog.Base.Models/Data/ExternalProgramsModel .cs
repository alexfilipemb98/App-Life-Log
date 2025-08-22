using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
    [Table("ExternalPrograms")]
	public class ExternalProgramsModel : Bases.DataModelBase
	{

		public string Name { get; set; }
		public string FileExtension { get; set; }
		public string PathToProgram { get; set; }
		public string Arguments { get; set; }
		public ImagesModel Image { get; set; }
		public dynamic Icon { get; set; }
	}
}
