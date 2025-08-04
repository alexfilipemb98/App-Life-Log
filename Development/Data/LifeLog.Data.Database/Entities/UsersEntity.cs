namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Users entity
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Users")]
	internal class UsersEntity : Bases.DataEntityBase
	{
		#region MyRegion

		/// <summary>
		/// Constructor
		/// </summary>
		internal UsersEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		internal UsersEntity(DevExpress.Xpo.Session session) : base(session)
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
		internal string Username { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(256, MinimumLength = 5)]
		[Base.Infrastructure.Attributes.EmailValidator]
		[DevExpress.Xpo.Size(20)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(256)")]
		internal string Email { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(50, MinimumLength = 50)]
		[DevExpress.Xpo.Size(50)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(50)")]
		internal string Salt { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000, MinimumLength = 3)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		internal string Password { get; set; }

		#endregion

		#region ASSOCIATIONS

		[DevExpress.Xpo.Association(@"NotesReferencesUsers")]
		internal System.Collections.Generic.IList<NotesEntity> User_Notes => GetList<NotesEntity>(nameof(User_Notes));

		[DevExpress.Xpo.Association(@"ImagesReferencesUsers")]
		internal System.Collections.Generic.IList<ImagesEntity> User_Images => GetList<ImagesEntity>(nameof(User_Images));

		[DevExpress.Xpo.Association(@"CommandsReferencesUsers")]
		internal System.Collections.Generic.IList<CommandsEntity> User_Commands => GetList<CommandsEntity>(nameof(User_Commands));

		#endregion
	}
}
