using DevExpress.Xpo;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Commands
    {
        #region MAIN

        public ORM_Commands() : base(Session.DefaultSession) { }
        public ORM_Commands(Session session) : base(session) { }

        #endregion

        #region NOT MAPPED

        [NotMapped]
        [NonPersistent]
        public dynamic Icon { get; set; }

        #endregion
    }

}
