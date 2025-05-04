using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    /// <summary>
    /// Login object model
    /// </summary>
    public class LoginModel
    {
        #region PROPERTIES

        [Attributes.RequiredIf(nameof(IsNew), OperatorsEnum.Equal, true)]
        [Attributes.StringLength(20)]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Attributes.Required]
        [Attributes.EmailValidator]
        [Attributes.StringLength(250)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Attributes.Required]
        [Attributes.StringLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsNew { get; set; }

        #endregion
    }
}
