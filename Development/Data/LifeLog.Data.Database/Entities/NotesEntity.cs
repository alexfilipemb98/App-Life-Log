namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Notes entity
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Notes")]
	internal class NotesEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		internal NotesEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		internal NotesEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES

		private string fTitle;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Title
		{
			get => fTitle;
			set => SetPropertyValue(nameof(Title), ref fTitle, value);
		}

		private string fText;
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
		[Base.Infrastructure.Attributes.StringLength(4000)]
		[DevExpress.Xpo.Size(4000)]
		[DevExpress.Xpo.Nullable(true)]
		[DevExpress.Xpo.DbType("NVARCHAR(4000)")]
		public string Text
		{
			get => fText;
			set => SetPropertyValue(nameof(Text), ref fText, value);
		}

		#endregion

		#region CLASS

		private UsersEntity fUser;
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdUser")]
		[DevExpress.Xpo.Association(@"NotesReferencesUsers")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public UsersEntity User
		{
			get => fUser;
			set => SetPropertyValue(nameof(User), ref fUser, value);
		}

		#endregion

		#region PROPERTIES NOT MAPED

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdUser => User != null ? User.Id : System.Guid.Empty;

		#endregion

	}
}
