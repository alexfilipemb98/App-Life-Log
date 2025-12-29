using DevExpress.Utils.Serializing;
using DevExpress.XtraBars;
using LifeLog.Helpers.DesignTime;
using System.ComponentModel;

namespace LifeLog.Components;

[ToolboxItem(true)]
public class BarButtonItemEx : BarButtonItem
{
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new object Tag
	{
		get => base.Tag;
		set => base.Tag = value;
	}

	[Category("Navigation")]
	[Description("FullName do XtraUserControl em LifeLog.Views.* (guardado no Tag).")]
	[TypeConverter(typeof(ViewTypeNameConverter))] // o converter que lista os Views
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public string? TargetViewTypeName
	{
		get => base.Tag as string;
		set => base.Tag = value;
	}
}