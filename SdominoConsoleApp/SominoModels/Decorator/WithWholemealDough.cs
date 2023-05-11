namespace SominoModels.Decorator
{
    public class WithWholemealDough : PizzaDecorator
    {
        private const double Price = 1;
        private readonly IPizza _pizza;

        public WithWholemealDough(IPizza pizza)
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
