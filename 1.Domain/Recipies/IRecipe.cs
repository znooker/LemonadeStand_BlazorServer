using _1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    public interface IRecipe: IImage
    {
        string Name { get; set; }
        Type AllowedFruit { get; set; }
        decimal ConsumptionPerGlass { get; set; }
        int PricePerGlass { get; set; }

    }
}
