using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Attributes;
using Core.Enums;
using DevExpress.Utils.Svg;
namespace Data.ORM.DataModelCode
{

    public partial class ORM_Images
    {
        public ORM_Images() : base(Session.DefaultSession) { }
        public ORM_Images(Session session) : base(session) { }

        #region NOT MAPPED

        [NotMapped]
        [NonPersistent]
        public object? Icon
        {
            get
            {
                if (Data != null && Data.Length > 0)
                {
                    if (IsSvg)
                        return Core.Utils.ImagesUtil.ArrayToSvgImage(Data);
                    else
                        return Core.Utils.ImagesUtil.ArrayToBitmap(Data);
                }

                return null;
            }
        }

        #endregion
    }

}
