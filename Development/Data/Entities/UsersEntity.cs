using Data.Bases;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Entities
{
    /// <summary>
    /// Users Entity
    /// </summary>
    [Persistent(@"Users")]
    [XmlRoot("Users")]
    public class UsersEntity : DataEntityBase
    {
        #region PROPERTIES
       
        private string fUsername;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Username")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string Username
        {
            get => fUsername;
            set => fUsername = value;
        }

        private string fSalt;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Salt")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string Salt
        {
            get => fSalt;
            set => fSalt = value;
        }

        private string fPassword;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Password")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string Password
        {
            get => fPassword;
            set => fPassword = value;
        }

        private string fEmail;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Email")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string Email
        {
            get => fEmail;
            set => fEmail = value;
        }
        
        #endregion
    }
}
