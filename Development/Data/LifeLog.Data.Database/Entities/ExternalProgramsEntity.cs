namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// External Programs
	/// </summary>
	[DevExpress.Xpo.Persistent(@"ExternalPrograms")]
	internal class ExternalProgramsEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		internal ExternalProgramsEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param fName="session"></param>
		internal ExternalProgramsEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES

		private string fName;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Name
		{
			get => fName;
			set => SetPropertyValue(nameof(Name), ref fName, value);
		}

		private string fFileExtension;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(5)]
		[DevExpress.Xpo.Size(5)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(5)")]
		public string FileExtension
		{
			get => fFileExtension;
			set => SetPropertyValue(nameof(FileExtension), ref fFileExtension, value);
		}

		private string fPathToProgram;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(400)]
		[DevExpress.Xpo.Size(400)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(400)")]
		public string PathToProgram
		{
			get => fPathToProgram;
			set => SetPropertyValue(nameof(PathToProgram), ref fPathToProgram, value);
		}

		private string fArguments;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.StringLength(150)]
		[DevExpress.Xpo.Size(150)]
		[DevExpress.Xpo.Nullable(true)]
		[DevExpress.Xpo.DbType("NVARCHAR(150)")]
		public string Arguments
		{
			get => fArguments;
			set => SetPropertyValue(nameof(Arguments), ref fArguments, value);
		}

		#endregion

		#region CLASS

		private ImagesEntity fImage;
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdImage")]
		[DevExpress.Xpo.Association(@"ExternalProgramsReferencesImages")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public ImagesEntity Image
		{
			get => fImage;
			set => SetPropertyValue(nameof(Image), ref fImage, value);
		}

		#endregion

		#region PROPERTIES NOT MAPED

		private dynamic icon;
		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[DevExpress.Xpo.NonPersistent]
		public dynamic Icon
		{
			get
			{
				if (icon == null && Image != null)
				{
					if (Image.IsSvg)
						return Image.SvgImage;
					else
						return Image.BitImage;
				}
				else
					return icon;
			}
			set => icon = value;
		}

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdImage => Image != null ? Image.Id : System.Guid.Empty;

		#endregion

		#region ASSOCIATIONS

		[DevExpress.Xpo.Association(@"CommandsReferencesExternalProgram")]
		public System.Collections.Generic.IList<CommandsEntity> ExternalPrograms_Commands => GetList<CommandsEntity>(nameof(ExternalPrograms_Commands));

		#endregion
	}
}
