using _1.Domain.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    internal class Recipe : IRecipe
    {

        public Recipe(string name, IFruit fruit, decimal fruitConsumptionPerGlass, int pricePerGlass)
        {
            Name = name;
            AllowedFruit = fruit.GetType();
            ConsumptionPerGlass = fruitConsumptionPerGlass;
            PricePerGlass = pricePerGlass;
        }

        public string Name { get; set; }

        public Type AllowedFruit { get; set; }

        public decimal ConsumptionPerGlass { get; set; }

        public int PricePerGlass { get; set; }


    }



}

