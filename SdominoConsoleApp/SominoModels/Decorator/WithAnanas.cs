using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class WithAnanas : PizzaDecorator
    {
        private readonly IPizza _pizza;

        public WithAnanas(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} con ananas";
        }

        public override double GetPrice()
        {
            return 0;
        }
    }
}
