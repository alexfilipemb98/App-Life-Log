using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.XPO.ORMDataModelCode
{

	public partial class NotesXPO
	{
		public NotesXPO() : base(Session.DefaultSession) { }
		public NotesXPO(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
