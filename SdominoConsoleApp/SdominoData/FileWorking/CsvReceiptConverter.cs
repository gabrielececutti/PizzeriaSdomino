using SominoModels.Models;
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
        public static string Convert(Receipt receipt)
        {
            return $"{receipt.Id};{receipt.Description};{receipt.TotalPrice}";
        }
    }
}
