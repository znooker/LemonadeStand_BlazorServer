using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class FruitPressResult
    {
        public List<IFruit> Fruits { get; set; }
        public IRecipe Recipe { get; set; }
        public int GlassesToServe { get; set; }
        public int MoneyCange { get; set; }
        public string Message { get; set; }
    }
}
