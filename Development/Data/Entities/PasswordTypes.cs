using Data.Bases;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Entities
{
    /// <summary>
    /// Password types entity
    /// </summary>
    public class PasswordTypes : DataEntityBase
    {
        #region FOREIN KEYS

        private Guid fIdImage;
        [Persistent]
        [XmlElement("IdImage")]
        [Nullable(false)]
        public Guid IdImage
        {
            get => fIdImage == Guid.Empty ? fImage == null ? Guid.Empty : fImage.Id : fIdImage;
            set => fIdImage = value;
        }

        private ImagesEntity fImage;
        [ForeignKey("ImageId")]
        [PersistentAlias(nameof(IdImage))]
        [DevExpress.Xpo.Association("PasswordTypes-Images")]
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

        #endregion
    }
}
