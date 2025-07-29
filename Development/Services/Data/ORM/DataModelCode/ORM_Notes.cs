using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Notes
    {
        public ORM_Notes() : base(Session.DefaultSession) { }
        public ORM_Notes(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
