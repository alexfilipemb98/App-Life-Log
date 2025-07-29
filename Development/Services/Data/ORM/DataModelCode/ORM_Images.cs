using DevExpress.Xpo;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Images
    {
        public ORM_Images() : base(Session.DefaultSession) { }
        public ORM_Images(Session session) : base(session) { }

        #region NOT MAPPED

        [NotMapped]
        [NonPersistent]
        public object Icon
        {
            get
            {
                if (Data != null && Data.Length > 0)
                {
                    if (IsSvg)
                        return Utils.ImagesUtil.ArrayToSvgImage(Data);
                    else
                        return Utils.ImagesUtil.ArrayToBitmap(Data);
                }

                return null;
            }
        }

        #endregion
    }

}
