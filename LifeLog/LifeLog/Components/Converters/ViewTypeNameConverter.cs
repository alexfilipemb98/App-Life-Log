using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;

namespace LifeLog.Helpers.DesignTime;

public sealed class ViewTypeNameConverter : StringConverter
{
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		var discovery = context?.GetService(typeof(ITypeDiscoveryService)) as ITypeDiscoveryService;

		var values = (discovery?.GetTypes(typeof(XtraUserControl), true).Cast<Type>()
					 ?? AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => {
						 try { return a.GetTypes(); } catch { return Array.Empty<Type>(); }
					 }))
			.Where(t => t.IsClass && !t.IsAbstract
						&& typeof(XtraUserControl).IsAssignableFrom(t)
						&& (t.Namespace?.StartsWith("LifeLog.Views", StringComparison.Ordinal) ?? false))
			.OrderBy(t => t.Name)
			.Select(t => t.FullName!)  
			.ToArray();

		return new StandardValuesCollection(values);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			var s = value as string;
			if (string.IsNullOrWhiteSpace(s)) return "(none)";
			return s.Split('.').Last();
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string s)
		{
			if (s == "(none)" || string.IsNullOrWhiteSpace(s)) return null!;

			if (s.Contains('.')) return s;

			var all = GetStandardValues(context).Cast<string>();
			var match = all.FirstOrDefault(fn => fn.EndsWith("." + s, StringComparison.OrdinalIgnoreCase));
			return match ?? s;
		}

		return base.ConvertFrom(context, culture, value);
	}
}
