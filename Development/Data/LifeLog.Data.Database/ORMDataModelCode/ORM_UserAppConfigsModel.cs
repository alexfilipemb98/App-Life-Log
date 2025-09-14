using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_UserAppConfigsModel
	{
		public ORM_UserAppConfigsModel() : base(Session.DefaultSession) { }
		public ORM_UserAppConfigsModel(Session session) : base(session) { }
	}

}
