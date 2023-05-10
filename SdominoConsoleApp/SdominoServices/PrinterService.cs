using SdominoData;
using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices
{
    public class PrinterService : IPrinterService
    {
        private readonly ISdominoPersistenceServiceFile _sdominoPeristenceServiceFile;

        public PrinterService(ISdominoPersistenceServiceFile sdominoPeristenceServiceFIle)
        {
            _sdominoPeristenceServiceFile = sdominoPeristenceServiceFIle;
        }

        public void Print(Receipt receipt)
        {
           _sdominoPeristenceServiceFile.Write(receipt);
        }
    }
}
