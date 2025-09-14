using DevExpress.XtraEditors;
using LifeLog.Base.Infrastructure.Flags;
using LifeLog.Base.Utils;
using LifeLog.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.FrontEnd.Views.Settings
{
	public partial class ModulesSettingView : DevExpress.XtraEditors.XtraUserControl
	{
		public ModulesSettingView() => InitializeComponent();

		public Action<long> OnSavedModules { get; internal set; }

		private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			long valor = 0;

			if (tsNotes.IsOn)
				valor |= (long)FrontModulesFlag.HomeNotes;

			if (tsCommandsRunner.IsOn)
				valor |= (long)FrontModulesFlag.HomeCommandsRunner;

			if (tsPasswords.IsOn)
				valor |= (long)FrontModulesFlag.HomePasswords;

			if (tsWeather.IsOn)
				valor |= (long)FrontModulesFlag.HomeWeather;

			OnSavedModules?.Invoke(valor);
		}

		public void LoadData(long valor)
		{
			tsNotes.IsOn = FrontModulesFlag.HomeNotes.IsActive(valor);
			tsCommandsRunner.IsOn = FrontModulesFlag.HomeCommandsRunner.IsActive(valor);
			tsPasswords.IsOn = FrontModulesFlag.HomePasswords.IsActive(valor);
			tsWeather.IsOn = FrontModulesFlag.HomeWeather.IsActive(valor);
		}
	}
}
