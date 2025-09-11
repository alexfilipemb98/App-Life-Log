using LifeLog.Base.Utils;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Data.Models.Bases
{
	[NotMapped]
	public class DataModelBase
	{
		[Key]
		[Base.Infrastructure.Attributes.Required]
		public Guid Id { get; set; }

		[DataType(DataType.Date)]
		public DateTime CreatedAt { get; set; }
		
		[DataType(DataType.Date)]
		public DateTime UpdatedAt { get; set; }

		[JsonIgnore]
		[NotMapped]
		public bool IsValid => this.ValidateModel();
	}
}
