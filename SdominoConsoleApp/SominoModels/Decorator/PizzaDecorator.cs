namespace SominoModels.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}
