namespace SdominoData.Models.Entities
{

    public partial class Order
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public double TotalPrice { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
    }
}