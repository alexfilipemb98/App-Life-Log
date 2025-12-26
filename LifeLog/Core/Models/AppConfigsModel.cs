using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace Core.Models;

/// <summary>
/// Application Configs Model
/// </summary>
public class AppConfigsModel
{
	#region PROPERTIES

	#region THEME

	[EnumDataType(typeof(DatabaseTypeEnum))]
	public ThemeEnum Theme { get; set; }

	[DataType(DataType.Text)]
	public string? SkinName { get; set; }

	[DataType(DataType.Text)]
	public string? PaletteName { get; set; }

	public Color SkinMaskColor { get; set; }

	public Color SkinMaskColor2 { get; set; }

	#endregion

	[DataType(DataType.Text)]
	public string? LastEmail { get; set; }

	#endregion
}
