using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Core.Entities;

[Table("Users")]
public class User
{
    [Key]
    [Required]
    public Guid Id { get; set; }


}
