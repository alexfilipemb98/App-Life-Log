namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Users entity
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Users")]
	public class UsersEntity : Bases.DataEntityBase
	{
		#region MyRegion

		/// <summary>
		/// Constructor
		/// </summary>
		public UsersEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public UsersEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(20, MinimumLength = 5)]
		[DevExpress.Xpo.Size(20)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(20)")]
		public string Username { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(256, MinimumLength = 5)]
		[Base.Infrastructure.Attributes.EmailValidator]
		[DevExpress.Xpo.Size(20)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(256)")]
		public string Email { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(50, MinimumLength = 50)]
		[DevExpress.Xpo.Size(50)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(50)")]
		public string Salt { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000, MinimumLength = 3)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		public string Password { get; set; }

		#endregion

		#region ASSOCIATIONS

		[DevExpress.Xpo.Association(@"NotesReferencesUsers")]
		public System.Collections.Generic.IList<NotesEntity> User_Notes => GetList<NotesEntity>(nameof(User_Notes));

		[DevExpress.Xpo.Association(@"ImagesReferencesUsers")]
		public System.Collections.Generic.IList<ImagesEntity> User_Images => GetList<ImagesEntity>(nameof(User_Images));

		[DevExpress.Xpo.Association(@"ExternalProgramsReferencesUsers")]
		public System.Collections.Generic.IList<ExternalProgramsEntity> User_ExternalPrograms => GetList<ExternalProgramsEntity>(nameof(User_ExternalPrograms));

		[DevExpress.Xpo.Association(@"CommandsReferencesUsers")]
		public System.Collections.Generic.IList<CommandsEntity> User_Commands => GetList<CommandsEntity>(nameof(User_Commands));

		#endregion
	}
}
