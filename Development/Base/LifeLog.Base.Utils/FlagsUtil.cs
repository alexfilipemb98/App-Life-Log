using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Utils
{
	public static class FlagsUtil
	{
		public static bool IsActive<T>(this T perm, long valor) where T : Enum
		{
			long p = Convert.ToInt64(perm);
			long ps = valor;

			return (ps & p) == p;
		}
	}
}
