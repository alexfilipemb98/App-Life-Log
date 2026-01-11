namespace LifeLog.Forms.Others;

public partial class ThreeSimpleRuleForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
	public ThreeSimpleRuleForm()
	{
		InitializeComponent();
	}

	private void teA2Value_EditValueChanged(object sender, EventArgs e)
	{
		if (teAValue.EditValue != null && teBValue.EditValue != null && teA2Value.EditValue != null)
			teResult.Text = (((decimal)teBValue.EditValue * (decimal)teA2Value.EditValue) / (decimal)teAValue.EditValue).ToString();
	}
}