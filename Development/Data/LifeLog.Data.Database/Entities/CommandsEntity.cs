namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Commands
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Commands")]
	public class CommandsEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public CommandsEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="session"></param>
		public CommandsEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(13, MinimumLength = 3)]
		[DevExpress.Xpo.Size(13)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(13)")]
		public string Name { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Description { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		public string Command { get; set; }

		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("BIT")]
		public bool IsEnabled { get; set; }

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

		#region CLASS

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdUser")]
		[DevExpress.Xpo.Association(@"CommandsReferencesUsers")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public UsersEntity User { get; set; }

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdExternalProgram")]
		[DevExpress.Xpo.Association(@"CommandsReferencesExternalProgram")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public ExternalProgramsEntity ExternalProgram { get; set; }

		#endregion
	}
}
