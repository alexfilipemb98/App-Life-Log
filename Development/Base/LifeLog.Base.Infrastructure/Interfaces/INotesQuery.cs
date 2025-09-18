using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Interfaces
{
	/// <summary>
	/// Notes Query Interface
	/// </summary>
	public interface INotesQuery<Object, Key> : IBaseQuery<Object, Key>
	{
		Task<(List<Object>, string)> GetUserNotes(Guid userId);

		Task<(bool, string)> SaveList(List<Object> notesList);
	}
}
