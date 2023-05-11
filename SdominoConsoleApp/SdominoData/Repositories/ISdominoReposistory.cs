using SdominoData.Models.Entities;

namespace SdominoData.Repositories
{
    public interface ISdominoReposistory
    {
        public void Insert(Order order);
        public void Insert(Receipt receipt);
    }

    public class SdominoRepository : ISdominoReposistory
    {
        private readonly SdominoContext _context;

        public SdominoRepository(SdominoContext context)
        {
            _context = context;
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Insert(Receipt receipt)
        {
            _context.Receipts.Add(receipt);
            _context.SaveChanges();
        }
    }
}
