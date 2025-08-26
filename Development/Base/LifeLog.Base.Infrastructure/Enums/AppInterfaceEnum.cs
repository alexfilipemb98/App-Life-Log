using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Enums
{
	/// <summary>
	/// App interface enum
	/// </summary>
	public enum AppInterfaceEnum
	{
		[Description("Front End")]
		FrontEnd,
		[Description("Back End")]
		BackEnd,
	}
}
