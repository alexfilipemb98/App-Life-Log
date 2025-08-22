using LifeLog.Base.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Base.Models
{
    /// <summary>
    /// Auth object model
    /// </summary>
    public class AuthModel
    {
        #region PROPERTIES

        [Infrastructure.Attributes.RequiredIf(nameof(IsNew), OperatorsEnum.Equal, true)]
        [Infrastructure.Attributes.StringLength(20)]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Infrastructure.Attributes.Required]
        [Infrastructure.Attributes.EmailValidator]
        [Infrastructure.Attributes.StringLength(250)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Infrastructure.Attributes.Required]
        [Infrastructure.Attributes.StringLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsNew { get; set; }

        #endregion
    }
}
