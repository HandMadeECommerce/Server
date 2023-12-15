using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Server.src.Modules.UserModule.Model.Entities;

[Index("Password", Name = "IX_Users_Password_Index")]
public class User
{
    [Key]
    public required Guid Id { get; set; }
    [MaxLength(50)]
    public required string FirstName { get; set; }
    [MaxLength(50)]
    public required string LastName { get; set; }
    [MaxLength(100)]
    [EmailAddress]
    public required string Email { get; set; }
    [MaxLength(100)]
    public required string Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}
