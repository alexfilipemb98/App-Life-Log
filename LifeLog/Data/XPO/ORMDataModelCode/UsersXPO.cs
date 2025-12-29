using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.XPO.ORMDataModelCode
{

	public partial class UsersXPO
	{
		public UsersXPO() : base(Session.DefaultSession) { }
		public UsersXPO(Session session) : base(session) { }
	}

}
