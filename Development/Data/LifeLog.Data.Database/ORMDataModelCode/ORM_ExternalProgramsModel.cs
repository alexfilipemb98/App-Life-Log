using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_ExternalProgramsModel
	{
		public ORM_ExternalProgramsModel() : base() { }
		public ORM_ExternalProgramsModel(Session session) : base(session) { }
		
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
