using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Models
{
	/// <summary>
	/// Logged user model
	/// </summary>
	public class LoggedUserModel
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
	}
}
