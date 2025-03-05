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
    /// Rdp Entity
    /// </summary>
    [Persistent(@"RdpConnections")]
    [XmlRoot("RdpConnections")]
    public class RdpConnectionsEntity : DataEntityBase
    {
        #region PROPERTIES

        private string fName;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Name")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string Name
        {
            get => fName;
            set => fName = value;
        }

        private string fAddress;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(250, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Address")]
        [Nullable(false)]
        [Size(250)]
        [DbType("nvarchar(250)")]
        public string Address 
        { 
            get => fAddress; 
            set => fAddress = value; 
        }

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
        
        private string fPassword;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(650, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Password")]
        [Nullable(false)]
        [Size(650)]
        [DbType("nvarchar(650)")]
        public string Password
        {
            get => fPassword;
            set => fPassword = value;
        }

        #endregion
    }
}
