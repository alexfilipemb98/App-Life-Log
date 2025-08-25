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
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Name
		{
			get => fName;
			set => SetPropertyValue(nameof(Name), ref fName, value);
		}

		private string fFileExtension;
		[DevExpress.Xpo.Size(5)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(5)")]
		public string FileExtension
		{
			get => fFileExtension;
			set => SetPropertyValue(nameof(FileExtension), ref fFileExtension, value);
		}

		private string fPathToProgram;
		[DevExpress.Xpo.Size(400)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(400)")]
		public string PathToProgram
		{
			get => fPathToProgram;
			set => SetPropertyValue(nameof(PathToProgram), ref fPathToProgram, value);
		}

		private string fArguments;
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

		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdImage => Image != null ? Image.Id : System.Guid.Empty;

		#endregion

		#region ASSOCIATIONS

		[DevExpress.Xpo.Association(@"CommandsReferencesExternalProgram")]
		public System.Collections.Generic.IList<CommandsEntity> ExternalPrograms_Commands => GetList<CommandsEntity>(nameof(ExternalPrograms_Commands));

		#endregion
	}
}
