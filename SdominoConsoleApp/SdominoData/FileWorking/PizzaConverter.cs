using SominoModels.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.FileWorking
{
    /// <summary>
    /// PESSIAMA SOLUZIONE
    /// RIVDERE DECORATORE
    /// </summary>
    public static class PizzaConverter
    {
        public static IPizza Convert(string[] fields)
        {
            switch (fields[0])
            {
                case "Margherita":
                    {
                        IPizza margherita = new PizzaMargherita();
                        if (fields[1] == "Integrale")
                        {
                            margherita = new WithImpastoIntegrale(margherita);
                        }
                        var ingredients = fields[2].Split(',');
                        foreach (var ingredient in ingredients)
                        {
                                if (ingredient == "Funghi") margherita = new WithFunghi(margherita);
                                if (ingredient == "ProsciuttoCotto") margherita = new WithProsciuttoCotto(margherita);
                                if (ingredient == "ProsciuttoCrudo") margherita = new WithProsciuttoCrudo(margherita);
                        }
                        if (ingredients.Contains("Anans")) margherita = new WithAnanas(margherita);
                        return margherita;
                    }
                case "Napoletana":
                    {
                        IPizza napoletana = new PizzaNapoletana();
                        if (fields[1] == "Integrale")
                        {
                            napoletana = new WithImpastoIntegrale(napoletana);
                        }
                        var ingredients = fields[2].Split(',');
                        foreach (var ingredient in ingredients)
                        {
                            if (ingredient == "Funghi") napoletana = new WithFunghi(napoletana);
                            if (ingredient == "ProsciuttoCotto") napoletana = new WithProsciuttoCotto(napoletana);
                            if (ingredient == "ProsciuttoCrudo") napoletana = new WithProsciuttoCrudo(napoletana);
                        }
                        if (ingredients.Contains("Anans")) napoletana = new WithAnanas(napoletana);
                        return napoletana;
                    }
                case "Bianca":
                    {
                        IPizza bianca = new PizzaBianca();
                        if (fields[1] == "Integrale")
                        {
                            bianca = new WithImpastoIntegrale(bianca);
                        }
                        var ingredients = fields[2].Split(',');
                        foreach (var ingredient in ingredients)
                        {
                            if (ingredient == "Funghi") bianca = new WithFunghi(bianca);
                            if (ingredient == "ProsciuttoCotto") bianca = new WithProsciuttoCotto(bianca);
                            if (ingredient == "ProsciuttoCrudo") bianca = new WithProsciuttoCrudo(bianca);
                        }
                        if (ingredients.Contains("Anans")) bianca = new WithAnanas(bianca);
                        return bianca;
                    }
            }
            return null;
        }
    }
}
