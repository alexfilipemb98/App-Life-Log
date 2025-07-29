using Components;
using Data.ORM.DataModelCode;
using DevExpress.XtraEditors;
using Life_Log_App.Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log_App.Views.Tables.ExternalPrograms
{
	/// <summary>
	/// External Programs Detail View
	/// </summary>
	public partial class ExternalProgramsDetailView : UserControlBase<ORM_ExternalPrograms>
	{
		#region MAIN

		/// <summary>
		/// External Programs Detail View
		/// </summary>
		public ExternalProgramsDetailView() => InitializeComponent();

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Sets the data to the control
		/// </summary>
		/// <param name="data"></param>
		public override void SetData(ORM_ExternalPrograms data)
		{
			if (data == null)
			{
				data = new ORM_ExternalPrograms();
				data.User = AppContext.CurrentUser;
			}

			xpbsExternalPrograms.DataSource = data;
		}

		/// <summary>
		/// Save data
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public override bool SaveData(out ORM_ExternalPrograms data)
		{
			((CurrencyManager)this.BindingContext[xpbsExternalPrograms])?.EndCurrentEdit();

			data = xpbsExternalPrograms.DataSource as ORM_ExternalPrograms;

			if (!ValidationHelper.ValidateModelAndSetError(data, dxErrorProvider, dataLayoutControl))
				return false;

			bool saved = AppContext.DataEngine.ExternalPrograms.Save(data, out string message);
			AppHelper.StatusMessage(message, saved);

			return saved;
		}

		#endregion
	}
}
