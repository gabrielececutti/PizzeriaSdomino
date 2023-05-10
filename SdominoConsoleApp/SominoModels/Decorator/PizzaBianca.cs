using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class PizzaBianca : IPizza
    {
        public string Impasto { get; set; }
        public List<string> Ingredienti { get; set; }
        public double Price { get; set; }

        public PizzaBianca( string impasto double price)
        {
            Impasto = impasto;
            Ingredienti = ingredienti;
            Price = price;
        }

        public string GetDescription()
        {
            return "pizza bianca";
        }

        public double GetPrice()
        {
            return 5;
        }
    }
}
