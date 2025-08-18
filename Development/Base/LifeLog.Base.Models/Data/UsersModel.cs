namespace LifeLog.Base.Models.Data
{
	public class UsersModel : Bases.DataModelBase
	{
		public string Username { get; set; }
		public string Email { get; set; }
		public string Salt { get; set; }
		public string Password { get; set; }
	}
}
