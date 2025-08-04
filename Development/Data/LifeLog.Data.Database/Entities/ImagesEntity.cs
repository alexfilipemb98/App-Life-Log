namespace LifeLog.Data.Database.Entities
{
	/// <summary>
	/// Images entity
	/// </summary>
	[DevExpress.Xpo.Persistent(@"Images")]
	public class ImagesEntity : Bases.DataEntityBase
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public ImagesEntity()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="session"></param>
		public ImagesEntity(DevExpress.Xpo.Session session) : base(session)
		{
		}

		#endregion

		#region CLASS

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Persistent(@"IdUser")]
		[DevExpress.Xpo.Association(@"ImagesReferencesUsers")]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		public UsersEntity User { get; set; }

		#endregion

		#region PROPERTIES

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(30, MinimumLength = 3)]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(30)")]
		public string Name { get; set; }

		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Size(30)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("VARBINARY(4000)")]
		public byte[] Data { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(10)]
		[DevExpress.Xpo.Size(10)]
		[DevExpress.Xpo.Nullable(false)]
		[DevExpress.Xpo.DbType("NVARCHAR(10)")]
		public string FileExtension { get; set; }

		#endregion

		#region PROPERTIES NOT MAPED

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Guid IdUser => User != null ? User.Id : System.Guid.Empty;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public bool IsSvg => FileExtension == null ? false : FileExtension.EndsWith("svg", System.StringComparison.InvariantCultureIgnoreCase);

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public DevExpress.Utils.Svg.SvgImage SvgImage => Data != null && Data.Length > 0 && IsSvg ? LifeLog.Base.Utils.ImagesUtil.ArrayToSvgImage(Data) : null;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public System.Drawing.Bitmap BitImage => Data != null && Data.Length > 0 && IsSvg ? LifeLog.Base.Utils.ImagesUtil.ArrayToBitmap(Data) : null;

		#endregion
		
		#region ASSOCIATIONS

		[DevExpress.Xpo.Association(@"ExternalProgramsReferencesImages")]
		public System.Collections.Generic.IList<ExternalProgramsEntity> Images_ExternalPrograms => GetList<ExternalProgramsEntity>(nameof(Images_ExternalPrograms));
		
		#endregion
	}
}
