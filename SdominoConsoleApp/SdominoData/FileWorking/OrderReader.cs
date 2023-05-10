using SominoModels.Decorator;
using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.FileWorking
{
    public class OrderReader : IOrderReader
    {
        private readonly string _basePath;

        public OrderReader(string basePath)
        {
            _basePath = basePath;
        }

        public Order Read()
        {
            var order = new Order();
            using var reader = new StreamReader(_basePath);
            string line;
            reader.ReadLine();
            var fields = new string[] { };
            while ((line = reader.ReadLine()) != null)
            {
                fields = line.Split(';');
                var pizza = PizzaConverter.Convert(fields);
                order.Pizzas.Add(pizza);
            }
            return order;
        }
    }
}

