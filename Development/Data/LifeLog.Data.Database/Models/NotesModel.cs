using LifeLog.Data.Database.Bases;
using System;

namespace LifeLog.Data.Database.Models
{
	namespace LifeLog.Data.Models
	{
		public class NotesModel : DataModelBase
		{
			public Guid IdUser { get; set; }
			public string Title { get; set; }
			public string Text { get; set; }
		}
	}

}
