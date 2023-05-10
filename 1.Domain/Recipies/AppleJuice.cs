using _1.Domain.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    public class AppleJuice : IRecipe
    {
        public string Name { get; } = "Apple Juice";

        public Type AllowedFruit { get; } = typeof(Apple);

        public decimal ConsumptionPerGlass { get; } = 2.5m;

        public int PricePerGlass { get; } = 10;

       
    }
}
