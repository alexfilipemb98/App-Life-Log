using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Flags
{
	[Flags]
	public enum FrontModulesFlag
	{
		Nenhuma = 0,

		HomeNotes = 1 << 0, //1
		HomeCommandsRunner = 1 << 1, //2
		HomePasswords = 1 << 2, //4
		HomeWeather = 1 << 3, //8
	}
}
