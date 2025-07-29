using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Versions
    {
        public ORM_Versions() : base(Session.DefaultSession) { }
        public ORM_Versions(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
