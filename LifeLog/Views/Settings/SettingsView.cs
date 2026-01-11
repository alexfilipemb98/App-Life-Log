using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeLog.Forms;

public partial class SettingsView : DevExpress.XtraEditors.XtraUserControl
{
    public SettingsView() => InitializeComponent();

    private void SettingsView_Load(object sender, EventArgs e)
    {
        externalProgramsList.LoadData();
    }
}
