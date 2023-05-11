namespace SominoModels.Decorator
{
    public class WithIngredeints : PizzaDecorator
    {
        private readonly string[] _ingredients;
        private readonly IPizza _pizza;

        public WithIngredeints(IPizza pizza, string[] _ingredeints)
        {
            _pizza = pizza;
            _ingredients = _ingredeints;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()} con {string.Join(",", _ingredients)}";
        }

        public override double GetPrice()
        {
            if (_ingredients.Contains("Ananas"))return 0;
            var costIngredients = 0;
            foreach (var ingredient in _ingredients)
            {
                switch (ingredient)
                {
                    case "Funghi": costIngredients += 2;break;
                    case "ProsciuttoCotto": costIngredients += 1;break;
                    case "ProsciuttoCrudo": costIngredients += 2;break;
                }
            }
            return _pizza.GetPrice() + costIngredients;
        }
    }

}
