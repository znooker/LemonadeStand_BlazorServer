using _1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    public class Recipe : IRecipe
    {
        public string Name { get; set; }

        public Type AllowedFruit { get; set; }

        public decimal ConsumptionPerGlass { get; set; }

        public int PricePerGlass { get; set; }

        public string ImagePath { get; set; }
    }
}
