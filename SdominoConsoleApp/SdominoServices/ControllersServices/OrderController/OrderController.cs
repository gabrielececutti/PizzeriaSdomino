
using SdominoData.FileWorking;
using SdominoData.Models.Entities;
using SominoModels.Decorator;
using SominoModels.Models.DTO;

namespace SdominoServices.ControllerService.OrderController
{
    public static class OrderController
    {
        public static List<Order> ConvertToEntity(List<OrderDTO> orders)
        {
            List<Order> result = new List<Order>();
            foreach (var orderItem in orders)
            {
                var order = new Order();
                foreach (var pizzaItem in orderItem.Pizzas)
                {
                    IPizza pizza = PizzaInstantiator.Convert(pizzaItem);
                    order.Description = string.Join(" | ", order.Description, pizza.GetDescription());
                    order.TotalPrice += pizza.GetPrice();
                }
                result.Add(order);
            }
            return result;
        }
    }
}
