using SdominoData.FileWorking;
using SominoModels.Models;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.PersistenceServices.ISdominoPersistenceServiceFile
{
    public class PeristenceServiceFile : IPersistenceServiceFile
    {
        private readonly string _basePath;
        private const string Heading = $"number;description;totalPrice;date";

        public PeristenceServiceFile(string basePath)
        {
            _basePath = basePath;
        }

        public void Write(ReceiptDTO receipt)
        {
            var fileName = $"Receipt-{receipt.Number}";
            var path = Path.Combine(_basePath, fileName);
            var logger = $"{Heading}{Environment.NewLine}{CsvReceiptConverter.Convert(receipt)}";
            File.WriteAllText(path, logger);
        }
    }
}
