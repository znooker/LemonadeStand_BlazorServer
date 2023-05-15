using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

// See https://aka.ms/new-console-template for more information

//List<IRecipe> juiceMenu = new()
//{
//new AppleJuice(),
//new MelonJuice(),
//new OrangeJuice()
//};

Console.WriteLine("Our Juice Menu:");
//foreach (var juice in juiceMenu)
//{
//    Console.WriteLine($"{juice.Name} \t- Price/Glass: {juice.PricePerGlass} \t - Contains:{juice.ConsumptionPerGlass} {juice.AllowedFruit.Name}");
//}

//Console.WriteLine(  );
//int moneyPaid = 30;
//int orderedGlassQuantity = 2;

//if (moneyPaid < (juiceMenu[0].PricePerGlass * orderedGlassQuantity))
//{
//    Console.WriteLine("Not enough money!");
//    Console.WriteLine($"Totalcost is: {juiceMenu[0].PricePerGlass * orderedGlassQuantity}");
//}
//else
//{
//    Console.WriteLine($"Here is your order of {orderedGlassQuantity} glasses of {juiceMenu[0].Name}");
//}

Console.WriteLine();
Console.WriteLine("test");


FruitPressService press = new();

Collection<IFruit> fruits = new Collection<IFruit>() { new Apple(), new Apple()};

//press.Produce(juiceMenu[0], fruits, 50, 5);

Console.WriteLine(press.Result.ErrorMessage);

Console.ReadLine();

