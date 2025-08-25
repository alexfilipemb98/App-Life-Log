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
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Title
		{
			get => fTitle;
			set => SetPropertyValue(nameof(Title), ref fTitle, value);
		}

		private string fText;
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

		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdUser => User != null ? User.Id : System.Guid.Empty;

		#endregion

	}
}
