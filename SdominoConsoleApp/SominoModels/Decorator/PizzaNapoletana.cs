namespace SominoModels.Decorator
{
    public class PizzaNapoletana : IPizza
    {
        private const double Price = 5;

        public string GetDescription()
        {
            return "pizza napoletana";
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
