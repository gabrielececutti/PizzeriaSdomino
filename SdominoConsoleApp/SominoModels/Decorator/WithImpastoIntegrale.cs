using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class WithImpastoIntegrale : PizzaDecorator
    {
        private const double Price = 1;
        private readonly IPizza _pizza;

        public WithImpastoIntegrale(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} con impasto integrale";
        }

        public override double GetPrice()
        {
            return _pizza.GetPrice() + Price;
        }
    }
}
