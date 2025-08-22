using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Interfaces
{
	/// <summary>
	/// Shows the form for the engine.
	/// </summary>
	public interface IEngineForm
	{
		/// <summary>
		/// Ribbon 
		/// </summary>
		RibbonForm MainForm { get; }

		/// <summary>
		/// If user is loging out
		/// </summary>
		bool IsUserLogingout { get; set; } 

		/// <summary>
		/// Set status
		/// </summary>
		/// <param name="status"></param>
		/// <param name="isInvalid"></param>
		void SetLabelStatus(string status, Color color);
	}
}
