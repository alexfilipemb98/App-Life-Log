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
	public class UserAppConfigsModel
	{
		public long FrontModules { get; set; }
	}
}
