using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_ExternalPrograms
    {
        public ORM_ExternalPrograms() : base(Session.DefaultSession) { }
        public ORM_ExternalPrograms(Session session) : base(session) { }

        #region NOT MAPPED

        [NotMapped]
        [NonPersistent]
        public dynamic Icon { get; set; }

        #endregion
    }

}
