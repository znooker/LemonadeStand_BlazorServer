using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class JuiceMenu : IJuiceMenu
    {
        public List<IRecipe> Recipies { get; } = new List<IRecipe>();

        public JuiceMenu()
        {
            Recipies.Add(new Recipe() { Name="Appple Juice", AllowedFruit=typeof(Apple), ConsumptionPerGlass=2.5m, PricePerGlass=10});
            Recipies.Add(new Recipe() { Name="Orange Juice", AllowedFruit=typeof(Orange), ConsumptionPerGlass=1m, PricePerGlass=9});
            Recipies.Add(new Recipe() { Name="Melon Juice", AllowedFruit=typeof(Melon), ConsumptionPerGlass=0.5m, PricePerGlass=12});
        
        }
   
    }
}
