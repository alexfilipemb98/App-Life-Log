using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
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

        public int MainFormWindowState { get; set; }

        #endregion
    }
}