using _1.Domain.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    public class OrangeJuice : IRecipe
    {
        public string Name { get; set; } = "Orange Juice";

        public Type AllowedFruit { get; } = typeof(Orange);

        public decimal ConsumptionPerGlass { get; } = 1m;

        public int PricePerGlass { get; } = 9;
    }
}
