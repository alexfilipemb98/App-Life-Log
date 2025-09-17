using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using System;
using System.Drawing;
using System.Linq;

namespace LifeLog.UI.Common.Helpers
{
	/// <summary>
	/// Theme helper class
	/// </summary>
	public class ThemeHelper
	{

		/// <summary>
		/// Apply theme
		/// </summary>
		public static void ApplyTheme()
		{
			if (AppSession.AppConfigs.Theme != ThemeEnum.OTHER)
			{
				switch (AppSession.AppConfigs.Theme)
				{
					case ThemeEnum.DARK:
						UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");
						break;
					case ThemeEnum.LIGHT:
						UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "LIGHT");
						break;
					case ThemeEnum.SYSTEM:
					default:
						if (WindowsUtil.GetWindowsTheme() == 0)
							UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "DARK");
						else
							UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, "LIGHT");
						break;
				}
			}
			else
			{
				UserLookAndFeel lnf = UserLookAndFeel.Default;
				var skinName = string.IsNullOrWhiteSpace(AppSession.AppConfigs?.SkinName) ? lnf.SkinName : AppSession.AppConfigs.SkinName;

				if (!string.IsNullOrWhiteSpace(AppSession.AppConfigs?.PaletteName))
				{
					try
					{
						lnf.SetSkinStyle(skinName, AppSession.AppConfigs.PaletteName);
					}
					catch
					{
						lnf.SetSkinStyle(skinName);
					}
				}
				else
				{
					lnf.SetSkinStyle(skinName);
				}

				if (AppSession.AppConfigs != null)
				{
					lnf.SkinMaskColor = AppSession.AppConfigs.SkinMaskColor;
					lnf.SkinMaskColor2 = AppSession.AppConfigs.SkinMaskColor2;
				}
			}
		}

		/// <summary>
		/// Capture current theme settings
		/// </summary>
		public static void Capture()
		{
			AppSession.AppConfigs.SkinName = UserLookAndFeel.Default.SkinName;
			AppSession.AppConfigs.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
			AppSession.AppConfigs.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
			AppSession.AppConfigs.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
		}

		/// <summary>
		/// Lê Background +200/+100/0/-100/-200 da palete SVG ativa.
		/// Se não existir a entrada, devolve Color.Empty, a menos que allowAliases=true.
		/// </summary>
		public static (Color Bg200, Color Bg100, Color Bg0, Color BgMinus100, Color BgMinus200)
			GetBackgroundVariants(UserLookAndFeel lf = null, bool allowAliases = true)
		{
			UserLookAndFeel look = lf ?? UserLookAndFeel.Default;
			Skin skin = CommonSkins.GetSkin(look);

			SvgPalette palette = null;
			try
			{
				// 1) ativa
				if (!string.IsNullOrWhiteSpace(look.ActiveSvgPaletteName))
				{
					try { palette = skin.SvgPalettes[look.ActiveSvgPaletteName]; } catch { }
					if (palette == null)
					{
						try { palette = skin.CustomSvgPalettes[look.ActiveSvgPaletteName]; } catch { }
					}
				}
				// 2) primeira existente (se nada ativo)
				if (palette == null)
					palette = skin?.SvgPalettes?.FirstOrDefault().Value
							  ?? skin?.CustomSvgPalettes?.FirstOrDefault().Value;
			}
			catch { /* fica null => retorna Empty */ }

			if (palette == null)
				return (Color.Empty, Color.Empty, Color.Empty, Color.Empty, Color.Empty);

			// leitor seguro com aliases opcionais
			Color Get(string name)
			{
				var item = palette.Colors.FirstOrDefault(c =>
					string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));

				if (item != null)
					return item.Value;

				if (!allowAliases) return Color.Empty;

				string[] aliasCandidates;

				switch (name)
				{
					case "Background 200":
						aliasCandidates = new[] { "Paint High", "Surface High", "Surface Light" };
						break;

					case "Background 100":
						aliasCandidates = new[] { "Paint", "Surface", "Card" };
						break;

					case "Background 0":
						aliasCandidates = new[] { "Paint", "Surface", "Base" };
						break;

					case "Background -100":
						aliasCandidates = new[] { "Paint Shadow", "Surface Shadow" };
						break;

					case "Background -200":
						aliasCandidates = new[] { "Paint Deep Shadow", "Surface Deep Shadow", "Shadow" };
						break;

					default:
						aliasCandidates = Array.Empty<string>();
						break;
				}

				foreach (var alias in aliasCandidates)
				{
					var a = palette.Colors.FirstOrDefault(c =>
						string.Equals(c.Name, alias, StringComparison.OrdinalIgnoreCase));
					if (a != null) return a.Value;
				}

				return Color.Empty;
			}

			return (
				Get("Background 200"),
				Get("Background 100"),
				Get("Background 0"),
				Get("Background -100"),
				Get("Background -200")
			);
		}
	}
}
