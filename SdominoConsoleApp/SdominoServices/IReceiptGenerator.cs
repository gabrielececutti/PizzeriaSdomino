using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices
{
    public interface IReceiptGenerator
    {
        public Receipt Generate(Order order);
    }
}
