using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class PizzaBianca : IPizza
    {
        public string GetDescription()
        {
            return "pizza bianca";
        }

        public double GetPrice()
        {
            return 5;
        }
    }
}
