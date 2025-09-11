using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models
{
	[Table("Users")]
	[Description("Database model for users")]
	public class UsersModel : Bases.DataModelBase
	{

		#region PROPERTIES

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(20, MinimumLength = 5)]
		public string Username { get; set; }

		[DataType(DataType.EmailAddress)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(256, MinimumLength = 5)]
		[Base.Infrastructure.Attributes.EmailValidator]
		public string Email { get; set; }

		[DataType(DataType.Text)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(50, MinimumLength = 50)]
		public string Salt { get; set; }

		[DataType(DataType.Password)]
		[Base.Infrastructure.Attributes.Required]
		[Base.Infrastructure.Attributes.StringLength(4000, MinimumLength = 3)]
		public string Password { get; set; }
		
		#endregion
	}
}
