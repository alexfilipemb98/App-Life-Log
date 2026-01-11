using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.XPO.ORMDataModelCode
{

	public partial class ExternalProgramsXPO
	{
		public ExternalProgramsXPO() : base(Session.DefaultSession) { }
		public ExternalProgramsXPO(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
