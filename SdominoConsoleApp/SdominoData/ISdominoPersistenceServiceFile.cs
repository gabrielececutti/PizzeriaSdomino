using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData
{
    public interface ISdominoPersistenceServiceFile
    {
        public void Write(Receipt receipt);
    }
}
