using System;
using System.ComponentModel;
using System.Linq;

namespace LifeLog.Base.Infrastructure.Enums
{
	/// <summary>
	/// Theme enums
	/// </summary>
	public enum ThemeEnum
	{
		[Description("System Theme")]
		SYSTEM,
		[Description("Dark Theme")]
		DARK,
		[Description("Light Theme")]
		LIGHT,
		[Description("Other Theme")]
		OTHER,
	}
}
