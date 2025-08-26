using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_ImagesModel
	{
		public ORM_ImagesModel() : base(Session.DefaultSession) { }
		public ORM_ImagesModel(Session session) : base(session) { }

		[NonPersistent]
		public DevExpress.Utils.Svg.SvgImage SvgImage => Data != null && Data.Length > 0 && IsSvg ? LifeLog.Base.Utils.ImagesUtil.ArrayToSvgImage(Data) : null;

		[NonPersistent]
		public System.Drawing.Bitmap BitImage => Data != null && Data.Length > 0 && IsSvg ? LifeLog.Base.Utils.ImagesUtil.ArrayToBitmap(Data) : null;
	}

}
