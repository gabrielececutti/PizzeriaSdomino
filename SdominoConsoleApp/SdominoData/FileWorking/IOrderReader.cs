using SominoModels.Models;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.FileWorking
{
    public interface IOrderReader
    {
        public List<OrderDTO> Read();
    }
}
