using Server.src.Modules.ProductModule.Model.Entities;
using System.ComponentModel.DataAnnotations;

namespace Server.src.Modules.OrderModule.Model.Entities;

public class Order
{
    [Key]
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Product Product { get; set; }
}
