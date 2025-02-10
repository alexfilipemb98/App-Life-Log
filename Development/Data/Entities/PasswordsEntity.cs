using Data.Bases;
using DevExpress.Xpo;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Data.Entities
{
	[Persistent(@"Passwords")]
	[XmlRoot("Passwords")]
	public class PasswordsEntity : DataEntityBase
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
		[DevExpress.Xpo.Association("Passwords-Images")]
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
		public string Name
		{
			get => fName;
			set => fName = value;
		}

		private string fLoginUsername;
		[Core.Atributes.Required]
		[Core.Atributes.StringLength(250)]
		[Nullable(false)]
		[XmlElement("LoginUsername")]
		[DataType(DataType.Text)]
		[Size(250)]
        [DbType("nvarchar(250)")]
        public string LoginUsername
		{
			get => fLoginUsername;
			set => fLoginUsername = value;
		}

		private string fLoginPassword;
		[Core.Atributes.Required]
		[Core.Atributes.StringLength(400)]
		[Nullable(false)]
		[XmlElement("LoginPassword")]
		[DataType(DataType.Text)]
		[Size(400)]
        [DbType("nvarchar(400)")]
		public string LoginPassword
		{
			get => fLoginPassword;
			set => fLoginPassword = value;
		}

		private string fWebSite;
		[Core.Atributes.StringLength(250)]
		[XmlElement("WebSite")]
		[DataType(DataType.Url)]
		[Size(250)]
        [DbType("nvarchar(250)")]
        public string WebSite
		{
			get => fWebSite;
			set => fWebSite = value;
		}

		private string fNotes;
		[Core.Atributes.StringLength(500)]
		[XmlElement("Notes")]
		[DataType(DataType.Text)]
		[Size(500)]
        [DbType("nvarchar(500)")]
        public string Notes
		{
			get => fNotes;
			set => fNotes = value;
		}

		#endregion
	}
}