using SominoModels.Models;
using SominoModels.Models.DTO;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<OrderDTO> Read()
        {
            var orders = new List<OrderDTO>();
            string[] files = Directory.GetFiles(_basePath);
            foreach (var file in files)
            {
                string[] pizzas = File.ReadAllLines(file).Skip(1).ToArray();
                var orderDTO = new OrderDTO { Pizzas = pizzas };
                orders.Add(orderDTO);
            }
            return orders;
        }
    }
}

