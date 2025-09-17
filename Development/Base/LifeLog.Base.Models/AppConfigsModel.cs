using LifeLog.Base.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace LifeLog.Base.Models
{
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
        public string SkinName { get; set; }

        [DataType(DataType.Text)]
        public string PaletteName { get; set; }

        public Color SkinMaskColor { get; set; }

        public Color SkinMaskColor2 { get; set; }

        #endregion

        [DataType(DataType.Text)]
        public string LastEmail { get; set; }

        #endregion
    }
}