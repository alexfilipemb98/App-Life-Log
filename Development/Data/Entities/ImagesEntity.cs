using Core.Atributes;
using Core.Enums;
using Data.Bases;
using DevExpress.Utils.Svg;
using DevExpress.Xpo;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Xml.Serialization;

namespace Data.Entities
{
    [Persistent(@"Images")]
    [XmlRoot("Images")]
    public class ImagesEntity : DataEntityBase
    {
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

        private byte[] fImageData;
        [Core.Atributes.Required]
        [Nullable(false)]
        [XmlElement("ImageData")]
        public byte[] ImageData
        {
            get => fImageData;
            set => fImageData = value;
        }

        private string fFileExtension;
        [Core.Atributes.Required]
        [Core.Atributes.StringLength(5)]
        [Nullable(false)]
        [DataType(DataType.Text)]
        [XmlElement("FileExtension")]
        [Size(5)]
        [DefaultValue(".notset")]
        [ColumnDefaultValue(".notset")]
        [DbType("nvarchar(5)")]
        public string FileExtension
        {
            get => fFileExtension;
            set => fFileExtension = value;
        }

        private bool fIsSvg;
        [XmlElement("IsSvg")]
        [ColumnDefaultValue("0")]
        public bool IsSvg
        {
            get => fIsSvg;
            set => fIsSvg = value;
        }

        private SvgImage fSvgImage;
        [NotMapped]
        [NonPersistent]
        [RequiredIf(nameof(IsSvg), OperatorsEnum.Equal, true)]
        public SvgImage SvgImage
        {
            get
            {
                if (fImageData != null && fImageData.Length > 0 && fIsSvg)
                    fSvgImage = Core.Utils.ImagesUtil.ArrayToSvgImage(fImageData);
                else
                    fSvgImage = null;

                return fSvgImage;
            }
        }

        private Bitmap fBitImage;
        [NotMapped]
        [NonPersistent]
        [RequiredIf(nameof(IsSvg), OperatorsEnum.Equal, false)]
        public Bitmap BitImage
        {
            get
            {
                if (fImageData != null && fImageData.Length > 0 && !fIsSvg)
                    fBitImage = Core.Utils.ImagesUtil.ArrayToBitmap(fImageData);
                else
                    fBitImage = null;

                return fBitImage;
            }
        }

        #region ASSOCIATIONS

        private List<ExternalProgramsEntity> fExternalPrograms;
        [DevExpress.Xpo.Association("ExternalPrograms-Images")]
        public List<ExternalProgramsEntity> ExternalPrograms
        {
            get => fExternalPrograms ?? new List<ExternalProgramsEntity>();
            set => fExternalPrograms = value;
        }

        private List<PasswordsEntity> fPasswords;
        [DevExpress.Xpo.Association("Passwords-Images")]
        public List<PasswordsEntity> Passwords
        {
            get => fPasswords ?? new List<PasswordsEntity>();
            set => fPasswords = value;
        }
        
        private List<PasswordTypes> fPasswordTypes;
        [DevExpress.Xpo.Association("PasswordTypes-Images")]
        public List<PasswordTypes> PasswordTypes
        {
            get => fPasswordTypes ?? new List<PasswordTypes>();
            set => fPasswordTypes = value;
        }

        #endregion
    }
}
