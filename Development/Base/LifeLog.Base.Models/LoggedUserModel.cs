using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Base.Models
{
	/// <summary>
	/// Logged user model
	/// </summary>
	public class LoggedUserModel
	{
		[System.ComponentModel.DataAnnotations.Key]
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
	}
}
