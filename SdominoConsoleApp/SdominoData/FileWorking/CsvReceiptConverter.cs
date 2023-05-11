using SominoModels.Models;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.FileWorking
{
    public class CsvReceiptConverter
    {
        public static string Convert(ReceiptDTO receipt)
        {
            return $"{receipt.Number};{receipt.Description};{receipt.Price};{receipt.Date}";
        }
    }
}
