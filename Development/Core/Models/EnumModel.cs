using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Enum Model
    /// </summary>
    public class EnumModel
    {
        #region PROPERTIES

        private string type;
        [DataType(DataType.Text)]
        [Core.Atributes.StringLength(100)]
        public string Type
        {
            get => type; set => type = value;
        }

        private string description;
        [DataType(DataType.Text)]
        [Core.Atributes.StringLength(200)]
        public string Description
        {
            get => description;
            set => description = value;
        } 
        #endregion
    }
}
