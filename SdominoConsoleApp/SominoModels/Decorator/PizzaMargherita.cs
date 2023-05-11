namespace SominoModels.Decorator
{
    public class PizzaMargherita : IPizza
    {
        private const double Price = 7;
        public string GetDescription()
        {
            return "pizza margherita";
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
