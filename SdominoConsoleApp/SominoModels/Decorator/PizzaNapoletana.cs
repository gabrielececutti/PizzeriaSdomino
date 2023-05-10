using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class PizzaNapoletana : IPizza
    {
        public string GetDescription()
        {
            return "pizza napoletana";
        }

        public double GetPrice()
        {
            return 3;
        }
    }
}
