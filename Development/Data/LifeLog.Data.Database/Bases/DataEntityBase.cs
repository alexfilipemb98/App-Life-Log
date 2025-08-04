using LifeLog.Base.Utils;
using System;

namespace LifeLog.Data.Database.Bases
{
	/// <summary>
	/// Base data entity
	/// </summary>
	[DevExpress.Xpo.NonPersistent]
	internal class DataEntityBase : DevExpress.Xpo.XPBaseObject
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		internal DataEntityBase() { }

		/// <summary>
		/// Constructor
		/// </summary>
		internal DataEntityBase(DevExpress.Xpo.Session session) : base(session) { }

		#endregion

		#region PROPERTIES

		[System.ComponentModel.DataAnnotations.Key]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.Key]
		[DevExpress.Xpo.DbType("UNIQUEIDENTIFIER")]
		[DevExpress.Xpo.Nullable(false)]
		internal Guid Id { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.ColumnDbDefaultValue("CURRENT_TIMESTAMP")]
		[DevExpress.Xpo.DbType("DATETIME2")]
		internal DateTime CreatedAt { get; set; }

		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
		[Base.Infrastructure.Attributes.Required]
		[DevExpress.Xpo.ColumnDbDefaultValue("CURRENT_TIMESTAMP")]
		[DevExpress.Xpo.DbType("DATETIME2")]
		internal DateTime UpdatedAt { get; set; }

		#endregion

		#region PROPERTIES NOT MAPED

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[DevExpress.Xpo.NonPersistent]
		internal bool Saving { get; set; } = false;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		internal bool EditingMode { get; set; } = false;

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[System.ComponentModel.ReadOnly(true)]
		[DevExpress.Xpo.NonPersistent]
		internal bool IsValid => this.ValidateModel();

		#endregion

		#region OVERRIDES

		/// <summary>
		/// On new object
		/// </summary>
		internal override void AfterConstruction()
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
