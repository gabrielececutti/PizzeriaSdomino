using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoServices
{
    public interface IPrinterService
    {
        public void Print(Receipt receipt);
    }
}
