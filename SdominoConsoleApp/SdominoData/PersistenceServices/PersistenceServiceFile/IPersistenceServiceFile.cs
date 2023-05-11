using SdominoData.Models.Entities;
using SominoModels.Models;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.PersistenceServices.ISdominoPersistenceServiceFile
{
    public interface IPersistenceServiceFile
    {
        public void Write(ReceiptDTO receipt);
    }
}
