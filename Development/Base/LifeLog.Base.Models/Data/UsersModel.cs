using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Data
{
	[Table("Users")]
	[Description("Database model for users")]
	public class UsersModel : Bases.DataModelBase
	{

		#region PROPERTIES

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(20, MinimumLength = 5)]
		public string Username { get; set; }

		[DataType(DataType.EmailAddress)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(256, MinimumLength = 5)]
		[Infrastructure.Attributes.EmailValidator]
		public string Email { get; set; }

		[DataType(DataType.Text)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(50, MinimumLength = 50)]
		public string Salt { get; set; }

		[DataType(DataType.Password)]
		[Infrastructure.Attributes.Required]
		[Infrastructure.Attributes.StringLength(4000, MinimumLength = 3)]
		public string Password { get; set; }
		
		#endregion
	}
}
