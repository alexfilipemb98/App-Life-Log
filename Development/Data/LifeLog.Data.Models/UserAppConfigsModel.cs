using LifeLog.Base.Models;
using LifeLog.Data.Models.Bases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Models
{
	[Table("UserAppConfigs")]
	[Description("Database model for user app configs")]
	public class UserAppConfigsModel : DataModelBase
	{
		#region PROPERTIES
		
		public long FrontModules { get; set; }
		
		public int FrontFormWidth { get; set; }

		public int FrontFormHeight { get; set; }
		
		public int FrontFormState { get; set; }

		#endregion

		#region CLASS

		[JsonIgnore]
		[Base.Infrastructure.Attributes.Required]
		public LoggedUserModel User { get; set; }

		#endregion
	}
}
