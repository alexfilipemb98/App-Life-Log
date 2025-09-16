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

		Notes = 1 << 0, //1
		CommandsRunner = 1 << 1, //2
		Passwords = 1 << 2, //4
		Weather = 1 << 3, //8
		RollDice = 1 << 4, //16
		CoinFlip = 1 << 5, //32
		TicTacToe = 1 << 6, //64
		PasswordsGenerator  = 1 << 7, // 128
		PdfMerger = 1 << 8, // 256
		GradesCalculator = 1 << 9, //512
		ConvertText = 1 << 10, // 1024
		FormOut = 1 << 11, //2048
		ThreeSimpleRule  = 1 << 12, // 4096
	}
}
