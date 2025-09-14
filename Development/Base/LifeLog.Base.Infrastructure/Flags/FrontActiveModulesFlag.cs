using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Flags
{
	[Flags]
	public enum FrontActiveModulesFlag
	{
		Nenhuma = 0,

		HomeNotes = 1 << 0, //1
		HomeCommandsRunner = 1 << 1, //2
	}


	public static bool IsAtive<T>(this T perm, T permissoes)
	{
		return (permissoes & perm) != perm;
	}
}
