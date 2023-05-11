namespace SominoModels.Decorator
{
    public class PizzaBianca : IPizza
    {
        private const double Price = 5;

        public string GetDescription()
        {
            return "pizza bianca";
        }

        public  double GetPrice()
        {
            return Price;
        }
    }
}
