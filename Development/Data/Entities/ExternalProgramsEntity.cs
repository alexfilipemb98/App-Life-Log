using Data.Bases;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Serialization;

namespace Data.Entities
{
    /// <summary>
    /// External programs entity
    /// </summary>
    [Persistent(@"ExternalPrograms")]
    [XmlRoot("ExternalPrograms")]
    public class ExternalProgramsEntity : DataEntityBase
    {
        #region FOREIN KEYS

        private Guid fIdImage;
        [Persistent]
        [XmlElement("IdImage")]
        [Nullable(false)]
        public Guid IdImage
        {
            get => fIdImage == Guid.Empty && fImage != null ? fImage.Id : Guid.Empty;
            set => fIdImage = value;
        }

        private ImagesEntity fImage;
        [ForeignKey("ImageId")]
        [PersistentAlias(nameof(IdImage))]
        [DevExpress.Xpo.Association("ExternalPrograms-Images")]
        public ImagesEntity Image
        {
            get => fImage;
            set => fImage = value;
        }

        #endregion

        #region PROPERTIES

        private string fName;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(50, MinimumLength = 3)]
        [Nullable(false)]
        [DataType(DataType.Text)]
        [XmlElement("Name")]
        [Size(50)]
        [DbType("nvarchar(50)")]
        public string Name
        {
            get => fName;
            set => fName = value;
        }

        private string fFileExtension;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(5)]
        [Nullable(false)]
        [DataType(DataType.Text)]
        [XmlElement("FileExtension")]
        [Size(5)]
        [DbType("nvarchar(5)")]
        public string FileExtension
        {
            get => fFileExtension;
            set => fFileExtension = value;
        }

        private string fPathToProgram;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(400)]
        [Nullable(false)]
        [XmlElement("PathToProgram")]
        [DataType(DataType.Text)]
        [Size(400)]
        [DbType("nvarchar(400)")]
        public string PathToProgram
        {
            get => fPathToProgram;
            set => fPathToProgram = value;
        }

        private string fArguments;
        [Core.Atributes.StringLength(110)]
        [XmlElement("Arguments")]
        [DataType(DataType.Text)]
        [Size(110)]
        [DbType("nvarchar(110)")]
        public string Arguments
        {
            get => fArguments;
            set => fArguments = value;
        }

        #endregion

        #region ASSOCIATIONS

        private List<CommandsEntity> fCommands;
        [DevExpress.Xpo.Association("ExternalProgram-Commands")]
        public List<CommandsEntity> Commands
        {
            get
            {
                if (fCommands == null)
                {
                    fCommands = new List<CommandsEntity>();
                }
                return fCommands;
            }
            set => fCommands = value;
        }

        #endregion

    }
}
