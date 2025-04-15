using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Users
    {
        public ORM_Users() : base(Session.DefaultSession) { }
        public ORM_Users(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
