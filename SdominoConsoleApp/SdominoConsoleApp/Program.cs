
using SominoModels.Decorator;
using System.Net.Http.Headers;

var pizzaBase = new PizzaMargherita();
var conProsciuttocotto = new WithProsciuttoCotto(pizzaBase);
var conFunghi = new WithFunghi(conProsciuttocotto);
var conAnanas = new WithAnanas(conFunghi);

Console.WriteLine(  conAnanas.GetDescription());
Console.WriteLine(  conAnanas.GetPrice());
