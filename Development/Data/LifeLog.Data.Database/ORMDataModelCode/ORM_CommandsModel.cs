using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LifeLog.Data.Database.ORMDataModel
{

	public partial class ORM_CommandsModel
	{
		public ORM_CommandsModel() : base(Session.DefaultSession) { }
		public ORM_CommandsModel(Session session) : base(session) { }

		private dynamic icon;
		[NonPersistent]
		public dynamic Icon
		{
			get
			{
				if (icon == null && ExternalProgram != null && ExternalProgram.Image != null)
				{
					if (ExternalProgram.Image.IsSvg)
						return ExternalProgram.Image.SvgImage;
					else
						return ExternalProgram.Image.BitImage;
				}
				else
					return icon;
			}
			set => icon = value;
		}

	}

}
