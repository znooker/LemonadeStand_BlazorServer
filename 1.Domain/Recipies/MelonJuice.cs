using _1.Domain.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    public class MelonJuice : IRecipe
    {
        public string Name { get; } = "Melon Juice";

        public Type AllowedFruit { get; } = typeof(Melon);

        public decimal ConsumptionPerGlass { get; } = 0.5m;

        public int PricePerGlass { get; } = 12;
    }
}
