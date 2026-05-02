using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLog.Core.Entities;

[Table("Users")]
public class User
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Username { get; set; }

    [Required]
    [MaxLength(320)]
    public required string Email { get; set; }

    [Required]
    [MaxLength(400)]
    public required string Password { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Salt { get; set; }
}
