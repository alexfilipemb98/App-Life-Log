using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Application Configs Model
    /// </summary>
    public class AppConfigsModel
    {
        #region PROPERTIES

        private ThemeEnum fTheme;
        [EnumDataType(typeof(DatabaseTypeEnum))]
        public ThemeEnum Theme
        {
            get => fTheme;
            set => fTheme = value;
        }

        private string fLastEmail;

        [DataType(DataType.Text)]
        public string LastEmail
        {
            get => fLastEmail;
            set => fLastEmail = value;
        }

        private int fFormWidth;
        public int FormWidth
        { 
            get => fFormWidth; 
            set => fFormWidth = value; 
        }

        private int fFormHeight;
        public int FormHeight 
        {
            get => fFormHeight; 
            set => fFormHeight = value; 
        }

        #endregion
    }
}
