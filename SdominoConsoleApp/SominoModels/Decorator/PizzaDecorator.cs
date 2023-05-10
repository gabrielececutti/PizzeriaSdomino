using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}
