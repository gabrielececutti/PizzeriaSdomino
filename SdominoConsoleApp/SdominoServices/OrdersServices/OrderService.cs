using SdominoData.PersistenceServices.ISdominoPersistenceServiceDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices.OrdersServices
{
    public class OrderService : IOrderService
    {
        private readonly IPersistenceServiceDb _sdominoPersistenceServiceDb;
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
