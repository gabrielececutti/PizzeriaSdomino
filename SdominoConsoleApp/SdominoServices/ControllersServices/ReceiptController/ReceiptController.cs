using SdominoData.Models.Entities;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices.ControllerService.ReceiptController
{
    public static class ReceiptController
    {
        public  static ReceiptDTO ConvertToDTO(Receipt receipt)
        {
                return new ReceiptDTO()
                {
                    Number = receipt.Id,
                    Description = receipt.Order.Description,
                    Price = receipt.Order.TotalPrice,
                    Date = receipt.Date
                };
        }
    }
}
