using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    internal interface IRecipe
    {
        string Name { get; }
        Type AllowedFruit { get; }
        decimal ConsumptionPerGlass { get; }
        int PricePerGlass { get; }
    }
}
