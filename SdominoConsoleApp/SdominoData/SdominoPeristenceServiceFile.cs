using SdominoData.FileWorking;
using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData
{
    public class SdominoPeristenceServiceFile : ISdominoPersistenceServiceFile
    {
        private readonly string _basePath;
        private const string Heading = $"number;description;totalPrice";

        public SdominoPeristenceServiceFile(string basePath)
        {
            _basePath = basePath;
        }

        public void Write(Receipt receipt)
        {
            var fileName = $"Receipt-{receipt.Id}";
            var path = Path.Combine(_basePath, fileName);
            var logger = $"{Heading}{Environment.NewLine}{CsvReceiptConverter.Convert(receipt)}";
            File.WriteAllText(path, logger);
        }
    }
}
