using SominoModels.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.FileWorking
{
    public static class PizzaInstantiator
    {
        public static IPizza Convert(string pizza)
        {
            var fields = pizza.Split(';');
            switch (fields[0])
            {
                case "Margherita":
                {
                     IPizza margherita = new PizzaMargherita();
                     if (fields[1] == "Integrale") margherita = new WithWholemealDough(margherita);
                     var ingredients = fields[2].Contains(",") ? fields[2].Split(",") : new string[] { fields[2] };
                     return new WithIngredeints(margherita, ingredients);
                }
                case "Napoletana":
                {
                    IPizza napoletana = new PizzaNapoletana();
                    if (fields[1] == "Integrale") napoletana = new WithWholemealDough(napoletana);
                        var ingredients = fields[2].Contains(",") ? fields[2].Split(",") : new string[] { fields[2] };
                        return new WithIngredeints(napoletana, ingredients);
                }
                case "Bianca":
                {
                    IPizza bianca = new PizzaBianca();
                    if (fields[1] == "Integrale") bianca = new WithWholemealDough(bianca);
                    var ingredients = fields[2].Contains(",") ? fields[2].Split(",") : new string[] { fields[2] };
                    return new WithIngredeints(bianca, ingredients);
                }
            }
            return null;
        }
    }
}
