using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.src.Modules.ProductModule.Model.Entities;

[Index("CreatorId", Name = "IX_Products_CreatorId")]
public class Product
{
    [Key]
    public required Guid Id { get; set; }
    public required Guid CreatorId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required decimal Discount { get; set; }
    public required string Image { get; set; }
    [NotMapped]
    public required IFormFile FormFile { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public int InStock { get; set; } = 0;
}
