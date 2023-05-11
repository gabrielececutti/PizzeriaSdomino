using SdominoData.Models.Entities;
using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices.ReceiptServices
{
    public static class ReceiptGenerator { 
        public static Receipt Generate(Order order)
        {
            return new Receipt()
            {
                OrderId = order.Id,
                Date = DateTime.Now,
                Order = order
            };
        }
    }
}
