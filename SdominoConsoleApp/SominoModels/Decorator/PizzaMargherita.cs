using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class PizzaMargherita : IPizza
    {
        public string GetDescription()
        {
            return "pizza margherita";
        }

        public double GetPrice()
        {
            return 7;
        }
    }
}
