namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Versions Entity
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Versions")]
	internal class VersionsEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		internal VersionsEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		internal VersionsEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region PROPERTIES

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		internal System.Guid ProgramId { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(50, MinimumLength = 3)]
		[Base.Infrastructure.Attributes.EmailValidator]
		[DevExpress.Xpo.Size(50)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(50)")]
		internal string Name { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(20)]
		[Base.Infrastructure.Attributes.EmailValidator]
		[DevExpress.Xpo.Size(20)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(20)")]
		internal string Version { get; set; }

		#endregion
	}
}
