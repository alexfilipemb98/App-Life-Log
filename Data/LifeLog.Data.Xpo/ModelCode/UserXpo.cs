using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Xpo.Model
{

	public partial class UserXpo
	{
		public UserXpo() : base(Session.DefaultSession) { }
		public UserXpo(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
