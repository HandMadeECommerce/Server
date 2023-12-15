using System.ComponentModel.DataAnnotations;

namespace Server.src.Modules.ProductModule.Model.Entities;

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
    public required IFormFile FormFile { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public int InStock { get; set; } = 0;
}
