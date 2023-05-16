using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class FruitPressResult
    {
        
        /// <summary>
        /// IRecipe håller props
        /// string Name { get; }
        /// Type AllowedFruit { get; }
        /// /// decimal ConsumptionPerGlass { get; }
        /// int PricePerGlass { get; }
        /// </summary>
        public IRecipe Recipe { get; set; }
        public int GlassesToServe { get; set; }
        public int MoneyPaid { get; set; }
        public int MoneyBack { get; set; }
        public decimal FruitLeft { get; set; }
        public Type Fruit { get; set; }
        public string ErrorMessage { get; set; }
      
    }
}
