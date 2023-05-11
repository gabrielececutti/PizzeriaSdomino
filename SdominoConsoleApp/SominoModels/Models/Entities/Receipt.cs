namespace SdominoData.Models.Entities;

public partial class Receipt
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public DateTime Date { get; set; }

    public virtual Order Order { get; set; } = null!;
}
