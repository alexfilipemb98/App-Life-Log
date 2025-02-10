using Data.Bases;
using DevExpress.Xpo;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Data.Entities
{
    [Persistent(@"Notes")]
    [XmlRoot("Notes")]
    public class NotesEntity : DataEntityBase
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

        string fText;
        [Core.Atributes.Required]
        [Nullable(false)]
        [XmlElement("Text")]
        [DataType(DataType.Text)]
        [Size(SizeAttribute.Unlimited)]
        [DbType("nvarchar(max)")]
        public string Text
        {
            get => fText;
            set => fText = value;
        }

    }
}