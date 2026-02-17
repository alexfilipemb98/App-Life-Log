using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Xpo.ModelCode
{

	public partial class CommandXpo
	{
		public CommandXpo() : base(Session.DefaultSession) { }
		public CommandXpo(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
