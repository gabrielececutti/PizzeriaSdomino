using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class WithFunghi : PizzaDecorator
    {
        private const double Price = 2;
        private readonly IPizza _pizza;

        public WithFunghi(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} con funghi";
        }

        public override double GetPrice()
        {
            return _pizza.GetPrice() + Price;
        }
    }
}
