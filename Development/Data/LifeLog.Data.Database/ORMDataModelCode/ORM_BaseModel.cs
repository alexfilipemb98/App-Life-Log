using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_BaseModel
	{

		public ORM_BaseModel() : base(Session.DefaultSession) { }
		public ORM_BaseModel(Session session) : base(session) { }

		/// <summary>
		/// On new object
		/// </summary>
		public override void AfterConstruction()
		{
			Id = Guid.NewGuid();
			CreatedAt = UpdatedAt = DateTime.Now;
		}

		/// <summary>
		/// On Saving
		/// </summary>
		protected override void OnSaving()
		{
			if (!Saving)
			{
				this.Session.Reload(this);
				return;
			}

			if (this.Session.IsNewObject(this))
				CreatedAt = DateTime.Now;

			UpdatedAt = DateTime.Now;
		}

		/// <summary>
		/// On Saved
		/// </summary>
		protected override void OnSaved()
		{
			Saving = false;
		}
	}

}
