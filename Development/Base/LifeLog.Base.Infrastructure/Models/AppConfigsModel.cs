using LifeLog.Base.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Base.Infrastructure.Models
{
    /// <summary>
    /// Application Configs Model
    /// </summary>
    public class AppConfigsModel
    {
        #region PROPERTIES

        [EnumDataType(typeof(DatabaseTypeEnum))]
        public ThemeEnum Theme { get; set; }

        [DataType(DataType.Text)]
        public string LastEmail { get; set; }

        public int MainFormWidth { get; set; }

        public int MainFormHeight { get; set; }

        [Attributes.Range(0, 2)]
        public int MainFormWindowState { get; set; }

        [DataType(DataType.Text)]
        public string InternalApiUrl { get; set; }

        public bool InternalApiEnabled { get; set; }

        #endregion
    }
}