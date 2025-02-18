using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    /// <summary>
    /// Login object model
    /// </summary>
    public class LoginModel
    {
        #region PROPERTIES

        private string fUsername;
        [Core.Atributes.StringLength(20)]
        [Core.Atributes.RequiredIf(nameof(IsNew), OperatorsEnum.Equal, true)]
        [DataType(DataType.Text)]
        public string Username { get => fUsername; set => fUsername = value; }

        private string fEmail;
        [Core.Atributes.Required]
        [Core.Atributes.EmailValidator]
        [Core.Atributes.StringLength(250)]
        [DataType(DataType.EmailAddress)]
        public string Email { get => fEmail; set => fEmail = value; }

        private string fPassword;
        [Core.Atributes.StringLength(30)]
        [Core.Atributes.Required]
        [DataType(DataType.Password)]
        public string Password { get => fPassword; set => fPassword = value; }

        private bool fIsNew;
        public bool IsNew
        {
            get => fIsNew; set => fIsNew = value;
        }

        #endregion
    }
}
