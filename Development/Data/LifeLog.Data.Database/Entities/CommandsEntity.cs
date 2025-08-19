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
		/// <param name="session"></param>
		internal CommandsEntity(DevExpress.Xpo.Session session) : base(session)
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
		internal string Name { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		internal string Description { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		internal string Command { get; set; }

		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("BIT")]
		internal bool IsEnabled { get; set; }

		#endregion

		#region PROPERTIES NOT MAPED

		private dynamic icon;
		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[DevExpress.Xpo.NonPersistent]
		internal dynamic Icon
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
		internal System.Guid IdUser => User != null ? User.Id : System.Guid.Empty;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		internal System.Guid IdExternalProgram => ExternalProgram != null ? ExternalProgram.Id : System.Guid.Empty;

		#endregion

		#region CLASS

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdUser")]
		[DevExpress.Xpo.Association(@"CommandsReferencesUsers")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		internal UsersEntity User { get; set; }

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdExternalProgram")]
		[DevExpress.Xpo.Association(@"CommandsReferencesExternalProgram")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		internal ExternalProgramsEntity ExternalProgram { get; set; }

		#endregion
	}
}
