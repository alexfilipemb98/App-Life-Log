using System;
using System.Linq;

namespace Core.Models
{
    /// <summary>
    /// Enum Model
    /// </summary>
    public class EnumModel
    {
        #region PROPERTIES

        [Attributes.StringLength(100)]
        [Attributes.Required]
        public string? Type { get; set; }

        [Attributes.StringLength(200)]
        [Attributes.Required]
        public string? Description { get; set; }

        #endregion
    }
}
