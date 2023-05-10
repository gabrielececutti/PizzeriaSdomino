using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class WithProsciuttoCotto : PizzaDecorator
    {
        private const double Price = 1;
        private readonly IPizza _pizza;

        public WithProsciuttoCotto(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} con prosciutto cotto"; ;
        }

        public override double GetPrice()
        {
            return _pizza.GetPrice() + Price;
        }
    }
}
