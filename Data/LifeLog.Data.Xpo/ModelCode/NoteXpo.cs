using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Xpo.Model
{

	public partial class NoteXpo
	{
		public NoteXpo() : base(Session.DefaultSession) { }
		public NoteXpo(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
