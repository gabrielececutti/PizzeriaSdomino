namespace SominoModels.Models.DTO
{
    public class ReceiptDTO
    {
        public int Number { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}
