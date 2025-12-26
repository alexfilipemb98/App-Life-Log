using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeLog.Forms;
public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void bbiShowSettings_ItemClick(object sender, ItemClickEventArgs e)
	{
		ribbon.ShowApplicationButtonContentControl();
	}
}