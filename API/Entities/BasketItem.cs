using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("BasketItems")]
public class BasketItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    #region navigation properties
    public int ProductId { get; set; }
    public Product Product { get; set; } = new();

    public int BasketId { get; set; }
    public Basket Basket { get; set; } = new();
    #endregion navigation properties
}
