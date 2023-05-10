using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SominoModels.Decorator
{
    public class Pizza : IPizza
    {
        private readonly string 
        private readonly string _dough;
        private readonly List<string> _ingredients;

        public Pizza(string , string dough, List<string> ingredients)
        {
            _name = name;
            _dough = dough;
            _ingredients = ingredients;
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
