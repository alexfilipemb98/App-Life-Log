using Data.Bases;
using DevExpress.Xpo;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Data.Entities
{
    /// <summary>
    /// Entity for the Versions table
    /// </summary>
    [Persistent(@"Versions")]
    [XmlRoot("Versions")]
    public class VersionsEntity : DataEntityBase
    {
        #region PROPERTIES

        private Guid fProgramId;
        [XmlElement("ProgramId")]
        [DbType("uniqueidentifier")]
        public Guid ProgramId 
        { 
            get => fProgramId; 
            set => fProgramId = value; 
        }

        private string fProgramName;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(150, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Name")]
        [Nullable(false)]
        [Size(150)]
        [DbType("nvarchar(150)")]
        public string ProgramName
        {
            get => fProgramName;
            set => fProgramName = value;
        }

        private string fVersion;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(50, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Version")]
        [Nullable(false)]
        [Size(50)]
        [DbType("nvarchar(50)")]
        public string Version
        {
            get => fVersion;
            set => fVersion = value;
        }

        #endregion
    }
}
