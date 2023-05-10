using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public interface IPizza
    {
        public double GetPrice();
        public string GetDescription();
    }
}
