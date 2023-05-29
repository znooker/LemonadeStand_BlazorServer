using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Extentions
{
    public static class FruitExtensions
    {

        public static List<IFruit> UpdateFruits(this List<IFruit> Fruits, int amount, Type fruit)
        {
            var tempFruits = new List<IFruit>();

            if (Fruits is not null)
            {
                Fruits.RemoveAll(f => f.GetType() == fruit);
                tempFruits = Fruits;
            }

            IFruit tempFruit = fruit.CreateFruitClassFromType();

            for (int i = 0; i < amount; i++)
            {
                tempFruits.Add(tempFruit);
            }

            return tempFruits;
        }

       public static Collection<IFruit> ConvertListToCollection(this List<IFruit> Fruits)
        {
            Collection<IFruit> _fruits = new();
            foreach (var item in Fruits)
            {
                _fruits.Add(item);
            }
            return _fruits;
        }

        public static decimal FruitsLeftAfterProcessing(this Collection<IFruit> fruits, IRecipe recipe, int orderedGlassQuantity)
        {
            decimal _orderedGlassQuantity = orderedGlassQuantity;
            decimal fruitsLeft = fruits.Count - (recipe.ConsumptionPerGlass * _orderedGlassQuantity);

            return fruitsLeft;
        }

        public static int CalculateChange(this int moneyPaid, IRecipe recipe, int orderedGlassQuantity)
        {
            return moneyPaid - (recipe.PricePerGlass * orderedGlassQuantity);
        }

        public static IFruit CreateFruitClassFromType(this Type _fruit)
        {
            IFruit fruit = null;

            switch (_fruit.Name.ToLower())
            {
                case "apple":

                    fruit = new Apple();
                    break;
                case "orange":

                    fruit = new Orange();
                    break;
                case "melon":

                    fruit = new Melon();
                    break;

                default:
                    break;
            }

            return fruit;
        }


    }



}
