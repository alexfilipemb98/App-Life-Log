using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Models
{
	[Table("Passwords")]
	[Description("Database model for passwords")]
	public class PasswordsModel : Bases.DataModelBase
	{
	}
}
