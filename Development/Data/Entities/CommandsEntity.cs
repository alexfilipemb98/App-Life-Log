using Data.Bases;
using DevExpress.Xpo;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Data.Entities
{
    /// <summary>
    /// Commands entity
    /// </summary>
    [Persistent(@"Commands")]
    [XmlRoot("Commands")]
    public class CommandsEntity : DataEntityBase
    {
        #region FOREIN KEYS

        private Guid fIdExternalProgram;
        [Persistent]
        [XmlElement("IdExternalProgram")]
        [Nullable(false)]
        public Guid IdExternalProgram
        {
            get => fIdExternalProgram;
            set => fIdExternalProgram = value;
        }

        private ExternalProgramsEntity fExternalProgram;
        [ForeignKey("IdExternalProgram")]
        [PersistentAlias(nameof(IdExternalProgram))]
        [DevExpress.Xpo.Association("ExternalProgram-Commands")]
        [Core.Atributes.Required]
        public ExternalProgramsEntity ExternalProgram
        {
            get => fExternalProgram;
            set
            {
                fExternalProgram = value;
                IdExternalProgram = value?.Id ?? Guid.Empty;
            }
        }

        #endregion

        #region PROPERTIES

        private string fName;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(13, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Name")]
        [Nullable(false)]
        [Size(13)]
        [DbType("nvarchar(13)")]
        public string Name
        {
            get => fName;
            set => fName = value;
        }

        private string fDescription;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(30, MinimumLength = 3)]
        [DataType(DataType.Text)]
        [XmlElement("Description")]
        [Nullable(false)]
        [Size(30)]
        [DbType("nvarchar(30)")]
        public string Description
        {
            get => fDescription;
            set => fDescription = value;
        }

        private string fType;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(10)]
        [DataType(DataType.Text)]
        [XmlElement("Type")]
        [Size(10)]
        [DbType("nvarchar(10)")]
        [Nullable(false)]
        public string Type
        {
            get => fType;
            set => fType = value;
        }

        string fCommand;
        [Core.Atributes.Required]
        [XmlElement("Command")]
        [DataType(DataType.Text)]
        [Size(SizeAttribute.Unlimited)]
        [Nullable(false)]
        [DbType("nvarchar(max)")]
        public string Command
        {
            get => fCommand;
            set => fCommand = value;
        }

        private bool fIsEnabled;
        [XmlElement("IsEnabled")]
        [Nullable(false)]
        public bool IsEnabled
        {
            get => fIsEnabled;
            set => fIsEnabled = value;
        }

        #endregion

        #region NOT MAPPED

        private dynamic icon;
        [NotMapped]
        [NonPersistent]
        public dynamic Icon
        {
            get => icon;
            set => icon = value;
        }

        #endregion
    }
}
