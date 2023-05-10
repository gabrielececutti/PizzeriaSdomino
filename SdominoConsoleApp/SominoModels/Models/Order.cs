using SominoModels.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Models
{
    public class Order
    {
       public int Id { get; set; }
       public List<IPizza> Pizzas { get; set; }
    }
}
