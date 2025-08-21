namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Commands
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Commands")]
	internal class CommandsEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		internal CommandsEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param fName="session"></param>
		internal CommandsEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES
		
		private string fName;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(13, MinimumLength = 3)]
		[DevExpress.Xpo.Size(13)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(13)")]
		public string Name
		{
			get => fName;
			set => SetPropertyValue(nameof(Name), ref fName, value);
		}

		private string fDescription;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Description
		{
			get => fDescription;
			set => SetPropertyValue(nameof(Description), ref fDescription, value);
		}

		private string fCommand;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		public string Command
		{
			get => fCommand;
			set => SetPropertyValue(nameof(Command), ref fCommand, value);
		}

		private bool fIsEnabled;
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("BIT")]
		public bool IsEnabled
		{
			get => fIsEnabled;
			set => SetPropertyValue(nameof(IsEnabled), ref fIsEnabled, value);
		}

		#endregion

		#region CLASS

		private UsersEntity fUser;
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdUser")]
		[DevExpress.Xpo.Association(@"CommandsReferencesUsers")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public UsersEntity User
		{
			get => fUser;
			set => SetPropertyValue(nameof(User), ref fUser, value);
		}

		private ExternalProgramsEntity fExternalProgram;
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdExternalProgram")]
		[DevExpress.Xpo.Association(@"CommandsReferencesExternalProgram")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public ExternalProgramsEntity ExternalProgram
		{
			get => fExternalProgram;
			set => SetPropertyValue(nameof(ExternalProgram), ref fExternalProgram, value);
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
				if (icon == null && ExternalProgram != null && ExternalProgram.Image != null)
				{
					if (ExternalProgram.Image.IsSvg)
						return ExternalProgram.Image.SvgImage;
					else
						return ExternalProgram.Image.BitImage;
				}
				else
					return icon;
			}
			set => icon = value;
		}

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdUser => User != null ? User.Id : System.Guid.Empty;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdExternalProgram => ExternalProgram != null ? ExternalProgram.Id : System.Guid.Empty;

		#endregion
	}
}
