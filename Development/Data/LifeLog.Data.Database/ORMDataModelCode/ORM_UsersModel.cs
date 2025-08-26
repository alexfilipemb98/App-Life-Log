using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_UsersModel
	{
		public ORM_UsersModel() : base(Session.DefaultSession) { }
		public ORM_UsersModel(Session session) : base(session) { }
	}

}
