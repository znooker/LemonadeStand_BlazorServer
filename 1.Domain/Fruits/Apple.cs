using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Fruits
{
    public class Apple : IFruit
    {
        public string Name { get;} = "Apple";
        public int Amount { get; set; }
    }
}
