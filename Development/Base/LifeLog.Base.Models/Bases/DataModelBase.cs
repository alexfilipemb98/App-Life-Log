using LifeLog.Base.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Base.Models.Bases
{
	[NotMapped]
	public class DataModelBase
	{
		[Key]
		[Infrastructure.Attributes.Required]
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
