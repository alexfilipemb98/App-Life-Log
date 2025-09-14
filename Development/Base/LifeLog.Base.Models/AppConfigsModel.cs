using LifeLog.Base.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Base.Models
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

        [DataType(DataType.Text)]
        public string InternalApiUrl { get; set; }

        public bool InternalApiEnabled { get; set; }

        #endregion
    }
}