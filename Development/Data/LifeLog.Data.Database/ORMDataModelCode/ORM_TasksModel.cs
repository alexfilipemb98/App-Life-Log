using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_TasksModel
	{
		public ORM_TasksModel() : base(Session.DefaultSession) { }
		public ORM_TasksModel(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
