using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Xpo.Model
{

	public partial class ExternalProgramXpo
	{
		public ExternalProgramXpo() : base(Session.DefaultSession) { }
		public ExternalProgramXpo(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
