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
        public int GlassesToServe { get; set; }
        public int MoneyBack { get; set; }
        public decimal FruitLeft { get; set; }
        public string Message { get; set; }
    }
}
