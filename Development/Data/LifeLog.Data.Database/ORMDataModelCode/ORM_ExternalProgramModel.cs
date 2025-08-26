using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_ExternalProgramModel
	{
		public ORM_ExternalProgramModel() : base(Session.DefaultSession) { }
		public ORM_ExternalProgramModel(Session session) : base(session) { }

		private dynamic icon;
		[NonPersistent]
		public dynamic Icon
		{
			get
			{
				if (icon == null && Image != null)
				{
					if (Image.IsSvg)
						return Image.SvgImage;
					else
						return Image.BitImage;
				}
				else
					return icon;
			}
			set => icon = value;
		}

	}

}
