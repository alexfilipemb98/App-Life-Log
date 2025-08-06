using LifeLog.Data.Database.Bases;

namespace LifeLog.Data.Database.Models
{
	public class UsersModel : DataModelBase
	{
		public string Username { get; set; }
		public string Email { get; set; }
		public string Salt { get; set; }
		public string Password { get; set; }
	}
}
