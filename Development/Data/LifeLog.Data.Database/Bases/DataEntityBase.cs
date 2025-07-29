using LifeLog.Base.Utils;
using System;

namespace LifeLog.Data.Database.Bases
{
	/// <summary>
	/// Base data entity
	/// </summary>
	[DevExpress.Xpo.NonPersistent]
	public class DataEntityBase : DevExpress.Xpo.XPBaseObject
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public DataEntityBase() { }

		/// <summary>
		/// Constructor
		/// </summary>
		public DataEntityBase(DevExpress.Xpo.Session session) : base(session) { }

		#endregion

		#region PROPERTIES

		[System.ComponentModel.DataAnnotations.Key]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Key]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		[DevExpress.Xpo.Nullable(false)]
		public Guid Id { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.ColumnDbDefaultValue("CURRENT_TIMESTAMP")]
		[DevExpress.Xpo.DbType("DATETIME2")]
		public DateTime CreatedAt { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.ColumnDbDefaultValue("CURRENT_TIMESTAMP")]
		[DevExpress.Xpo.DbType("DATETIME2")]
		public DateTime UpdatedAt { get; set; }

		#endregion

		#region PROPERTIES NOT MAPED

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[DevExpress.Xpo.NonPersistent]
		public bool Saving { get; set; } = false;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public bool EditingMode => Id != Guid.Empty;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		public bool IsValid => this.ValidateModel();

		#endregion

		#region OVERRIDES

		/// <summary>
		/// On new object
		/// </summary>
		public override void AfterConstruction()
		{
			base.AfterConstruction();
			CreatedAt = UpdatedAt = DateTime.Now;
		}

		/// <summary>
		/// On Saving
		/// </summary>
		protected override void OnSaving()
		{
			if (!Saving)
			{
				this.Session.ReloadAsync(this);
				return;
			}

			if (this.Session.IsNewObject(this))
				CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
			
			base.OnSaving();

			Saving = false;
		}

		#endregion

	}
}
